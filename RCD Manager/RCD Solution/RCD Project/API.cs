using DevExpress.XtraEditors;
using RCD_Project.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace API
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
        public static int DureeExploitationVehicule = Settings.Default.DureeExploitationVehicule;
        public static void SetDureeExploitationVehicule(int nouvelleDureeExploitationVehicule)
        {
            DureeExploitationVehicule = Settings.Default.DureeExploitationVehicule = nouvelleDureeExploitationVehicule;
            Settings.Default.Save();
        }

        /// <summary>
        /// Nombre minimum de kilomètres devant être parcourues par un véhicule pour exiger un remplacement de son huile moteur.
        /// </summary>
        public static double DistanceMinimumVidangeVehicule = Settings.Default.DistanceMinimumVidangeVehicule;
        public static void SetDistanceMinimumVidangeVehicule(double nouvelleDistanceMinimumVidangeVehicule)
        {
            DistanceMinimumVidangeVehicule = Settings.Default.DistanceMinimumVidangeVehicule = nouvelleDistanceMinimumVidangeVehicule;
            Settings.Default.Save();
        }

        /// <summary>
        /// Intervalle de temps entre la date d'achat d'un véhicule et la date prévue pour son première maintenance.
        /// </summary>
        public static TimeSpan IntervalleMaintenanceVehicule = Settings.Default.IntervalleMaintenanceVehicule;
        public static void SetIntervalleMaintenanceVehicule(TimeSpan nouvelleIntervalleMaintenanceVehicule)
        {
            IntervalleMaintenanceVehicule = Settings.Default.IntervalleMaintenanceVehicule = nouvelleIntervalleMaintenanceVehicule;
            Settings.Default.Save();
        }

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

    /// <summary>
    /// Gère le système de notifications
    /// </summary>
    public static class Notification
    {
        public static Dictionary<DataRow, string> ListeNotifications = new Dictionary<DataRow, string>();

        public static bool NotificationsActives = Settings.Default.NotificationsActives;
        public static void SetNotificationsActives(bool notificationsActives)
        {
            NotificationsActives = Settings.Default.NotificationsActives = notificationsActives;
            Settings.Default.Save();
        }

        /// <summary>
        /// Intervalle en secondes entre deux notifications.
        /// </summary>
        public static int FrequenceNotifications = Settings.Default.FrequenceNotifications;
        public static void SetFrequenceNotifications(int nouvelleFrequenceNotifications)
        {
            FrequenceNotifications = Settings.Default.FrequenceNotifications = nouvelleFrequenceNotifications;
            Settings.Default.Save();
        }

        public static bool EffetSonoreNotificationsActif = Settings.Default.EffetSonoreNotificationsActif;
        public static void SetEffetSonoreNotificationsActif(bool effetSonoreNotificationsActif)
        {
            EffetSonoreNotificationsActif = Settings.Default.EffetSonoreNotificationsActif = effetSonoreNotificationsActif;
            Settings.Default.Save();
        }
    }
    public static class User
    {
        /// <summary>
        /// Nom de l'utilisateur connecté
        /// </summary>
        public static string Name = "guest";
        /// <summary>
        /// Mot de passe de l'utilisateur connecté 
        /// </summary>
        public static string Password = "guest";
        /// <summary>
        /// Rôle de l'utilisateur connecté
        /// </summary>
        public static string Role = "Utilisateur";
        /// <summary>
        /// ID de l'agence de l'utilisateur connecté
        /// </summary>
        public static string AgenceID;
        /// <summary>
        /// Date de la dernière connexion de l'utilisateur connecté
        /// </summary>
        public static DateTime LastLoginDate = DateTime.Now;
    }

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

    /// <summary>
    /// Affiche des boîte de messages avec moins de paramètres et avec des configurations spécifiques.
    /// </summary>
    public static class Message
    {
        /// <summary>
        /// Affiche un message avec une question dont la réponse est Oui (Yes) ou Non (No).
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        /// <returns>True si la réponse est Oui (Yes)</returns>
        public static bool YesNoQuestion(string messageText, string captionText)
        {
            DialogResult dialogResult = XtraMessageBox.Show(messageText, captionText, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) return true;
            return false;
        }

        /// <summary>
        /// Affiche un message avec une question dont la réponse est Oui (Yes), Non (No), ou Annuler (Cancel).
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        /// <returns>1 si la réponse est Oui, 0 si la réponse est Non, et -1 si la réponse est Annuler</returns>
        public static int YesNoCancelQuestion(string messageText, string captionText)
        {
            DialogResult dialogResult = XtraMessageBox.Show(messageText, captionText, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) return 1;
            else if (dialogResult == DialogResult.No) return 0;
            return -1;
        }

        /// <summary>
        /// Affiche un message d'information.
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        public static void Information(string messageText, string captionText)
        {
            XtraMessageBox.Show(messageText, captionText, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Affiche un message d'exclamation.
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        public static void Exclamation(string messageText, string captionText)
        {
            XtraMessageBox.Show(messageText, captionText, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Affiche un message d'erreur.
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        public static void Error(string messageText, string captionText)
        {
            XtraMessageBox.Show(messageText, captionText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Affiche un message d'exception.
        /// </summary>
        public static void Exception()
        {
            //Form_Bug exceptionGUI = new Form_Bug();
            //exceptionGUI.ShowDialog();
        }

        /// <summary>
        /// Affiche un message d'exception.
        /// </summary>
        /// <param name="detailsText">Texte des détails de l'exception</param>
        public static void Exception(string detailsText)
        {
            //Form_Bug exceptionGUI = new Form_Bug(detailsText);
            //exceptionGUI.ShowDialog();
        }

        /// <summary>
        /// Affiche un message d'exception.
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        /// <param name="detailsText">Texte des détails de l'exception</param>
        public static void Exception(string messageText, string captionText, string detailsText)
        {
            //Form_Bug exceptionGUI = new Form_Bug(messageText, captionText, detailsText);
            //exceptionGUI.ShowDialog();
        }
    }
}
