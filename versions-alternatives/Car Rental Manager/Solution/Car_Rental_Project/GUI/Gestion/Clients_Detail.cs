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
    public partial class Clients_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Clients_Detail()
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
            id_client_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_client_pk");
            photo_clientPictureEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "photo_client");
            nom_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_client");
            prenom_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "prenom_client");
            nationalite_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nationalite_client");
            date_naissance_clientDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_naissance_client");
            lieu_naissance_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_naissance_client");
            adresse_domicile_clientMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "adresse_domicile_client");
            ville_domicile_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "ville_domicile_client");
            code_postal_domicile_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "code_postal_domicile_client");
            adresse_residence_clientMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "adresse_residence_client");
            ville_residence_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "ville_residence_client");
            code_postal_residence_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "code_postal_residence_client");
            telephone_portable_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "telephone_portable_client");
            telephone_fixe_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "telephone_fixe_client");
            fax_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "fax_client");
            email_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "email_client");
            type_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "type_client");
            id_national_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_national_client");
            type_id_national_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "type_id_national_client");
            date_heure_delivraison_id_national_clientDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_delivraison_id_national_client");
            lieu_delivraison_id_national_clientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_delivraison_id_national_client");
            id_permis_conduire_clientTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_permis_conduire_client");
            date_heure_delivraison_permis_clientDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_delivraison_permis_client");
            lieu_delivraison_permis_ClientComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_delivraison_permis_Client");
        }

    }
}