using System;
using System.Data;
using System.Drawing;

namespace Car_Rental_Project.API
{
    /// <summary>
    /// Fournit les propriétés et méthodes permettant de manipuler l'utilisateur 
    /// actif de l'application pendant la session de connexion.
    /// </summary>
    public static class User
    {
        private static DAI.DataManagement gestionUtilisateurs = new DAI.DataManagement(DAI.DataDescription.Tables.Utilisateur);
        private static DAI.DataManagement gestionEmployes = new DAI.DataManagement(DAI.DataDescription.Tables.Employe);

        /// <summary>
        /// Nom de l'utilisateur connecté.
        /// </summary>
        public static string Name;
        /// <summary>
        /// Mot de passe de l'utilisateur connecté.
        /// </summary>
        public static string Password;
        /// <summary>
        /// Rôle de l'utilisateur connecté.
        /// </summary>
        public static string Role;
        /// <summary>
        /// Photo de l'employé possédant l'utilisateur connecté.
        /// </summary>
        public static Image Photo;
        /// <summary>
        /// ID de l'employé possédant l'utilisateur connecté.
        /// </summary>
        public static int EmployeeID = -1;
        /// <summary>
        /// ID de l'agence de l'utilisateur connecté.
        /// </summary>
        public static int AgenceID = -1;
        /// <summary>
        /// Date de la dernière connexion de l'utilisateur connecté.
        /// </summary>
        public static DateTime LastLoginDate = new DateTime();

        /// <summary>
        /// Obtient la ligne de données d'un utilisateur.
        /// </summary>
        /// <param name="userName">Nom d'utilisateur</param>
        /// <returns></returns>
        public static DataRow GetUser(string userName)
        {
            return gestionUtilisateurs.Table.Rows.Find(userName);
        }

        /// <summary>
        /// Obtient la ligne de données de l'employé référencé par un utilisateur.
        /// </summary>
        /// <param name="userName">Nom d'utilisateur</param>
        /// <returns></returns>
        public static DataRow GetUserEmployee(string userName)
        {
            DataRow user = GetUser(userName);
            if (user != null)
            {
                string userEmployeID = user["id_employe_fk"].ToString();
                return gestionEmployes.Table.Rows.Find(userEmployeID);
            }
            return null;           
        }

        /// <summary>
        /// Vérifie pour un utilisateur que le mot de passe entré en paramètre 
        /// est correcte (identique au mot de passe existant)
        /// </summary>
        /// <param name="userName">Nom d'utilisateur</param>
        /// <param name="password">Mot de passe entré à vérifier</param>
        /// <returns>True si la combinaison userName-password existe</returns>
        public static bool CheckUserPassword(string userName, string password)
        {
            DataRow user = GetUser(userName);
            if (user != null)
                return (user["mot_passe_utilisateur"].ToString() == password);
            return false;
        }

        /// <summary>
        /// Identifie un utilisateur en vérifiant son nom et mot de passe
        /// et mémorise les informations relatives à sa session de connexion.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>True si l'utilisateur est bien identifié</returns>
        public static bool LogOn(string userName, string password)
        {
            if (CheckUserPassword(userName, password))
            {
                DataRow user = GetUser(userName);
                DataRow userEmployee = GetUserEmployee(userName);
                if (user != null && userEmployee != null)
                {
                    User.Name = user["nom_utilisateur_pk"].ToString();
                    User.Password = user["mot_passe_utilisateur"].ToString();
                    User.Role = user["role_utilisateur"].ToString();
                    object lastLoginDate = user["date_heure_derniere_connexion_utilisatur"];
                    if (lastLoginDate != null && lastLoginDate != DBNull.Value)
                        User.LastLoginDate = Convert.ToDateTime(lastLoginDate);

                    User.EmployeeID = Convert.ToInt32(userEmployee["id_employe_pk"]);
                    User.AgenceID = Convert.ToInt32(userEmployee["id_agence_fk"]);
                    byte[] byte_image = (byte[])userEmployee["photo_employe"];
                    System.IO.MemoryStream memory_stream = new System.IO.MemoryStream(byte_image);
                    User.Photo = Image.FromStream(memory_stream);

                    gestionUtilisateurs.Table.Rows.Find(User.Name)["date_heure_derniere_connexion_utilisatur"] = DateTime.Now;

                    Program.MainForm.ActivateGUI();

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Déconnecte l'utilisateur actif et mis fin à la session de connexion.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>True si l'utilisateur est bien identifié</returns>
        public static void LogOff()
        {
            User.Name = null;
            User.Password = null;
            User.Role = null;
            User.LastLoginDate = new DateTime();
            User.EmployeeID = -1;
            User.AgenceID = -1;
            User.Photo = null;

            foreach (DevExpress.XtraEditors.XtraForm form in Program.MainForm.MdiChildren)
            {
                form.Close();
            }

            Program.MainForm.DeactivateGUI();
        }
    }
}
