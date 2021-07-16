using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using Car_Express_Solution.Car_Express_EntitiesDataModel;
using Car_Express_Solution.Common;
using Car_Express_Solution;

namespace Car_Express_Solution.ViewModels {

    /// <summary>
    /// Represents the utilisateurs collection view model.
    /// </summary>
    public partial class utilisateurCollectionViewModel : CollectionViewModel<utilisateur, string, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of utilisateurCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static utilisateurCollectionViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new utilisateurCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the utilisateurCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the utilisateurCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected utilisateurCollectionViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.utilisateurs) {
        }
    }
}