using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RCD_Project.Views.ReservationView{
    public partial class ReservationView : XtraUserControl {
        public ReservationView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<RCD_Project.ViewModels.ReservationViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                reservationViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Client LookUp editor
			fluentAPI.SetBinding(ClientLookUpEdit.Properties, p => p.DataSource, x => x.LookUpClients.Entities);
						// Binding for Client1 LookUp editor
			fluentAPI.SetBinding(Client1LookUpEdit.Properties, p => p.DataSource, x => x.LookUpClients.Entities);
						// Binding for Employe LookUp editor
			fluentAPI.SetBinding(EmployeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpEmployes.Entities);
						// Binding for Vehicule LookUp editor
			fluentAPI.SetBinding(VehiculeLookUpEdit.Properties, p => p.DataSource, x => x.LookUpVehicules.Entities);
									fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
