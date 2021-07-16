using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Car_Express_Solution.Views.employeView{
    public partial class employeView : XtraUserControl {
        public employeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Car_Express_Solution.ViewModels.employeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                employeViewBindingSource, x => x.Entity, x => x.Update());
						#region contrats Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(contratsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.employecontratsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.contrat,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(contratsGridView, "RowClick")
						 .EventToCommand(
						     x => x.employecontratsDetails.Edit(null), x => x.employecontratsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			contratsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    contratsPopUpMenu.ShowPopup(contratsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the employecontratsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(contratsGridControl, g => g.DataSource, x => x.employecontratsDetails.Entities);
			
														fluentAPI.BindCommand(bbicontratsNew, x => x.employecontratsDetails.New());
																													fluentAPI.BindCommand(bbicontratsEdit,x => x.employecontratsDetails.Edit(null), x=>x.employecontratsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbicontratsDelete,x => x.employecontratsDetails.Delete(null), x=>x.employecontratsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbicontratsRefresh, x => x.employecontratsDetails.Refresh());
																	#endregion
						#region reservations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(reservationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.employereservationsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.reservation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(reservationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.employereservationsDetails.Edit(null), x => x.employereservationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			reservationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    reservationsPopUpMenu.ShowPopup(reservationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the employereservationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(reservationsGridControl, g => g.DataSource, x => x.employereservationsDetails.Entities);
			
														fluentAPI.BindCommand(bbireservationsNew, x => x.employereservationsDetails.New());
																													fluentAPI.BindCommand(bbireservationsEdit,x => x.employereservationsDetails.Edit(null), x=>x.employereservationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbireservationsDelete,x => x.employereservationsDetails.Delete(null), x=>x.employereservationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbireservationsRefresh, x => x.employereservationsDetails.Refresh());
																	#endregion
						#region utilisateurs Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(utilisateursGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.employeutilisateursDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.utilisateur,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(utilisateursGridView, "RowClick")
						 .EventToCommand(
						     x => x.employeutilisateursDetails.Edit(null), x => x.employeutilisateursDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			utilisateursGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    utilisateursPopUpMenu.ShowPopup(utilisateursGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the employeutilisateursDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(utilisateursGridControl, g => g.DataSource, x => x.employeutilisateursDetails.Entities);
			
														fluentAPI.BindCommand(bbiutilisateursNew, x => x.employeutilisateursDetails.New());
																													fluentAPI.BindCommand(bbiutilisateursEdit,x => x.employeutilisateursDetails.Edit(null), x=>x.employeutilisateursDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiutilisateursDelete,x => x.employeutilisateursDetails.Delete(null), x=>x.employeutilisateursDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiutilisateursRefresh, x => x.employeutilisateursDetails.Refresh());
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
