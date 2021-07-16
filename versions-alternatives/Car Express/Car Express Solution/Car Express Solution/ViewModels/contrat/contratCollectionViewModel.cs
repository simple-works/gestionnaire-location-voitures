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
    /// Represents the contrats collection view model.
    /// </summary>
    public partial class contratCollectionViewModel : CollectionViewModel<contrat, int, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of contratCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static contratCollectionViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new contratCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the contratCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the contratCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected contratCollectionViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.contrats) {
        }
    }
}