using Car_Express_Solution;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Express_Solution.Car_Express_EntitiesDataModel {

    /// <summary>
    /// ICar_Express_EntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface ICar_Express_EntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The client entities repository.
        /// </summary>
		IRepository<client, int> clients { get; }
        
        /// <summary>
        /// The contrat entities repository.
        /// </summary>
		IRepository<contrat, int> contrats { get; }
        
        /// <summary>
        /// The employe entities repository.
        /// </summary>
		IRepository<employe, int> employes { get; }
        
        /// <summary>
        /// The reservation entities repository.
        /// </summary>
		IRepository<reservation, int> reservations { get; }
        
        /// <summary>
        /// The utilisateur entities repository.
        /// </summary>
		IRepository<utilisateur, string> utilisateurs { get; }
        
        /// <summary>
        /// The vehicule entities repository.
        /// </summary>
		IRepository<vehicule, string> vehicules { get; }
    }
}
