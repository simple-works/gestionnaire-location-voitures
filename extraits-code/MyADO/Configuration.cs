using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO_Layers
{
    /// <summary>
    /// Représente l'ensemble des propriétés relatifs à la configuration de la connexion à la base de données SQL, 
    /// ainsi que les noms et valeurs globaux utilisées dans les couches d'accées et de gestion de données.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Chaîne de connexion comportant le nom de la base de données source et d'autres
        /// paramètres nécessaires à l'établissement de la connexion initiale.
        /// </summary>
        public static string CHAINE_CONNEXION = @"Data Source=.\AMBRATOLM_SQL;
                                                  Initial Catalog=ShopKeeperDb;
                                                  Integrated Security=True";

        /// <summary>
        /// Liste d'informations sur les tables de données utilisées par les couches d'accées 
        /// et de gestion de données. Ces informations correspondent principalement aux noms significatifs
        /// des tables et aux commandes SQL de sélection de leurs données depuis la base de données.
        /// Chaque instance contient les informations sur une table dans la base de données permettant 
        /// de l'identifier et d'utiliser ses données dans les couches d'accées et de gestion de données.
        /// </summary>
        public class INFOS_TABLES
        {
            #region Définir les informations des tables
            public static INFOS_TABLES Client = new INFOS_TABLES(
                "Client",
                "select * from Client",
                "id"
            );
            public static INFOS_TABLES Produit = new INFOS_TABLES(
                "Produit",
                "select * from Produit",
                "ref"
            );
            public static INFOS_TABLES Commande = new INFOS_TABLES(
                "Commande",
                "select * from Commande",
                "id_client", "ref_produit"
            );
            public static INFOS_TABLES CommandeClientProduit = new INFOS_TABLES(
                "CommandeClientProduit",
                @"select * from Commande 
                    inner join Client on Commande.id_client = Client.id
                    inner join Produit on Commande.ref_produit = Produit.ref",
                "id_client", "ref_produit"
            );
            #endregion

            public string NomTable { get; private set; }
            public string TexteCommandeSélection { get; private set; }
            public string[] NomsClésPrimaires { get; private set; }
            public string[] NomsIdentités { get; private set; }
            
            /// <summary>
            /// Initialise une nouvelle instance de la classe des informations des tables.
            /// </summary>
            /// <param name="NomTable">Nom que doit avoir la table de données qui va 
            /// recevoir les données sélectionnées depuis la base de données.</param>
            /// <param name="TexteCommandeSélection">Requête SQL permettant de sélectionner
            /// des données depuis la base données afin d'en faire une table de données.</param>
            /// <param name="NomsClésPrimaires">Noms des colonnes à consiérer comme clés primaires 
            /// une fois la table de données créée. Ces colonnes doivent être mentionnées 
            /// dans la requête de sélection.</param>
            public INFOS_TABLES(string NomTable, string TexteCommandeSélection, params string[] NomsClésPrimaires)
            {
                this.NomTable = NomTable;
                this.TexteCommandeSélection = TexteCommandeSélection;
                this.NomsClésPrimaires = NomsClésPrimaires;
            }
        }
    }
}
