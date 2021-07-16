using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using RCD_Project.RCD_ConnectionDataModel;
using RCD_Project.Common;
using RCD_Project;

namespace RCD_Project.ViewModels {

    /// <summary>
    /// Represents the Utilisateurs collection view model.
    /// </summary>
    public partial class UtilisateurCollectionViewModel : CollectionViewModel<Utilisateur, string, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UtilisateurCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UtilisateurCollectionViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UtilisateurCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UtilisateurCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UtilisateurCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UtilisateurCollectionViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Utilisateurs) {
        }
    }
}