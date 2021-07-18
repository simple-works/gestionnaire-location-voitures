using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace Car_Express_Solution.Views.vehiculeView{
    public partial class vehiculeView : XtraUserControl {
        public vehiculeView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<Car_Express_Solution.ViewModels.vehiculeViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                vehiculeViewBindingSource, x => x.Entity, x => x.Update());
						#region contrats Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(contratsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.vehiculecontratsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.contrat,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(contratsGridView, "RowClick")
						 .EventToCommand(
						     x => x.vehiculecontratsDetails.Edit(null), x => x.vehiculecontratsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			contratsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    contratsPopUpMenu.ShowPopup(contratsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the vehiculecontratsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(contratsGridControl, g => g.DataSource, x => x.vehiculecontratsDetails.Entities);
			
														fluentAPI.BindCommand(bbicontratsNew, x => x.vehiculecontratsDetails.New());
																													fluentAPI.BindCommand(bbicontratsEdit,x => x.vehiculecontratsDetails.Edit(null), x=>x.vehiculecontratsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbicontratsDelete,x => x.vehiculecontratsDetails.Delete(null), x=>x.vehiculecontratsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbicontratsRefresh, x => x.vehiculecontratsDetails.Refresh());
																	#endregion
						#region reservations Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(reservationsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.vehiculereservationsDetails.SelectedEntity,
                    args => args.Row as Car_Express_Solution.reservation,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(reservationsGridView, "RowClick")
						 .EventToCommand(
						     x => x.vehiculereservationsDetails.Edit(null), x => x.vehiculereservationsDetails.SelectedEntity,
						     args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			reservationsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    reservationsPopUpMenu.ShowPopup(reservationsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the vehiculereservationsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(reservationsGridControl, g => g.DataSource, x => x.vehiculereservationsDetails.Entities);
			
														fluentAPI.BindCommand(bbireservationsNew, x => x.vehiculereservationsDetails.New());
																													fluentAPI.BindCommand(bbireservationsEdit,x => x.vehiculereservationsDetails.Edit(null), x=>x.vehiculereservationsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbireservationsDelete,x => x.vehiculereservationsDetails.Delete(null), x=>x.vehiculereservationsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbireservationsRefresh, x => x.vehiculereservationsDetails.Refresh());
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
