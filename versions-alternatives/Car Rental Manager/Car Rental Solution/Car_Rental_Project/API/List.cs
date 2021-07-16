using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Project.API
{
    public static class List
    {
        /// <summary>
        /// Liste des nationalités des différents pays du monde.
        /// </summary>
        public static readonly string[] NationalitesMonde = {
            "Maroc"
        };
        /// <summary>
        /// Liste des villes du monde.
        /// </summary>
        public static readonly string[] VillesMonde = {
            "Marrakech"
        };
        /// <summary>
        /// Liste des villes du maroc.
        /// </summary>
        public static readonly string[] VillesMaroc = {
            "Marrakech", "Ouarzazate", "Fès"
        };
        /// <summary>
        /// Liste des type des clients de la société.
        /// </summary>
        public static readonly string[] TypesClients = {
            "Particulier",
            "Société"
        };
        /// <summary>
        /// Liste des types des pièces d'identités officielles.
        /// </summary>
        public static readonly string[] TypesIdNational = {
            "CIN",
            "Passeport"
        };
        /// <summary>
        /// Liste des fonctions des employés des agences de la société.
        /// </summary>
        public static readonly string[] FonctionsEmployes = {
            "Employé",
            "Secretaire",
            "Directeur",
            "Conducteur"
        };
        /// <summary>
        /// Liste des rôles (Ensembles de privilièges) disponibles des utilisateurs de l'application.
        /// </summary>
        public static readonly string[] RolesUtilisateurs = {
            "Maître",
            "Administrateur",
            "Utilisateur"
        };
        /// <summary>
        /// Liste des types de véhicules exploités par la société.
        /// </summary>
        public static readonly string[] TypesVehicules = {
            "Voiture",
            "Moto",
            "Camionnette"
        };
        /// <summary>
        /// Liste des marques des vehicules commercialisés.
        /// </summary>
        public static readonly string[] MarquesVehicules = {
            "Mercedes",
            "Mercedes-Benz",
            "Ford",
            "Toyota"
        };
        /// <summary>
        /// Liste des types d'énergies (carburants) utilisable par les moteurs des véhicules commercialisés.
        /// </summary>
        public static readonly string[] TypesEnergiesVehicules = {
            "Essence",
            "GPL",
            "Fioul",
            "Gazole"
        };
        /// <summary>
        /// Liste des équipements pouvant être fournis avec le véhicule en tant que services additionnels au service principal.
        /// </summary>
        public static readonly string[] EquipementsSpeciauxVehicule = {
            "Sièges enfant",
            "Wi-Fi",
            "GPS",
            "Carburant"
        };
        public static readonly string[] ModesPaiement = {
            "Espèces",
            "Chèque",
            "Carte"
        };
    }
}
