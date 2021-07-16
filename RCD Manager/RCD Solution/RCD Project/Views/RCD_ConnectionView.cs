using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraReports.UI;
using RCD_Project.Views.Main;

namespace RCD_Project.Views.RCD_ConnectionView{
    public partial class RCD_ConnectionView : XtraUserControl {
        public RCD_ConnectionView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();

            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<RCD_Project.ViewModels.RCD_ConnectionViewModel>();

            tileBar.SelectedItem = tileBarItemDahsboard;

			fluentAPI.BindCommand(tileBarItemClientCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			fluentAPI.BindCommand(tileBarItemContratCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			fluentAPI.BindCommand(tileBarItemEmployeCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(tileBarItemReservationCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			//fluentAPI.BindCommand(tileBarItemUtilisateurCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(tileBarItemVehiculeCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			
            // We want show the default module when our UserControl is loaded
            //fluentAPI.WithEvent<EventArgs>(this, "Load").EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }

        private void tileBarItemDahsboard_ItemClick(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPage = navigationPage1;
        }
        private void tileBarItemRapport_ItemClick(object sender, TileItemEventArgs e)
        {
            Contrat_Report report = new Contrat_Report();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void tileBarItemSettings_ItemClick(object sender, TileItemEventArgs e)
        {
            Form_Settings settings = new Form_Settings();
            settings.ShowDialog();
        }

        private void memoExEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void navigationPage1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void RCD_ConnectionView_Load(object sender, EventArgs e)
        {
            //labelControl1.Text = DateTime.Today.ToLongDateString();
        }
    }
}
