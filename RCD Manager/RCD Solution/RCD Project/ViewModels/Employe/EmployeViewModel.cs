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
    /// Represents the single Employe object view model.
    /// </summary>
    public partial class EmployeViewModel : SingleObjectViewModel<Employe, int, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employes, x => x.nom_employe) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Contrat> LookUpContrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeViewModel x) => x.LookUpContrats,
                    getRepositoryFunc: x => x.Contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Reservation> LookUpReservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EmployeViewModel x) => x.LookUpReservations,
                    getRepositoryFunc: x => x.Reservations);
            }
        }


        /// <summary>
        /// The view model for the EmployeContrats detail collection.
        /// </summary>
        public CollectionViewModelBase<Contrat, Contrat, int, IRCD_ConnectionUnitOfWork> EmployeContratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeViewModel x) => x.EmployeContratsDetails,
                    getRepositoryFunc: x => x.Contrats,
                    foreignKeyExpression: x => x.id_employe_conducteur_fk,
                    navigationExpression: x => x.Employe);
            }
        }

        /// <summary>
        /// The view model for the EmployeReservations detail collection.
        /// </summary>
        public CollectionViewModelBase<Reservation, Reservation, int, IRCD_ConnectionUnitOfWork> EmployeReservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EmployeViewModel x) => x.EmployeReservationsDetails,
                    getRepositoryFunc: x => x.Reservations,
                    foreignKeyExpression: x => x.id_employe_conducteur_fk,
                    navigationExpression: x => x.Employe);
            }
        }
    }
}
