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
    public partial class Employes_Collection : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionEmployes;
        private Employes_Detail detailEmploye;
        public Employes_Collection()
        {
            try
            {
                InitializeComponent();
                InitializeGrid();
                API.Controller.ConfigureGridView(gridView1);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void InitializeGrid()
        {
            try
            {
                gestionEmployes = new DAI.DataManagement(DAI.DataDescription.Tables.Employe);
                gridControl1.DataSource = gestionEmployes.Table;
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
        private void collectionManagementControl1_Nouveau(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                detailEmploye = new Employes_Detail();
                API.Controller.FormInstanceOpen(ref detailEmploye, Program.MainForm);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void collectionManagementControl1_Editer()
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                detailEmploye = new Employes_Detail();
                API.Controller.FormInstanceOpen(ref detailEmploye, Program.MainForm);
                detailEmploye.FillEditControlsFromGridViewFocusedRow(gridView1);
            }
        }
        private void collectionManagementControl1_Editer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                collectionManagementControl1_Editer();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void collectionManagementControl1_Supprimer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount != 0)
                {
                    string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, DAI.DataDescription.Tables.Employe.PrimaryKeysNames[0]).ToString();
                    if (API.Message.YesNoQuestion("Supprimer ?", "Suppression"))
                    {
                        gestionEmployes.UpdateToDeletedFlag(id);
                        gestionEmployes.Save();
                        InitializeGrid();
                    }
                }
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void collectionManagementControl1_Actualiser(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InitializeGrid();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void collectionManagementControl1_Apercu_Avant_Impression(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl1.ShowPrintPreview();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void collectionManagementControl1_Fermer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                collectionManagementControl1_Editer();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
    }
}