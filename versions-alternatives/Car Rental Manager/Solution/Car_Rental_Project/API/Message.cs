using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Car_Rental_Project.API
{
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
            GUI.Bug exceptionGUI = new GUI.Bug();
            exceptionGUI.ShowDialog();
        }

        /// <summary>
        /// Affiche un message d'exception.
        /// </summary>
        /// <param name="detailsText">Texte des détails de l'exception</param>
        public static void Exception(string detailsText)
        {
            GUI.Bug exceptionGUI = new GUI.Bug(detailsText);
            exceptionGUI.ShowDialog();
        }

        /// <summary>
        /// Affiche un message d'exception.
        /// </summary>
        /// <param name="messageText">Texte du message</param>
        /// <param name="captionText">Texte de l'entête (Titre du message)</param>
        /// <param name="detailsText">Texte des détails de l'exception</param>
        public static void Exception(string messageText, string captionText, string detailsText)
        {
            GUI.Bug exceptionGUI = new GUI.Bug(messageText, captionText, detailsText);
            exceptionGUI.ShowDialog();
        }
    }
}
