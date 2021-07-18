using System;
using System.Windows.Forms;

namespace Car_Rental_Project.GUI.Gestion
{
    public partial class Clients_Collection : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionClients;
        private Clients_Detail detailClient;
        public Clients_Collection()
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
                gestionClients = new DAI.DataManagement(DAI.DataDescription.Tables.Client);
                gridControl1.DataSource = gestionClients.Table;
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
                detailClient = new Clients_Detail();
                API.Controller.FormInstanceOpen(ref detailClient, Program.MainForm);
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
                detailClient = new Clients_Detail();
                API.Controller.FormInstanceOpen(ref detailClient, Program.MainForm);
                detailClient.FillEditControlsFromGridViewFocusedRow(gridView1);
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
                    string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, DAI.DataDescription.Tables.Client.PrimaryKeysNames[0]).ToString();
                    if (API.Message.YesNoQuestion("Supprimer ?", "Suppression"))
                    {
                        gestionClients.UpdateToDeletedFlag(id);
                        gestionClients.Save();
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