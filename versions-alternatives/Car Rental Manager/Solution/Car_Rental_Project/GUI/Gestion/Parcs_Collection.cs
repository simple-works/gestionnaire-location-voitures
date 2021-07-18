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
    public partial class Parcs_Collection : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionParcs;
        private Parcs_Detail detailParc;
        public Parcs_Collection()
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
                gestionParcs = new DAI.DataManagement(DAI.DataDescription.Tables.Parc);
                gridControl1.DataSource = gestionParcs.Table;
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
                detailParc = new Parcs_Detail();
                API.Controller.FormInstanceOpen(ref detailParc, Program.MainForm);
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
                detailParc = new Parcs_Detail();
                API.Controller.FormInstanceOpen(ref detailParc, Program.MainForm);
                detailParc.FillEditControlsFromGridViewFocusedRow(gridView1);
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
                    string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, DAI.DataDescription.Tables.Parc.PrimaryKeysNames[0]).ToString();
                    if (API.Message.YesNoQuestion("Supprimer ?", "Suppression"))
                    {
                        gestionParcs.UpdateToDeletedFlag(id);
                        gestionParcs.Save();
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