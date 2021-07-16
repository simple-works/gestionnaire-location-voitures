using System;
using System.Collections.Generic;
using System.Data;

namespace Car_Rental_Project.DAI
{
    /// <summary>
    /// Représente une couche de gestion des données permettant
    /// de manipuler les données d'une table de données
    /// (Ajouter, Modifier, Supprimer, Filtrer, Trier, ...etc)
    /// </summary>
    public class DataManagement
    {
        private DataAccess dataAccess;
        private DataTable table;
        private DataColumn[] primaryKeys;
        private DataView view;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Table
        {
            get { return table; }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la couche de gestion des données.
        /// </summary>
        /// <param name="NomTable">Nom de la table à charger pour la gestion.</param>
        /// <param name="NomsClésPrimaires">Tableau des noms des clés primaires de la table.</param>
        public DataManagement(DataDescription.Tables tableInfos)
        {
            // Crée un nouveau accés aux données.
            dataAccess = new DataAccess();

            // Remplit la table de données.
            table = dataAccess.Load(tableInfos.SelectCommandText);

            // Remplit le tableau des clés primaires.
            primaryKeys = new DataColumn[tableInfos.PrimaryKeysNames.Length];
            for (int i = 0; i < tableInfos.PrimaryKeysNames.Length; i++)
            {
                primaryKeys[i] = table.Columns[tableInfos.PrimaryKeysNames[i]];
            }

            // Définit les clés primaires de la table de données.
            table.PrimaryKey = primaryKeys;

            // Crée une nouvelle vue pour la table.
            view = new DataView(table);
        }

        /// <summary>
        /// Filtre les lignes de la table de données et les affiche dans une vue.
        /// </summary>
        /// <param name="keywords">Mots utilisés comme critères pour rechercher les lignes.</param>
        /// <param name="columnsNames">Tableau des noms de colonnes qui acceptent les mots clés utilisés.</param>
        /// <returns>Vue de données filtrées.</returns>
        public DataView Filter(string keywords, params string[] columnsNames)
        {
            view.RowFilter = string.Format("{0} like '%{1}%'", string.Join("+", columnsNames), keywords);
            return view;
        }

        /// <summary>
        /// Trie les lignes de la table de données et les affiiche dans une vue.
        /// </summary>
        /// <param name="ascending">Si la valeur est vrai, trier les lignes par ordre
        /// croissant, sion trier par ordre décroissant.</param>
        /// <param name="columnsNames">Tableau des noms de colonnes selon lesquelles trier les lignes.</param>
        /// <returns>Vue de données triées.</returns>
        public DataView Sort(bool ascending, params string[] columnsNames)
        {
            string order = "ASC";
            if (!ascending) order = "DESC";
            if (string.Concat(columnsNames) == "") view.Sort = "";
            else view.Sort = string.Join(",", columnsNames) + " " + order;
            return view;
        }

        /// <summary>
        /// Obtient les valeurs des champs dont les colonnes sont des clés primaires de la table
        /// en filtrant les champs selon les colonnes pour extraire seulement les champs clés.
        /// </summary>
        /// <param name="columnsNames">Tableau des valeurs des champs utilisés de la table.</param>
        /// <returns>Tableau des valeurs des champs clés.</returns>
        public object[] GetPrimaryKeysValues(params object[] columnsNames)
        {
            List<object> primaryKeysValues = new List<object>(primaryKeys.Length);
            for (int i = 0; i < columnsNames.Length; i++)
            {
                if (table.Columns[i].Unique && !table.Columns[i].AllowDBNull)
                {
                    primaryKeysValues.Add(columnsNames[i]);
                }
            }
            return primaryKeysValues.ToArray();
        }

        /// <summary>
        /// Crée une ligne à l'aide des valeurs de champs spécifiées et l'ajoute à la table.
        /// </summary>
        /// <param name="columnsNames">Tableau des valeurs des champs utilisées pour créer la nouvelle ligne.</param>
        /// <returns>Vrai si la ligne est ajoutée à la table.</returns>
        public bool Insert(params object[] columnsNames)
        {
            DataRow rowToInsert = table.Rows.Find(GetPrimaryKeysValues(columnsNames));
            if (rowToInsert == null)
            {
                table.Rows.Add(columnsNames);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Mis à jour une ligne de la table à l'aide des valeurs de champs spécifiées.
        /// </summary>
        /// <param name="columnsNames">Tableau des valeurs des champs utilisées pour mettre à jour la ligne.</param>
        /// <returns>Vrai si la ligne est modifiée dans la table.</returns>
        public bool Update(params object[] columnsNames)
        {
            object[] primaryKeysValues = GetPrimaryKeysValues(columnsNames);
            DataRow rowToUpdate = table.Rows.Find(primaryKeysValues);
            if (rowToUpdate != null)
            {
                for (int i = 0; i < columnsNames.Length; i++)
                {
                    rowToUpdate[i] = columnsNames[i];
                }
                rowToUpdate["_row_update_datetime"] = DateTime.Now;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Mis à jour une ligne de la table vers le mode Supprimé (Deleted).
        /// </summary>
        /// <param name="ColumnsNames">Tableau des valeurs des champs clés utilisées pour supprimer la ligne.</param>
        /// <returns>Vrai si la ligne est modifiée dans la table.</returns>
        public bool UpdateToDeletedFlag(params object[] primaryKeysValues)
        {
            DataRow rowToFlag = table.Rows.Find(primaryKeysValues);
            if (rowToFlag != null)
            {
                rowToFlag["_row_delete_datetime"] = DateTime.Now;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Supprime une ligne de la table comportant les valeurs de champs clés spécifiées.
        /// </summary>
        /// <param name="primaryKeysValues">Tableau des valeurs des champs clés utilisées pour supprimer la ligne.</param>
        /// <returns>Vrai si la ligne est supprimée de la table.</returns>
        public bool Delete(params object[] primaryKeysValues)
        {
            DataRow rowToDelete = table.Rows.Find(primaryKeysValues);
            if (rowToDelete != null)
            {
                rowToDelete.Delete();
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
            return dataAccess.Save();
        }

        public void SetAutoIncrement(int columnIndex)
        {
            table.Columns[columnIndex].AutoIncrement = true;
            int lastRowIndex = table.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                long lastRowCellValue = Convert.ToInt64(table.Rows[lastRowIndex][columnIndex]);
                table.Columns[columnIndex].AutoIncrementSeed = lastRowCellValue + 1;
                table.Columns[columnIndex].AutoIncrementStep = 1;
            }
        }

        public object GetLastRowCellValue(int columnIndex)
        {
            return table.Rows[table.Rows.Count - 1][columnIndex];
        }
    }
}
