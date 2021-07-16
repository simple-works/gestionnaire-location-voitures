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
    /// Represents the single Utilisateur object view model.
    /// </summary>
    public partial class UtilisateurViewModel : SingleObjectViewModel<Utilisateur, string, IRCD_ConnectionUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UtilisateurViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UtilisateurViewModel Create(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UtilisateurViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UtilisateurViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UtilisateurViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UtilisateurViewModel(IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Utilisateurs, x => x.nom_utilisateur_pk) {
                }



    }
}
