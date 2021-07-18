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
    public partial class Vehicules_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Vehicules_Detail()
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
            immatriculation_vehicule_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "immatriculation_vehicule_pk");
            photo_vehiculePictureEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "photo_vehicule");
            type_vehiculeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "type_vehicule");
            marque_vehiculeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "marque_vehicule");
            description_vehiculeMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "description_vehicule");
            distance_parcourue_vehiculeCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "distance_parcourue_vehicule");
            type_energie_vehiculeComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "type_energie_vehicule");
            quantite_energie_vehiculeCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "quantite_energie_vehicule");
            prix_location_vehiculeCalcEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "prix_location_vehicule");
            date_achat_vehiculeDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_achat_vehicule");
            date_derniere_maintenance_vehiculeDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_derniere_maintenance_vehicule");
            id_agence_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_fk");
            id_parc_fkGridLookUpEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_parc_fk");
        }

    }
}