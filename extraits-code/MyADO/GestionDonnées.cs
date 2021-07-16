using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Layers.ModeDéconnecté
{
    /// <summary>
    /// Représente une couche de gestion des données permettant
    /// de manipuler les données d'une table de données
    /// (Ajouter, Modifier, Supprimer, Filtrer, Trier, ...etc)
    /// </summary>
    class GestionDonnées // Mode Déconnecté
    {
        private AccésDonnées ACCES_DONNEES;
        private DataTable TABLE;
        private DataColumn[] CLES_PRIMAIRES;        
        private DataView VUE;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Table 
        { 
            get { return TABLE; } 
        } 

        /// <summary>
        /// Initialise une nouvelle instance de la couche de gestion des données.
        /// </summary>
        /// <param name="NomTable">Nom de la table à charger pour la gestion.</param>
        /// <param name="NomsClésPrimaires">Tableau des noms des clés primaires de la table.</param>
        public GestionDonnées(Configuration.INFOS_TABLES InfosTable)
        {
            // Crée un nouveau accés aux données.
            ACCES_DONNEES = new AccésDonnées();

            // Remplit la table de données.
            TABLE = ACCES_DONNEES.Charger(InfosTable.TexteCommandeSélection);
            
            // Remplit le tableau des clés primaires.
            CLES_PRIMAIRES = new DataColumn[InfosTable.NomsClésPrimaires.Length];
            for (int i = 0; i < InfosTable.NomsClésPrimaires.Length; i++)
            {
                CLES_PRIMAIRES[i] = TABLE.Columns[InfosTable.NomsClésPrimaires[i]];
            }

            // Définit les clés primaires de la table de données.
            TABLE.PrimaryKey = CLES_PRIMAIRES;

            // Crée une nouvelle vue pour la table.
            VUE = new DataView(TABLE);
        }

        /// <summary>
        /// Filtre les lignes de la table de données et les affiche dans une vue.
        /// </summary>
        /// <param name="MotsClés">Mots utilisés comme critères pour rechercher les lignes.</param>
        /// <param name="NomsChamps">Tableau des noms de colonnes qui acceptent les mots clés utilisés.</param>
        /// <returns>Vue de données filtrées.</returns>
        public DataView Filtrer(string MotsClés, params string[] NomsChamps)
        {
            VUE.RowFilter = string.Format("{0} like '%{1}%'", string.Join("+",NomsChamps), MotsClés);
            return VUE;
        }

        /// <summary>
        /// Trie les lignes de la table de données et les affiiche dans une vue.
        /// </summary>
        /// <param name="Croissant">Si la valeur est vrai, trier les lignes par ordre
        /// croissant, sion trier par ordre décroissant.</param>
        /// <param name="NomsChamps">Tableau des noms de colonnes selon lesquelles trier les lignes.</param>
        /// <returns>Vue de données triées.</returns>
        public DataView Trier(bool Croissant, params string[] NomsChamps)
        {
            string Ordre = "ASC";
            if (!Croissant) Ordre = "DESC";            
            if (string.Concat(NomsChamps) == "") VUE.Sort = "";
            else VUE.Sort = string.Join(",", NomsChamps) + " " + Ordre;
            return VUE;
        }

        /// <summary>
        /// Obtient les valeurs des champs dont les colonnes sont des clés primaires de la table
        /// en filtrant les champs selon les colonnes pour extraire seulement les champs clés.
        /// </summary>
        /// <param name="ValeursChamps">Tableau des valeurs des champs utilisés de la table.</param>
        /// <returns>Tableau des valeurs des champs clés.</returns>
        public object[] ObtenirValeursClésPrimaires(params object[] ValeursChamps)
        {
            List<object> ValeursClésPrimaires = new List<object>(CLES_PRIMAIRES.Length);
            for (int i = 0; i < ValeursChamps.Length; i++)
            {
                if (TABLE.Columns[i].Unique && !TABLE.Columns[i].AllowDBNull)
                {
                    ValeursClésPrimaires.Add(ValeursChamps[i]);
                }
            }
            return ValeursClésPrimaires.ToArray();
        }

        /// <summary>
        /// Crée une ligne à l'aide des valeurs de champs spécifiées et l'ajoute à la table.
        /// </summary>
        /// <param name="ValeursChamps">Tableau des valeurs des champs utilisées pour créer la nouvelle ligne.</param>
        /// <returns>Vrai si la ligne est ajoutée à la table.</returns>
        public bool Ajouter(params object[] ValeursChamps)
        {
            DataRow LigneÀAjouter = TABLE.Rows.Find(ObtenirValeursClésPrimaires(ValeursChamps));
            if (LigneÀAjouter == null)
            {
                TABLE.Rows.Add(ValeursChamps);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Mis à jour une ligne de la table à l'aide des valeurs de champs spécifiées.
        /// </summary>
        /// <param name="ValeursChamps">Tableau des valeurs des champs utilisées pour mettre à jour la ligne.</param>
        /// <returns>Vrai si la ligne est modifiée dans la table.</returns>
        public bool Modifier(params object[] ValeursChamps)
        {
            object[] ValeursClésPrimaires = ObtenirValeursClésPrimaires(ValeursChamps);
            DataRow LigneÀModifier = TABLE.Rows.Find(ValeursClésPrimaires);
            if (LigneÀModifier != null)
            {
                for (int i = 0; i < ValeursChamps.Length; i++)
                {
                    LigneÀModifier[i] = ValeursChamps[i];
                }
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Supprime une ligne de la table comportant les valeurs de champs clés spécifiées.
        /// </summary>
        /// <param name="ValeursClésPrimaires">Tableau des valeurs des champs clés utilisées pour supprimer la ligne.</param>
        /// <returns>Vrai si la ligne est supprimée de la table.</returns>
        public bool Supprimer(params object[] ValeursClésPrimaires)
        {
            DataRow LigneÀSupprimer = TABLE.Rows.Find(ValeursClésPrimaires);
            if (LigneÀSupprimer != null)
            {
                LigneÀSupprimer.Delete();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Applique les mises à jour effectuées dans la table de données 
        /// sur la table correspondante dans la base de données.
        /// </summary>
        /// <returns>Nombre de lignes correctement mises à jour à partir de la table de données</returns>
        public int Enregistrer()
        {
            return ACCES_DONNEES.Enregistrer();
        }
    }
}
