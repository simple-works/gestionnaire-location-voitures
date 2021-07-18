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
    /// Represents the single utilisateur object view model.
    /// </summary>
    public partial class utilisateurViewModel : SingleObjectViewModel<utilisateur, string, ICar_Express_EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of utilisateurViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static utilisateurViewModel Create(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new utilisateurViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the utilisateurViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the utilisateurViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected utilisateurViewModel(IUnitOfWorkFactory<ICar_Express_EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.utilisateurs, x => x.nom_utilisateur_pk) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of employes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<employe> LookUpemployes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (utilisateurViewModel x) => x.LookUpemployes,
                    getRepositoryFunc: x => x.employes);
            }
        }

    }
}
