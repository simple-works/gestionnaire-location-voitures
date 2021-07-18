using Car_Express_Solution;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Express_Solution.Car_Express_EntitiesDataModel {

    /// <summary>
    /// A Car_Express_EntitiesUnitOfWork instance that represents the run-time implementation of the ICar_Express_EntitiesUnitOfWork interface.
    /// </summary>
    public class Car_Express_EntitiesUnitOfWork : DbUnitOfWork<Car_Express_Entities>, ICar_Express_EntitiesUnitOfWork {

        public Car_Express_EntitiesUnitOfWork(Func<Car_Express_Entities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<client, int> ICar_Express_EntitiesUnitOfWork.clients {
            get { return GetRepository(x => x.Set<client>(), (client x) => x.id_client_pk); }
        }

        IRepository<contrat, int> ICar_Express_EntitiesUnitOfWork.contrats {
            get { return GetRepository(x => x.Set<contrat>(), (contrat x) => x.id_contrat_pk); }
        }

        IRepository<employe, int> ICar_Express_EntitiesUnitOfWork.employes {
            get { return GetRepository(x => x.Set<employe>(), (employe x) => x.id_employe_pk); }
        }

        IRepository<reservation, int> ICar_Express_EntitiesUnitOfWork.reservations {
            get { return GetRepository(x => x.Set<reservation>(), (reservation x) => x.id_reservation_pk); }
        }

        IRepository<utilisateur, string> ICar_Express_EntitiesUnitOfWork.utilisateurs {
            get { return GetRepository(x => x.Set<utilisateur>(), (utilisateur x) => x.nom_utilisateur_pk); }
        }

        IRepository<vehicule, string> ICar_Express_EntitiesUnitOfWork.vehicules {
            get { return GetRepository(x => x.Set<vehicule>(), (vehicule x) => x.immatriculation_vehicule_pk); }
        }
    }
}
