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
    /// Represents the employes collection view model.
    /// </summary>
    public partial class employeCollectionViewModel : CollectionViewModel<employe, int, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of employeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static employeCollectionViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new employeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the employeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the employeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected employeCollectionViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.employes) {
        }
    }
}