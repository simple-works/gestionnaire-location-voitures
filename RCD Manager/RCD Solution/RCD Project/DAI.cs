using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAI
{
    /// <summary>
    /// Représente l'ensemble des propriétés relatifs à la configuration de la connexion à la base de données SQL, 
    /// ainsi que les noms et valeurs globaux utilisées dans les couches d'accées et de gestion de données.
    /// </summary>
    public static class DataDescription
    {
        /// <summary>
        /// Chaîne de connexion comportant le nom de la base de données source et d'autres
        /// paramètres nécessaires à l'établissement de la connexion initiale.
        /// </summary>
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["RCD_DAI"].ToString();

        /// <summary>
        /// Liste d'informations sur les tables de données utilisées par les couches d'accées 
        /// et de gestion de données. Ces informations correspondent principalement aux noms significatifs
        /// des tables et aux commandes SQL de sélection de leurs données depuis la base de données.
        /// Chaque instance contient les informations sur une table dans la base de données permettant 
        /// de l'identifier et d'utiliser ses données dans les couches d'accées et de gestion de données.
        /// </summary>
        public class TableInfos
        {
            #region Définir les informations des tables
            public static TableInfos Utilisateur = new TableInfos(
                "utilisateur",
                "SELECT * FROM utilisateur",
                "nom_utilisateur_pk"
            );
            public static TableInfos Employe = new TableInfos(
                "employe",
                "SELECT * FROM employe",
                "id_employe_pk"
            );
            public static TableInfos Client = new TableInfos(
                "client",
                "SELECT * FROM client",
                "id_client_pk"
            );
            public static TableInfos Vehicule = new TableInfos(
                "vehicule",
                "SELECT * FROM vehicule",
                "immatriculation_vehicule_pk"
            );
            public static TableInfos Contrat = new TableInfos(
                "contrat",
                "SELECT * FROM contrat",
                "id_contrat_pk"
            );
            public static TableInfos Reservation = new TableInfos(
                "reservation",
                "SELECT * FROM reservation",
                "id_reservation_pk"
            );
            #endregion


            public string TableName { get; private set; }
            public string SelectCommandText { get; private set; }
            public string[] PrimaryKeysNames { get; private set; }

            /// <summary>
            /// Initialise une nouvelle instance de la classe des informations des tables.
            /// </summary>
            /// <param name="TableName">Nom que doit avoir la table de données qui va 
            /// recevoir les données sélectionnées depuis la base de données.</param>
            /// <param name="SelectCommandText">Requête SQL permettant de sélectionner
            /// des données depuis la base données afin d'en faire une table de données.</param>
            /// <param name="PrimaryKeysNames">Noms des colonnes à consiérer comme clés primaires 
            /// une fois la table de données créée. Ces colonnes doivent être mentionnées 
            /// dans la requête de sélection.</param>
            public TableInfos(string TableName, string SelectCommandText, params string[] PrimaryKeysNames)
            {
                this.TableName = TableName;
                this.SelectCommandText = SelectCommandText;
                this.PrimaryKeysNames = PrimaryKeysNames;
            }
        }
    }

    /// <summary>
    /// Représente une couche d'accés aux données permettant 
    /// de recevoir et d'envoyer des données depuis une base de données SQL.
    /// </summary>
    public class DataAccess
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataAdapter _data_adapter;
        private SqlCommandBuilder _command_builder;
        private DataTable _table;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Table
        {
            get { return _table; }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la couche d'accés aux données.
        /// </summary>
        public DataAccess()
        {
            _connection = new SqlConnection(DataDescription.ConnectionString);
            _command = new SqlCommand("", _connection);
            _data_adapter = new SqlDataAdapter(_command);
            _command_builder = new SqlCommandBuilder(_data_adapter);
            _table = new DataTable();
        }

        /// <summary>
        /// Charge les données d'une table depuis la base de données dans une table de données.
        /// </summary>
        /// <param name="CommandText"></param>
        /// <returns>Table de données chargée</returns>
        public DataTable Load(string CommandText)
        {
            _command.CommandText = CommandText;
            _data_adapter.Fill(_table);
            return _table;
        }

        /// <summary>
        /// Mis à jour les données d'une table de la base de données depuis une table de données.
        /// </summary>
        /// <returns>Nombre de lignes correctement mises à jour à partir de la table de données</returns>
        public int Save()
        {
            return _data_adapter.Update(_table);
        }
    }

    /// <summary>
    /// Représente une couche de gestion des données permettant
    /// de manipuler les données d'une table de données
    /// (Ajouter, Modifier, Supprimer, Filtrer, Trier, ...etc)
    /// </summary>
    public class DataManagement
    {
        private DataAccess _data_access;
        private DataTable _table;
        private DataColumn[] _primary_keys;
        private DataView _view;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Table
        {
            get { return _table; }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la couche de gestion des données.
        /// </summary>
        /// <param name="NomTable">Nom de la table à charger pour la gestion.</param>
        /// <param name="NomsClésPrimaires">Tableau des noms des clés primaires de la table.</param>
        public DataManagement(DataDescription.TableInfos TableInfos)
        {
            // Crée un nouveau accés aux données.
            _data_access = new DataAccess();

            // Remplit la table de données.
            _table = _data_access.Load(TableInfos.SelectCommandText);

            // Remplit le tableau des clés primaires.
            _primary_keys = new DataColumn[TableInfos.PrimaryKeysNames.Length];
            for (int i = 0; i < TableInfos.PrimaryKeysNames.Length; i++)
            {
                _primary_keys[i] = _table.Columns[TableInfos.PrimaryKeysNames[i]];
            }

            // Définit les clés primaires de la table de données.
            _table.PrimaryKey = _primary_keys;

            // Crée une nouvelle vue pour la table.
            _view = new DataView(_table);
        }

        /// <summary>
        /// Filtre les lignes de la table de données et les affiche dans une vue.
        /// </summary>
        /// <param name="Keywords">Mots utilisés comme critères pour rechercher les lignes.</param>
        /// <param name="ColumnsNames">Tableau des noms de colonnes qui acceptent les mots clés utilisés.</param>
        /// <returns>Vue de données filtrées.</returns>
        public DataView Filter(string Keywords, params string[] ColumnsNames)
        {
            _view.RowFilter = string.Format("{0} like '%{1}%'", string.Join("+", ColumnsNames), Keywords);
            return _view;
        }

        /// <summary>
        /// Trie les lignes de la table de données et les affiiche dans une vue.
        /// </summary>
        /// <param name="Ascending">Si la valeur est vrai, trier les lignes par ordre
        /// croissant, sion trier par ordre décroissant.</param>
        /// <param name="ColumnsNames">Tableau des noms de colonnes selon lesquelles trier les lignes.</param>
        /// <returns>Vue de données triées.</returns>
        public DataView Sort(bool Ascending, params string[] ColumnsNames)
        {
            string order = "ASC";
            if (!Ascending) order = "DESC";
            if (string.Concat(ColumnsNames) == "") _view.Sort = "";
            else _view.Sort = string.Join(",", ColumnsNames) + " " + order;
            return _view;
        }

        /// <summary>
        /// Obtient les valeurs des champs dont les colonnes sont des clés primaires de la table
        /// en filtrant les champs selon les colonnes pour extraire seulement les champs clés.
        /// </summary>
        /// <param name="ColumnsNames">Tableau des valeurs des champs utilisés de la table.</param>
        /// <returns>Tableau des valeurs des champs clés.</returns>
        public object[] GetPrimaryKeysValues(params object[] ColumnsNames)
        {
            List<object> primary_keys_values = new List<object>(_primary_keys.Length);
            for (int i = 0; i < ColumnsNames.Length; i++)
            {
                if (_table.Columns[i].Unique && !_table.Columns[i].AllowDBNull)
                {
                    primary_keys_values.Add(ColumnsNames[i]);
                }
            }
            return primary_keys_values.ToArray();
        }

        /// <summary>
        /// Crée une ligne à l'aide des valeurs de champs spécifiées et l'ajoute à la table.
        /// </summary>
        /// <param name="ColumnsNames">Tableau des valeurs des champs utilisées pour créer la nouvelle ligne.</param>
        /// <returns>Vrai si la ligne est ajoutée à la table.</returns>
        public bool Insert(params object[] ColumnsNames)
        {
            DataRow row_to_insert = _table.Rows.Find(GetPrimaryKeysValues(ColumnsNames));
            if (row_to_insert == null)
            {
                _table.Rows.Add(ColumnsNames);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Mis à jour une ligne de la table à l'aide des valeurs de champs spécifiées.
        /// </summary>
        /// <param name="ColumnsNames">Tableau des valeurs des champs utilisées pour mettre à jour la ligne.</param>
        /// <returns>Vrai si la ligne est modifiée dans la table.</returns>
        public bool Update(params object[] ColumnsNames)
        {
            object[] primary_keys_values = GetPrimaryKeysValues(ColumnsNames);
            DataRow row_to_update = _table.Rows.Find(primary_keys_values);
            if (row_to_update != null)
            {
                for (int i = 0; i < ColumnsNames.Length; i++)
                {
                    row_to_update[i] = ColumnsNames[i];
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Mis à jour une ligne de la table vers le mode Supprimé (Deleted).
        /// </summary>
        /// <param name="ColumnsNames">Tableau des valeurs des champs clés utilisées pour supprimer la ligne.</param>
        /// <returns>Vrai si la ligne est modifiée dans la table.</returns>
        public bool UpdateToDeletedFlag(params object[] PrimaryKeysValues)
        {
            DataRow row_to_flag = _table.Rows.Find(PrimaryKeysValues);
            if (row_to_flag != null)
            {
                //row_to_flag["_row_delete_datetime"] = DateTime.Now;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Supprime une ligne de la table comportant les valeurs de champs clés spécifiées.
        /// </summary>
        /// <param name="PrimaryKeysValues">Tableau des valeurs des champs clés utilisées pour supprimer la ligne.</param>
        /// <returns>Vrai si la ligne est supprimée de la table.</returns>
        public bool Delete(params object[] PrimaryKeysValues)
        {
            DataRow row_to_delete = _table.Rows.Find(PrimaryKeysValues);
            if (row_to_delete != null)
            {
                row_to_delete.Delete();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Applique les mises à jour effectuées dans la table de données 
        /// sur la table correspondante dans la base de données.
        /// </summary>
        /// <returns>Nombre de lignes correctement mises à jour à partir de la table de données</returns>
        public int Save()
        {
            return _data_access.Save();
        }
    }
}
