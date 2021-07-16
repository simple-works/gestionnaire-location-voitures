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
    public partial class Employes_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Employes_Detail()
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
            id_employe_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_employe_pk");
            photo_employePictureEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "photo_employe");
            nom_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_employe");
            prenom_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "prenom_employe");
            nationalite_employeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nationalite_employe");
            date_naissance_employeDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_naissance_employe");
            lieu_naissance_employeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_naissance_employe");
            adresse_domicile_employeMemoExEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "adresse_domicile_employe");
            ville_domicile_employeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "ville_domicile_employe");
            code_postal_domicile_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "code_postal_domicile_employe");
            telephone_portable_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "telephone_portable_employe");
            telephone_fixe_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "telephone_fixe_employe");
            fax_employeTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "fax_employe");
            email_employeHyperLinkEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "email_employe");
            date_embauche_employeDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_embauche_employe");
            fonction_employeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "fonction_employe");
            id_agence_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_fk");
        }

    }
}