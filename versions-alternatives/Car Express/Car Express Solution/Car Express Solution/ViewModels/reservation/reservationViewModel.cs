using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Car_Express_Solution.Car_Express_EntitiesDataModel;
using Car_Express_Solution.Common;
using Car_Express_Solution;

namespace Car_Express_Solution.ViewModels {

    /// <summary>
    /// Represents the single reservation object view model.
    /// </summary>
    public partial class reservationViewModel : SingleObjectViewModel<reservation, int, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of reservationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static reservationViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new reservationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the reservationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the reservationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected reservationViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.reservations, x => x.description_equipements_speciaux_reservation) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of clients for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<client> LookUpclients {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (reservationViewModel x) => x.LookUpclients,
                    getRepositoryFunc: x => x.clients);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of employes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<employe> LookUpemployes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (reservationViewModel x) => x.LookUpemployes,
                    getRepositoryFunc: x => x.employes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of vehicules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<vehicule> LookUpvehicules {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (reservationViewModel x) => x.LookUpvehicules,
                    getRepositoryFunc: x => x.vehicules);
            }
        }

    }
}
