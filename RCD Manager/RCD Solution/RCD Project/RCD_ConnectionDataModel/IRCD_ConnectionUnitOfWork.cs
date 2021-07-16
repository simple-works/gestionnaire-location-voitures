using DevExpress.Mvvm.DataModel;
using RCD_Project;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RCD_Project.RCD_ConnectionDataModel {

    /// <summary>
    /// IRCD_ConnectionUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IRCD_ConnectionUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Client entities repository.
        /// </summary>
		IRepository<Client, int> Clients { get; }
        
        /// <summary>
        /// The Contrat entities repository.
        /// </summary>
		IRepository<Contrat, int> Contrats { get; }
        
        /// <summary>
        /// The Employe entities repository.
        /// </summary>
		IRepository<Employe, int> Employes { get; }
        
        /// <summary>
        /// The Reservation entities repository.
        /// </summary>
		IRepository<Reservation, int> Reservations { get; }
        
        /// <summary>
        /// The Utilisateur entities repository.
        /// </summary>
		IRepository<Utilisateur, string> Utilisateurs { get; }
        
        /// <summary>
        /// The Vehicule entities repository.
        /// </summary>
		IRepository<Vehicule, string> Vehicules { get; }
    }
}
