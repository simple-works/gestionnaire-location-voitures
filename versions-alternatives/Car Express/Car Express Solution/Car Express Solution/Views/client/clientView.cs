using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Car_Express_Solution.Views.clientView{
    public partial class clientView : XtraUserControl {
        public clientView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Car_Express_Solution.ViewModels.clientViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                clientViewBindingSource, x => x.Entity, x => x.Update());
						#region contrats Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(contratsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.clientcontratsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.contrat,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(contratsGridView, "RowClick")
						 .EventToCommand(
						     x => x.clientcontratsDetails.Edit(null), x => x.clientcontratsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			contratsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    contratsPopUpMenu.ShowPopup(contratsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the clientcontratsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(contratsGridControl, g => g.DataSource, x => x.clientcontratsDetails.Entities);
			
														fluentAPI.BindCommand(bbicontratsNew, x => x.clientcontratsDetails.New());
																													fluentAPI.BindCommand(bbicontratsEdit,x => x.clientcontratsDetails.Edit(null), x=>x.clientcontratsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbicontratsDelete,x => x.clientcontratsDetails.Delete(null), x=>x.clientcontratsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbicontratsRefresh, x => x.clientcontratsDetails.Refresh());
																	#endregion
						#region contrats1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(contrats1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.clientcontrats1Details.SelectedEntity,
                    args => args.Row as Car_Express_Solution.contrat,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(contrats1GridView, "RowClick")
						 .EventToCommand(
						     x => x.clientcontrats1Details.Edit(null), x => x.clientcontrats1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			contrats1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    contrats1PopUpMenu.ShowPopup(contrats1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the clientcontrats1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(contrats1GridControl, g => g.DataSource, x => x.clientcontrats1Details.Entities);
			
														fluentAPI.BindCommand(bbicontrats1New, x => x.clientcontrats1Details.New());
																													fluentAPI.BindCommand(bbicontrats1Edit,x => x.clientcontrats1Details.Edit(null), x=>x.clientcontrats1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbicontrats1Delete,x => x.clientcontrats1Details.Delete(null), x=>x.clientcontrats1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbicontrats1Refresh, x => x.clientcontrats1Details.Refresh());
																	#endregion
						#region reservations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(reservationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.clientreservationsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.reservation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(reservationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.clientreservationsDetails.Edit(null), x => x.clientreservationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			reservationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    reservationsPopUpMenu.ShowPopup(reservationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the clientreservationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(reservationsGridControl, g => g.DataSource, x => x.clientreservationsDetails.Entities);
			
														fluentAPI.BindCommand(bbireservationsNew, x => x.clientreservationsDetails.New());
																													fluentAPI.BindCommand(bbireservationsEdit,x => x.clientreservationsDetails.Edit(null), x=>x.clientreservationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbireservationsDelete,x => x.clientreservationsDetails.Delete(null), x=>x.clientreservationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbireservationsRefresh, x => x.clientreservationsDetails.Refresh());
																	#endregion
						#region reservations1 Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(reservations1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.clientreservations1Details.SelectedEntity,
                    args => args.Row as Car_Express_Solution.reservation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(reservations1GridView, "RowClick")
						 .EventToCommand(
						     x => x.clientreservations1Details.Edit(null), x => x.clientreservations1Details.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			reservations1GridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    reservations1PopUpMenu.ShowPopup(reservations1GridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the clientreservations1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(reservations1GridControl, g => g.DataSource, x => x.clientreservations1Details.Entities);
			
														fluentAPI.BindCommand(bbireservations1New, x => x.clientreservations1Details.New());
																													fluentAPI.BindCommand(bbireservations1Edit,x => x.clientreservations1Details.Edit(null), x=>x.clientreservations1Details.SelectedEntity);
																								fluentAPI.BindCommand(bbireservations1Delete,x => x.clientreservations1Details.Delete(null), x=>x.clientreservations1Details.SelectedEntity);
																			fluentAPI.BindCommand(bbireservations1Refresh, x => x.clientreservations1Details.Refresh());
																	#endregion
												fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
						fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());	
       }
    }
}
