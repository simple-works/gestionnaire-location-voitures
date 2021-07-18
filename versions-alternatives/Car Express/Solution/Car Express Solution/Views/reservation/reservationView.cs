using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Car_Express_Solution.Views.reservationView{
    public partial class reservationView : XtraUserControl {
        public reservationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Car_Express_Solution.ViewModels.reservationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                reservationViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for client LookUp editor
			fluentAPI.SetBinding(clientLookUpEdit.Properties, p => p.DataSource, x => x.LookUpclients.Entities);
						// Binding for client1 LookUp editor
			fluentAPI.SetBinding(client1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpclients.Entities);
						// Binding for employe LookUp editor
			fluentAPI.SetBinding(employeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpemployes.Entities);
						// Binding for vehicule LookUp editor
			fluentAPI.SetBinding(vehiculeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpvehicules.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
