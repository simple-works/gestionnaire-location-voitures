using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using RCD_Project;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RCD_Project.RCD_ConnectionDataModel {

    /// <summary>
    /// A RCD_ConnectionUnitOfWork instance that represents the run-time implementation of the IRCD_ConnectionUnitOfWork interface.
    /// </summary>
    public class RCD_ConnectionUnitOfWork : DbUnitOfWork<RCD_Connection>, IRCD_ConnectionUnitOfWork {

        public RCD_ConnectionUnitOfWork(Func<RCD_Connection> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Client, int> IRCD_ConnectionUnitOfWork.Clients {
            get { return GetRepository(x => x.Set<Client>(), (Client x) => x.id_client_pk); }
        }

        IRepository<Contrat, int> IRCD_ConnectionUnitOfWork.Contrats {
            get { return GetRepository(x => x.Set<Contrat>(), (Contrat x) => x.id_contrat_pk); }
        }

        IRepository<Employe, int> IRCD_ConnectionUnitOfWork.Employes {
            get { return GetRepository(x => x.Set<Employe>(), (Employe x) => x.id_employe_pk); }
        }

        IRepository<Reservation, int> IRCD_ConnectionUnitOfWork.Reservations {
            get { return GetRepository(x => x.Set<Reservation>(), (Reservation x) => x.id_reservation_pk); }
        }

        IRepository<Utilisateur, string> IRCD_ConnectionUnitOfWork.Utilisateurs {
            get { return GetRepository(x => x.Set<Utilisateur>(), (Utilisateur x) => x.nom_utilisateur_pk); }
        }

        IRepository<Vehicule, string> IRCD_ConnectionUnitOfWork.Vehicules {
            get { return GetRepository(x => x.Set<Vehicule>(), (Vehicule x) => x.immatriculation_vehicule_pk); }
        }
    }
}
