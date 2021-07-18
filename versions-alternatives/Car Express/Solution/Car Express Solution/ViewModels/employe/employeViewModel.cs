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
    /// Represents the single employe object view model.
    /// </summary>
    public partial class employeViewModel : SingleObjectViewModel<employe, int, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of employeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static employeViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new employeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the employeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the employeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected employeViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.employes, x => x.nom_employe) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of contrats for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<contrat> LookUpcontrats {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (employeViewModel x) => x.LookUpcontrats,
                    getRepositoryFunc: x => x.contrats);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of reservations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<reservation> LookUpreservations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (employeViewModel x) => x.LookUpreservations,
                    getRepositoryFunc: x => x.reservations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of utilisateurs for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<utilisateur> LookUputilisateurs {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (employeViewModel x) => x.LookUputilisateurs,
                    getRepositoryFunc: x => x.utilisateurs);
            }
        }


        /// <summary>
        /// The view model for the employecontrats detail collection.
        /// </summary>
        public CollectionViewModelBase<contrat, contrat, int, ICar_Express_EntitiesUnitOfWork> employecontratsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (employeViewModel x) => x.employecontratsDetails,
                    getRepositoryFunc: x => x.contrats,
                    foreignKeyExpression: x => x.id_employe_conducteur_fk,
                    navigationExpression: x => x.employe);
            }
        }

        /// <summary>
        /// The view model for the employereservations detail collection.
        /// </summary>
        public CollectionViewModelBase<reservation, reservation, int, ICar_Express_EntitiesUnitOfWork> employereservationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (employeViewModel x) => x.employereservationsDetails,
                    getRepositoryFunc: x => x.reservations,
                    foreignKeyExpression: x => x.id_employe_conducteur_fk,
                    navigationExpression: x => x.employe);
            }
        }

        /// <summary>
        /// The view model for the employeutilisateurs detail collection.
        /// </summary>
        public CollectionViewModelBase<utilisateur, utilisateur, string, ICar_Express_EntitiesUnitOfWork> employeutilisateursDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (employeViewModel x) => x.employeutilisateursDetails,
                    getRepositoryFunc: x => x.utilisateurs,
                    foreignKeyExpression: x => x.id_employe_fk,
                    navigationExpression: x => x.employe);
            }
        }
    }
}
