using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace Car_Express_Solution.Views.Car_Express_EntitiesView{
    public partial class Car_Express_EntitiesView : XtraUserControl {
        public Car_Express_EntitiesView() {
		     InitializeComponent();
			 if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation() {
            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);
			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            MVVMContext.RegisterFlyoutDialogService();
            
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<Car_Express_Solution.ViewModels.Car_Express_EntitiesViewModel>();

            tileBar.SelectedItem = tileBarItemMain;

            fluentAPI.BindCommand(tileBarItemclientCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			fluentAPI.BindCommand(tileBarItemcontratCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			fluentAPI.BindCommand(tileBarItememployeCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(tileBarItemreservationCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			fluentAPI.BindCommand(tileBarItemutilisateurCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(tileBarItemvehiculeCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
						            
            // We want show the default module when our UserControl is loaded
            //fluentAPI.WithEvent<EventArgs>(this, "Load").EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
    }
}
