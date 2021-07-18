using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace Car_Rental_Project.GUI.Compte
{
    public partial class Connexion : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionUtilisateurs = new DAI.DataManagement(DAI.DataDescription.Tables.Utilisateur);
        private bool usernameError;
        public Connexion()
        {
            try
            {
                InitializeComponent();
                API.Controller.EnableAutoComplete(edit_nom_utilisateur, gestionUtilisateurs.Table, AutoCompleteMode.SuggestAppend);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            try
            {
                SelectPage(page_username);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        /// <summary>
        /// Affiche ou cache l'interface d'indicateur de chargement.
        /// </summary>
        /// <param name="show">True pour afficher</param>
        private void ShowLoading(bool show)
        {
            if (show)
                SplashScreenManager.ShowForm(API.Controller.LoginWaitFormType);
            else
                SplashScreenManager.CloseForm();
        }

        /// <summary>
        /// Affiche une des pages du NavigationFrame.
        /// </summary>
        /// <param name="page">Page à afficher</param>
        private void SelectPage(DevExpress.XtraBars.Navigation.INavigationPage page)
        {
            AcceptButton =  null;
            CancelButton = null;
            navigationFrame1.SelectedPage = page;
            if (page.Equals(page_username))
            {
                AcceptButton = button_suivant;
                CancelButton = null;
                edit_nom_utilisateur.Focus();
            }
            else if (page.Equals(page_password))
            {
                AcceptButton = button_connexion;
                CancelButton = button_precedent;
                edit_mot_passe.Focus();
            }
            else if (page.Equals(page_error))
            {
                AcceptButton = button_reessayer;
                CancelButton = null;
            }
        }

        private void button_suivant_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoading(true);
                string userName = edit_nom_utilisateur.Text.Trim();
                DataRow user = API.User.GetUser(userName);
                if (user == null)
                {
                    usernameError = true;
                    SelectPage(page_error);
                }
                else
                {
                    DataRow userEmployee = API.User.GetUserEmployee(userName);
                    if (userEmployee == null)
                    {
                        usernameError = true;
                        SelectPage(page_error);
                    }
                    else
                    {
                        lab_nom_utilisateur_identifie.Text = user["nom_utilisateur_pk"].ToString();
                        lab_nom_employe_utilisateur_identifie.Text = userEmployee["nom_employe"].ToString()
                            + " " + userEmployee["prenom_employe"].ToString();
                        photo_utilisateur_identifie.EditValue = userEmployee["photo_employe"];
                        SelectPage(page_password);
                    }             
                }
                ShowLoading(false);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoading(true);
                string userName = edit_nom_utilisateur.Text.Trim();
                string password = edit_mot_passe.Text;
                if (!API.User.CheckUserPassword(userName, password))
                {
                    usernameError = false;
                    SelectPage(page_error);
                }
                else if (API.User.LogOn(userName, password))
                {
                    Close();
                }
                ShowLoading(false);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_precedent_Click(object sender, EventArgs e)
        {
            try
            {
                SelectPage(page_username);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }            
        }

        private void button_reessayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameError)
                    SelectPage(page_username);
                else
                    SelectPage(page_password);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
    }
}