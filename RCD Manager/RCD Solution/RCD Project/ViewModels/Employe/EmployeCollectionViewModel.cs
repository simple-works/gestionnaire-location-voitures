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
    /// Represents the Employes collection view model.
    /// </summary>
    public partial class EmployeCollectionViewModel : CollectionViewModel<Employe, int, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeCollectionViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeCollectionViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employes) {
        }
    }
}