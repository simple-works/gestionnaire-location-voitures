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
    public partial class Parcs_Detail : DevExpress.XtraEditors.XtraForm
    {
        public Parcs_Detail()
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
            id_parc_pkTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "id_parc_pk");
            photo_parcPictureEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "photo_parc");
            nom_parcTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "nom_parc");
            description_parcMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "description_parc");
            date_creation_parcDateEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "date_creation_parc");
            adresse_parcMemoEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "adresse_parc");
            ville_parcComboBoxEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "ville_parc");
            code_postal_parcTextEdit.EditValue = API.Controller.GetGridViewFocusedRowValue(gridView, "code_postal_parc");
        }

    }
}