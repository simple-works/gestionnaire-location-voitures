//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Express_Solution
{
    using System;
    using System.Collections.Generic;
    
    public partial class client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client()
        {
            this.contrats = new HashSet<contrat>();
            this.contrats1 = new HashSet<contrat>();
            this.reservations = new HashSet<reservation>();
            this.reservations1 = new HashSet<reservation>();
        }
    
        public int id_client_pk { get; set; }
        public byte[] photo_client { get; set; }
        public string nom_client { get; set; }
        public string prenom_client { get; set; }
        public string nationalite_client { get; set; }
        public Nullable<System.DateTime> date_naissance_client { get; set; }
        public string lieu_naissance_client { get; set; }
        public string adresse_domicile_client { get; set; }
        public string ville_domicile_client { get; set; }
        public string code_postal_domicile_client { get; set; }
        public string adresse_residence_client { get; set; }
        public string ville_residence_client { get; set; }
        public string code_postal_residence_client { get; set; }
        public string telephone_portable_client { get; set; }
        public string telephone_fixe_client { get; set; }
        public string fax_client { get; set; }
        public string email_client { get; set; }
        public string type_client { get; set; }
        public string id_national_client { get; set; }
        public string type_id_national_client { get; set; }
        public System.DateTime date_heure_delivraison_id_national_client { get; set; }
        public string lieu_delivraison_id_national_client { get; set; }
        public string id_permis_conduire_client { get; set; }
        public System.DateTime date_heure_delivraison_permis_client { get; set; }
        public string lieu_delivraison_permis_Client { get; set; }
        public System.DateTime C_row_insert_datetime { get; set; }
        public Nullable<System.DateTime> C_row_update_datetime { get; set; }
        public Nullable<System.DateTime> C_row_delete_datetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations1 { get; set; }
    }
}
