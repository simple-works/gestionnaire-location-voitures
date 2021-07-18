using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using Car_Express_Solution.Car_Express_EntitiesDataModel;

namespace Car_Express_Solution.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the Car_Express_Entities data model.
    /// </summary>
    public partial class Car_Express_EntitiesViewModel : DocumentsViewModel<Car_Express_EntitiesModuleDescription, ICar_Express_EntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of Car_Express_EntitiesViewModel as a POCO view model.
        /// </summary>
        public static Car_Express_EntitiesViewModel Create() {
            return ViewModelSource.Create(() => new Car_Express_EntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the Car_Express_EntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Car_Express_EntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected Car_Express_EntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override Car_Express_EntitiesModuleDescription[] CreateModules() {
			return new Car_Express_EntitiesModuleDescription[] {
                new Car_Express_EntitiesModuleDescription( "clients", "clientCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.clients)),
                new Car_Express_EntitiesModuleDescription( "contrats", "contratCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.contrats)),
                new Car_Express_EntitiesModuleDescription( "employes", "employeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.employes)),
                new Car_Express_EntitiesModuleDescription( "reservations", "reservationCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.reservations)),
                new Car_Express_EntitiesModuleDescription( "utilisateurs", "utilisateurCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.utilisateurs)),
                new Car_Express_EntitiesModuleDescription( "vehicules", "vehiculeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.vehicules)),
			};
        }
                		protected override void OnActiveModuleChanged(Car_Express_EntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class Car_Express_EntitiesModuleDescription : ModuleDescription<Car_Express_EntitiesModuleDescription> {
        public Car_Express_EntitiesModuleDescription(string title, string documentType, string group, Func<Car_Express_EntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}