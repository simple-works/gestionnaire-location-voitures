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
    /// Represents the single client object view model.
    /// </summary>
    public partial class clientViewModel : SingleObjectViewModel<client, int, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of clientViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static clientViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new clientViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the clientViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the clientViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected clientViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.clients, x => x.nom_client) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<contrat> LookUpcontrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (clientViewModel x) => x.LookUpcontrats,
                    getRepositoryFunc: x => x.contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<reservation> LookUpreservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (clientViewModel x) => x.LookUpreservations,
                    getRepositoryFunc: x => x.reservations);
            }
        }


        /// <summary>
        /// The view model for the clientcontrats detail collection.
        /// </summary>
        public CollectionViewModelBase<contrat, contrat, int, ICar_Express_EntitiesUnitOfWork> clientcontratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (clientViewModel x) => x.clientcontratsDetails,
                    getRepositoryFunc: x => x.contrats,
                    foreignKeyExpression: x => x.id_client_fk,
                    navigationExpression: x => x.client);
            }
        }

        /// <summary>
        /// The view model for the clientcontrats1 detail collection.
        /// </summary>
        public CollectionViewModelBase<contrat, contrat, int, ICar_Express_EntitiesUnitOfWork> clientcontrats1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (clientViewModel x) => x.clientcontrats1Details,
                    getRepositoryFunc: x => x.contrats,
                    foreignKeyExpression: x => x.id_client_compagnon_fk,
                    navigationExpression: x => x.client1);
            }
        }

        /// <summary>
        /// The view model for the clientreservations detail collection.
        /// </summary>
        public CollectionViewModelBase<reservation, reservation, int, ICar_Express_EntitiesUnitOfWork> clientreservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (clientViewModel x) => x.clientreservationsDetails,
                    getRepositoryFunc: x => x.reservations,
                    foreignKeyExpression: x => x.id_client_fk,
                    navigationExpression: x => x.client);
            }
        }

        /// <summary>
        /// The view model for the clientreservations1 detail collection.
        /// </summary>
        public CollectionViewModelBase<reservation, reservation, int, ICar_Express_EntitiesUnitOfWork> clientreservations1Details {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (clientViewModel x) => x.clientreservations1Details,
                    getRepositoryFunc: x => x.reservations,
                    foreignKeyExpression: x => x.id_client_compagnon_fk,
                    navigationExpression: x => x.client1);
            }
        }
    }
}
