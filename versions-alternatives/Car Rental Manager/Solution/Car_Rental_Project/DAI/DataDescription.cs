namespace Car_Rental_Project.DAI
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
        public static string ConnectionString = Properties.Settings.Default.ConnectionString;

        /// <summary>
        /// Liste d'informations sur les tables de données utilisées par les couches d'accées 
        /// et de gestion de données. Ces informations correspondent principalement aux noms significatifs
        /// des tables et aux commandes SQL de sélection de leurs données depuis la base de données.
        /// Chaque instance contient les informations sur une table dans la base de données permettant 
        /// de l'identifier et d'utiliser ses données dans les couches d'accées et de gestion de données.
        /// </summary>
        public class Tables
        {
            #region Définir les informations des tables
            public static Tables Utilisateur = new Tables(
                "utilisateur",
                "SELECT * FROM utilisateur WHERE _row_delete_datetime IS NULL",
                "nom_utilisateur_pk"
            );
            public static Tables Employe = new Tables(
                "employe",
                "SELECT * FROM employe WHERE _row_delete_datetime IS NULL",
                "id_employe_pk"
            );
            public static Tables Client = new Tables(
                "client",
                "SELECT * FROM client WHERE _row_delete_datetime IS NULL",
                "id_client_pk"
            );
            public static Tables Vehicule = new Tables(
                "vehicule",
                "SELECT * FROM vehicule WHERE _row_delete_datetime IS NULL",
                "immatriculation_vehicule_pk"
            );
            public static Tables Agence = new Tables(
                "agence",
                "SELECT * FROM agence WHERE _row_delete_datetime IS NULL",
                "id_agence_pk"
            );
            public static Tables Parc = new Tables(
                "parc",
                "SELECT * FROM parc WHERE _row_delete_datetime IS NULL",
                "id_parc_pk"
            );
            public static Tables Contrat = new Tables(
                "contrat",
                "SELECT * FROM contrat WHERE _row_delete_datetime IS NULL",
                "id_contrat_pk"
            );
            public static Tables Reservation = new Tables(
                "reservation",
                "SELECT * FROM reservation WHERE _row_delete_datetime IS NULL",
                "id_reservation"
            );
            #endregion


            public string TableName { get; private set; }
            public string SelectCommandText { get; private set; }
            public string[] PrimaryKeysNames { get; private set; }

            /// <summary>
            /// Initialise une nouvelle instance de la classe des informations des tables.
            /// </summary>
            /// <param name="tableName">Nom que doit avoir la table de données qui va 
            /// recevoir les données sélectionnées depuis la base de données.</param>
            /// <param name="selectCommandText">Requête SQL permettant de sélectionner
            /// des données depuis la base données afin d'en faire une table de données.</param>
            /// <param name="primaryKeysNames">Noms des colonnes à consiérer comme clés primaires 
            /// une fois la table de données créée. Ces colonnes doivent être mentionnées 
            /// dans la requête de sélection.</param>
            public Tables(string tableName, string selectCommandText, params string[] primaryKeysNames)
            {
                this.TableName = tableName;
                this.SelectCommandText = selectCommandText;
                this.PrimaryKeysNames = primaryKeysNames;
            }
        }
    }
}
