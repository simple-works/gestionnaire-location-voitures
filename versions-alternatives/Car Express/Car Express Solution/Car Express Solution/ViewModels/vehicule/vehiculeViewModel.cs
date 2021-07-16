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
    /// Represents the single vehicule object view model.
    /// </summary>
    public partial class vehiculeViewModel : SingleObjectViewModel<vehicule, string, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of vehiculeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static vehiculeViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new vehiculeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the vehiculeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the vehiculeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected vehiculeViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.vehicules, x => x.description_vehicule) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<contrat> LookUpcontrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (vehiculeViewModel x) => x.LookUpcontrats,
                    getRepositoryFunc: x => x.contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<reservation> LookUpreservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (vehiculeViewModel x) => x.LookUpreservations,
                    getRepositoryFunc: x => x.reservations);
            }
        }


        /// <summary>
        /// The view model for the vehiculecontrats detail collection.
        /// </summary>
        public CollectionViewModelBase<contrat, contrat, int, ICar_Express_EntitiesUnitOfWork> vehiculecontratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (vehiculeViewModel x) => x.vehiculecontratsDetails,
                    getRepositoryFunc: x => x.contrats,
                    foreignKeyExpression: x => x.immatriculation_vehicule_fk,
                    navigationExpression: x => x.vehicule);
            }
        }

        /// <summary>
        /// The view model for the vehiculereservations detail collection.
        /// </summary>
        public CollectionViewModelBase<reservation, reservation, int, ICar_Express_EntitiesUnitOfWork> vehiculereservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (vehiculeViewModel x) => x.vehiculereservationsDetails,
                    getRepositoryFunc: x => x.reservations,
                    foreignKeyExpression: x => x.immatriculation_vehicule_fk,
                    navigationExpression: x => x.vehicule);
            }
        }
    }
}
