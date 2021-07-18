using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Car_Rental_Project.GUI.Gestion
{
    public partial class Utilisateurs_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Utilisateurs_Detail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplit les contôles d'édition à partir des valeurs des cellues de la ligne 
        /// actuellement sélectionné dans la grille (GridView).
        /// </summary>
        /// <param name="gridView">Grille source des données</param>
        public void FillEditControlsFromGridViewFocusedRow(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            nom_utilisateur_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_utilisateur_pk");
            mot_passe_utilisateurTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "mot_passe_utilisateur");
            role_utilisateurComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "role_utilisateur");
            id_employe_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_employe_fk");
            date_heure_derniere_connexion_utilisaturDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_derniere_connexion_utilisatur");
        }

    }
}