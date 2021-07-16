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
    /// Represents the single Contrat object view model.
    /// </summary>
    public partial class ContratViewModel : SingleObjectViewModel<Contrat, int, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ContratViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ContratViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ContratViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ContratViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ContratViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ContratViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Contrats, x => x.description_equipements_speciaux_contrat) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Clients for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Client> LookUpClients {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContratViewModel x) => x.LookUpClients,
                    getRepositoryFunc: x => x.Clients);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Employes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employe> LookUpEmployes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContratViewModel x) => x.LookUpEmployes,
                    getRepositoryFunc: x => x.Employes);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Vehicules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Vehicule> LookUpVehicules {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ContratViewModel x) => x.LookUpVehicules,
                    getRepositoryFunc: x => x.Vehicules);
            }
        }

    }
}
