using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RCD_Project.RCD_ConnectionDataModel;
using RCD_Project.Common;
using RCD_Project;

namespace RCD_Project.ViewModels {

    /// <summary>
    /// Represents the single Vehicule object view model.
    /// </summary>
    public partial class VehiculeViewModel : SingleObjectViewModel<Vehicule, string, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VehiculeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VehiculeViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VehiculeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VehiculeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VehiculeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VehiculeViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Vehicules, x => x.description_vehicule) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contrat> LookUpContrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehiculeViewModel x) => x.LookUpContrats,
                    getRepositoryFunc: x => x.Contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Reservation> LookUpReservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (VehiculeViewModel x) => x.LookUpReservations,
                    getRepositoryFunc: x => x.Reservations);
            }
        }


        /// <summary>
        /// The view model for the VehiculeContrats detail collection.
        /// </summary>
        public CollectionViewModelBase<Contrat, Contrat, int, IRCD_ConnectionUnitOfWork> VehiculeContratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehiculeViewModel x) => x.VehiculeContratsDetails,
                    getRepositoryFunc: x => x.Contrats,
                    foreignKeyExpression: x => x.immatriculation_vehicule_fk,
                    navigationExpression: x => x.Vehicule);
            }
        }

        /// <summary>
        /// The view model for the VehiculeReservations detail collection.
        /// </summary>
        public CollectionViewModelBase<Reservation, Reservation, int, IRCD_ConnectionUnitOfWork> VehiculeReservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (VehiculeViewModel x) => x.VehiculeReservationsDetails,
                    getRepositoryFunc: x => x.Reservations,
                    foreignKeyExpression: x => x.immatriculation_vehicule_fk,
                    navigationExpression: x => x.Vehicule);
            }
        }
    }
}
