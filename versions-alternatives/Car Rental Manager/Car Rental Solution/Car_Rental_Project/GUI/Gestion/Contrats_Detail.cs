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
    public partial class Contrats_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Contrats_Detail()
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
            id_contrat_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_contrat_pk");
            id_client_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_client_fk");
            immatriculation_vehicule_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "immatriculation_vehicule_fk");
            id_client_compagnon_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_client_compagnon_fk");
            id_employe_conducteur_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_employe_conducteur_fk");
            description_equipements_speciaux_contratMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "description_equipements_speciaux_contrat");
            date_heure_depart_vehicule_contratDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_depart_vehicule_contrat");
            date_heure_retour_vehicule_contratDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_retour_vehicule_contrat");
            id_agence_depart_contrat_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_depart_contrat_fk");
            id_agence_retour_contrat_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_retour_contrat_fk");
            lieu_depart_vehicule_contratComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_depart_vehicule_contrat");
            lieu_retour_vehicule_contratComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_retour_vehicule_contrat");
            frais_conducteur_contratCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "frais_conducteur_contrat");
            frais_equipements_speciaux_contratCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "frais_equipements_speciaux_contrat");
            montant_forfait_contratCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "montant_forfait_contrat");
            montant_remise_contratCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "montant_remise_contrat");
            mode_paiement_contratComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "mode_paiement_contrat");
            nom_utilisateur_commentateur_contrat_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_utilisateur_commentateur_contrat_fk");
            commentaire_contratMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "commentaire_contrat");

        }

    }
}