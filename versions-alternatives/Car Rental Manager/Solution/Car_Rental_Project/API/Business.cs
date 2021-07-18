using System;
using Car_Rental_Project.Properties;

namespace Car_Rental_Project.API
{
    /// <summary>
    /// Représente l'ensemble des attributs et méthodes relatives au domaine principal de l'application.
    /// <para>Système d'une société de location de véhicules</para>
    /// </summary>
    public static class Business
    {
        /// <summary>
        /// Nombre maximum d'années pendant lesquelles un véhicule est exploité avant d'être revendu.
        /// </summary>
        public static readonly int DureeExploitationVehicule = Settings.Default.DureeExploitationVehicule;
        /// <summary>
        /// Nombre minimum de kilomètres devant être parcourues par un véhicule pour exiger un remplacement de son huile moteur.
        /// </summary>
        public static readonly double DistanceMinimumVidangeVehicule = Settings.Default.DistanceMinimumVidangeVehicule;
        /// <summary>
        /// Intervalle de temps entre la date d'achat d'un véhicule et la date prévue pour son première maintenance.
        /// </summary>
        public static readonly TimeSpan IntervalleMaintenanceVehicule = Settings.Default.IntervalleMaintenanceVehicule;
        /// <summary>
        /// Unité de mesure d'intervalles de temps.
        /// </summary>
        public enum TimeUnit { Years, Months, Weeks, Days, Hours, Minutes, Seconds }

        /// <summary>
        /// Calcule le temps restant pour arriver à une future date.
        /// </summary>
        /// <param name="futureDate">Date futur ciblée</param>
        /// <param name="timeUnit">Unité de mesure du temps restant</param>
        /// <returns>Nombre d'unités de temps restantes, le nombre est négétif si la date entré est dépassée</returns>
        public static int RemainingTimeToDate(DateTime futureDate, TimeUnit timeUnit)
        {
            int remainingTimeUnits = -1;
            TimeSpan remainingTimeSpan = futureDate - DateTime.Now;
            if (futureDate >= DateTime.Now)
            {
                switch (timeUnit)
                {
                    case TimeUnit.Years:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalDays / 365.25);
                        break;
                    case TimeUnit.Months:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalDays / 30);
                        break;
                    case TimeUnit.Weeks:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalDays / 7);
                        break;
                    case TimeUnit.Days:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalDays);
                        break;
                    case TimeUnit.Hours:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalHours);
                        break;
                    case TimeUnit.Minutes:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalMinutes);
                        break;
                    case TimeUnit.Seconds:
                        remainingTimeUnits = (int)Math.Round(remainingTimeSpan.TotalSeconds);
                        break;
                    default:
                        break;
                }
            }
            return remainingTimeUnits;
        }

        /// <summary>
        /// Indique si un véhicule requis le remplacement de son huile moteur ou non.
        /// </summary>
        /// <param name="distanceParcourueVehicule">Nombre actuel de kilomètres parcourues par le véhicule</param>
        /// <returns>True si le véhicule exige le vidange</returns>
        public static bool VehiculeExigeVidange(double distanceParcourueVehicule)
        {
            return (distanceParcourueVehicule >= Business.DistanceMinimumVidangeVehicule);
        }

        /// <summary>
        /// Indique la date prévue pour la première maintenance d'un véhicule depuis son achat.
        /// </summary>
        /// <param name="dateAchatVehicule">Date d'achat du véhicule</param>
        /// <returns>Date prévue pour la première maintenance</returns>
        public static DateTime DatePremiereMaintenaceVehicule(DateTime dateAchatVehicule)
        {
            return dateAchatVehicule + Business.IntervalleMaintenanceVehicule;           
        }

        /// <summary>
        /// Indique la date prévue pour la prochaine maintenance d'un véhicule depuis sa toute dernière maintenance.
        /// </summary>
        /// <param name="dateDerniereMaintenanceVehicule">Date de la dernière maintenance du véhicule</param>
        /// <returns>Date prévue pour la prochaine maintenance</returns>
        public static DateTime DateProchaineMaintenaceVehicule(DateTime dateDerniereMaintenanceVehicule)
        {
            return dateDerniereMaintenanceVehicule + TimeSpan.FromTicks(Business.IntervalleMaintenanceVehicule.Ticks / 2);
        }

        /// <summary>
        /// Calcule pour un véhicule la quantité d'énergie affectée (ajoutée ou enlevée) depuis son départ.
        /// <para>• Valeur positive si de l'énergie a été ajouté (Augmentation de la quantité)</para>
        /// <para>• Valeur négative si de l'énergie a été enlevé (Diminuation de la quantité)</para>
        /// <para>• Valeur nulle si l'énergie n'a pas changé (Stablité de la quantité)</para>
        /// </summary>
        /// <param name="quantiteEnergieVehiculeInitial">Quantité d'énergie au départ</param>
        /// <param name="quantiteEnergieVehiculeActuelle">Quantité d'énergie au retour</param>
        /// <returns></returns>
        public static double QuantiteEnergieVehiculeAffectee(double quantiteEnergieVehiculeInitial, double quantiteEnergieVehiculeActuelle)
        {
            return quantiteEnergieVehiculeActuelle - quantiteEnergieVehiculeInitial;
        }

        public static double MontantLocationVehicule(double prixJourLocationVehicule, int nombreJoursLocation)
        {
            return prixJourLocationVehicule * nombreJoursLocation;
        }
    }
}
