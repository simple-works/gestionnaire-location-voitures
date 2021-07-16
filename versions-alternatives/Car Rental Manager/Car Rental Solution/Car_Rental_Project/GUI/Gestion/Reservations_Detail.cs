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
    public partial class Reservations_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Reservations_Detail()
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
            id_reservationTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_reservation");
            id_client_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_client_fk");
            immatriculation_vehicule_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "immatriculation_vehicule_fk");
            id_client_compagnon_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_client_compagnon_fk");
            id_employe_conducteur_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_employe_conducteur_fk");
            description_equipements_speciaux_contratMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "description_equipements_speciaux_contrat");
            date_heure_depart_vehicule_reservationDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_depart_vehicule_reservation");
            date_heure_retour_vehicule_reservationDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_heure_retour_vehicule_reservation");
            id_agence_depart_reservation_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_depart_reservation_fk");
            id_agence_retour_reservation_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_retour_reservation_fk");
            lieu_depart_vehicule_reservationComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_depart_vehicule_reservation");
            lieu_retour_vehicule_reservationComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "lieu_retour_vehicule_reservation");
            frais_conducteur_reservationCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "frais_conducteur_reservation");
            frais_equipements_speciaux_reservationCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "frais_equipements_speciaux_reservation");
            montant_forfait_reservationCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "montant_forfait_reservation");
            montant_remise_reservationCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "montant_remise_reservation");
            mode_paiement_reservationComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "mode_paiement_reservation");
            nom_utilisateur_commentateur_reservation_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_utilisateur_commentateur_reservation_fk");
            commentaire_reservationMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "commentaire_reservation");
        }

    }
}