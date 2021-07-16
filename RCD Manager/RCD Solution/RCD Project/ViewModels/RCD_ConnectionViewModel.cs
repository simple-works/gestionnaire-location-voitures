using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using RCD_Project.RCD_ConnectionDataModel;

namespace RCD_Project.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the RCD_Connection data model.
    /// </summary>
    public partial class RCD_ConnectionViewModel : DocumentsViewModel<RCD_ConnectionModuleDescription, IRCD_ConnectionUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of RCD_ConnectionViewModel as a POCO view model.
        /// </summary>
        public static RCD_ConnectionViewModel Create() {
            return ViewModelSource.Create(() => new RCD_ConnectionViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the RCD_ConnectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RCD_ConnectionViewModel type without the POCO proxy factory.
        /// </summary>
        protected RCD_ConnectionViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override RCD_ConnectionModuleDescription[] CreateModules() {
			return new RCD_ConnectionModuleDescription[] {
                new RCD_ConnectionModuleDescription( "Clients", "ClientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Clients)),
                new RCD_ConnectionModuleDescription( "Contrats", "ContratCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Contrats)),
                new RCD_ConnectionModuleDescription( "Employes", "EmployeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employes)),
                new RCD_ConnectionModuleDescription( "Reservations", "ReservationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Reservations)),
                new RCD_ConnectionModuleDescription( "Utilisateurs", "UtilisateurCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Utilisateurs)),
                new RCD_ConnectionModuleDescription( "Vehicules", "VehiculeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Vehicules)),
			};
        }
                		protected override void OnActiveModuleChanged(RCD_ConnectionModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class RCD_ConnectionModuleDescription : ModuleDescription<RCD_ConnectionModuleDescription> {
        public RCD_ConnectionModuleDescription(string title, string documentType, string group, Func<RCD_ConnectionModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}