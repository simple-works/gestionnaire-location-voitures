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
    /// Represents the single Client object view model.
    /// </summary>
    public partial class ClientViewModel : SingleObjectViewModel<Client, int, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ClientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ClientViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ClientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ClientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ClientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ClientViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Clients, x => x.nom_client) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contrat> LookUpContrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpContrats,
                    getRepositoryFunc: x => x.Contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Reservation> LookUpReservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ClientViewModel x) => x.LookUpReservations,
                    getRepositoryFunc: x => x.Reservations);
            }
        }


        /// <summary>
        /// The view model for the ClientContrats detail collection.
        /// </summary>
        public CollectionViewModelBase<Contrat, Contrat, int, IRCD_ConnectionUnitOfWork> ClientContratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientContratsDetails,
                    getRepositoryFunc: x => x.Contrats,
                    foreignKeyExpression: x => x.id_client_fk,
                    navigationExpression: x => x.Client);
            }
        }

        /// <summary>
        /// The view model for the ClientContrats1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Contrat, Contrat, int, IRCD_ConnectionUnitOfWork> ClientContrats1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientContrats1Details,
                    getRepositoryFunc: x => x.Contrats,
                    foreignKeyExpression: x => x.id_client_compagnon_fk,
                    navigationExpression: x => x.Client1);
            }
        }

        /// <summary>
        /// The view model for the ClientReservations detail collection.
        /// </summary>
        public CollectionViewModelBase<Reservation, Reservation, int, IRCD_ConnectionUnitOfWork> ClientReservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientReservationsDetails,
                    getRepositoryFunc: x => x.Reservations,
                    foreignKeyExpression: x => x.id_client_fk,
                    navigationExpression: x => x.Client);
            }
        }

        /// <summary>
        /// The view model for the ClientReservations1 detail collection.
        /// </summary>
        public CollectionViewModelBase<Reservation, Reservation, int, IRCD_ConnectionUnitOfWork> ClientReservations1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ClientViewModel x) => x.ClientReservations1Details,
                    getRepositoryFunc: x => x.Reservations,
                    foreignKeyExpression: x => x.id_client_compagnon_fk,
                    navigationExpression: x => x.Client1);
            }
        }
    }
}
