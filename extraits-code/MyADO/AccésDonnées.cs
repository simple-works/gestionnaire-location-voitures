using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Layers.ModeDéconnecté
{
    /// <summary>
    /// Représente une couche d'accés aux données permettant 
    /// de recevoir et d'envoyer des données depuis une base de données SQL.
    /// </summary>
    public class AccésDonnées // Mode Déconnecté
    {     
        private SqlConnection CONNEXION;
        private SqlCommand COMMANDE;
        private SqlDataAdapter ADAPTEUR;
        private SqlCommandBuilder GENERATEUR_COMMANDES;
        private DataTable TABLE;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Données
        {
            get { return TABLE; }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la couche d'accés aux données.
        /// </summary>
        public AccésDonnées()
        {
            CONNEXION = new SqlConnection(Configuration.CHAINE_CONNEXION);
            COMMANDE = new SqlCommand("", CONNEXION);
            ADAPTEUR = new SqlDataAdapter(COMMANDE);
            GENERATEUR_COMMANDES = new SqlCommandBuilder(ADAPTEUR);
            TABLE = new DataTable();
        }

        /// <summary>
        /// Charge les données d'une table depuis la base de données dans une table de données.
        /// </summary>
        /// <param name="TexteCommande"></param>
        /// <param name="NomTable"></param>
        /// <returns></returns>
        public DataTable Charger(string TexteCommande)
        {
            COMMANDE.CommandText = TexteCommande;
            ADAPTEUR.Fill(TABLE);
            return TABLE;
        }
        
        /// <summary>
        /// Mis à jour les données d'une table de la base de données depuis une table de données.
        /// </summary>
        /// <param name="NomTable"></param>
        /// <returns>Nombre de lignes correctement mises à jour à partir de la table de données</returns>
        public int Enregistrer()
        {
            return ADAPTEUR.Update(TABLE);
        }
    }
}
