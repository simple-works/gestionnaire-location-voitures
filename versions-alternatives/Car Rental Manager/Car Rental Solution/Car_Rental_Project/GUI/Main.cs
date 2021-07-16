using System;
using DevExpress.XtraBars;
using Car_Rental_Project.GUI.Compte;
using Car_Rental_Project.GUI.Gestion;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Navigation;

namespace Car_Rental_Project.GUI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Formulaires de gestion 
        public Contrats_Collection Contrats_Collection_Instance;
        public Contrats_Detail Contrats_Detail_Instance;
        public Reservations_Collection Reservations_Collection_Instance;
        public Reservations_Detail Reservations_Detail_Instance;
        public Utilisateurs_Collection Utilisateurs_Collection_Instance;
        public Utilisateurs_Detail Utilisateurs_Detail_Instance;
        public Clients_Collection Clients_Collection_Instance;
        public Clients_Detail Clients_Detail_Instance;
        public Employes_Collection Employes_Collection_Instance;
        public Employes_Detail Employes_Detail_Instance;
        public Vehicules_Collection Vehicules_Collection_Instance;
        public Vehicules_Detail Vehicules_Detail_Instance;
        public Agences_Collection Agences_Collection_Instance;
        public Agences_Detail Agences_Detail_Instance;
        public Parcs_Collection Parcs_Collection_Instance;
        public Parcs_Detail Parcs_Detail_Instance;
        #endregion

        #region Formulaires de compte
        public Inscription Inscription_Instance;
        public Connexion Connexion_Instance;
        public Profile Profile_Instance;
        public Administration Administration_Instance;
        #endregion

        public Main()
        {
            try
            {
                InitializeComponent();
                //DeactivateGUI();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void DisableAllRibbonPageGroupsExcept(RibbonPageGroup excludedGroup)
        {
            foreach (RibbonPage page in ribbonControl1.Pages)
                if (page is RibbonPage)
                    foreach (RibbonPageGroup group in page.Groups)
                        if (group is RibbonPageGroup && group != excludedGroup)
                            group.Enabled = false;
        }
        private void EnableAllRibbonPageGroups()
        {
            foreach (RibbonPage page in ribbonControl1.Pages)
                if (page is RibbonPage)
                    foreach (RibbonPageGroup group in page.Groups)
                        if (group is RibbonPageGroup)
                            group.Enabled = true;
        }

        private void DisableAllAccordionControlElementsExcept(AccordionControlElement excludedElement)
        {
            foreach (AccordionControlElement goupOfGroupsElement in accordionControl1.Elements)
                foreach (AccordionControlElement groupElement in goupOfGroupsElement.Elements)
                    foreach (AccordionControlElement element in groupElement.Elements)
                        if (element is AccordionControlElement && element.OwnerElement.OwnerElement != group_groups_items_compte)
                            element.Enabled = false;
        }

        private void EnableAllAccordionControlElements()
        {
            foreach (AccordionControlElement goupOfGroupsElement in accordionControl1.Elements)
                foreach (AccordionControlElement groupElement in goupOfGroupsElement.Elements)
                    foreach (AccordionControlElement element in groupElement.Elements)
                        if (element is AccordionControlElement)
                            element.Enabled = true;
        }

        /// <summary>
        /// Désactive tous les interfaces utilisateurs.
        /// </summary>
        public void DeactivateGUI()
        {
            DisableAllRibbonPageGroupsExcept(group_buttons_authentification);
            DisableAllAccordionControlElementsExcept(group_groups_items_compte);
            ribbonStatusBar.Enabled = false;
        }

        /// <summary>
        /// Active les interfaces utilisateur selon le rôle de l'utilisateur actif.
        /// </summary>
        /// <param name="activateGUI">Si True active les interfaces utilisateur, sinon les désactive</param>
        public void ActivateGUI()
        {
            EnableAllRibbonPageGroups();
            EnableAllAccordionControlElements();
            ribbonStatusBar.Enabled = true;
            switch (API.User.Role)
            {
                //=======================================================================
                case "Maître":
                //=======================================================================
                    break;

                //=======================================================================
                case "Administrateur":
                //=======================================================================
                    // Empêcher l'édition des administrateurs dans la section de gestion des utilisateurs
                    break;

                //=======================================================================
                case "Utilisateur":
                //=======================================================================
                    //item_administration.Visible = false;
                    item_utilisateurs.Visible = false;
                    break;

                //=======================================================================
                default:
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                button_connecter.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_contrats_Click(object sender, EventArgs e)
        {
            try
            {
                button_contrats.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_reservations_Click(object sender, EventArgs e)
        {
            try
            {
                button_reservations.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_clients_Click(object sender, EventArgs e)
        {
            try
            {
                button_clients.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_employes_Click(object sender, EventArgs e)
        {
            try
            {
                button_employes.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
        private void item_utilisateurs_Click(object sender, EventArgs e)
        {
            try
            {
                button_utilisateurs.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_vehicules_Click(object sender, EventArgs e)
        {
            try
            {
                button_vehicules.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_agences_Click(object sender, EventArgs e)
        {
            try
            {
                button_agences.PerformClick();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void item_parcs_Click(object sender, EventArgs e)
        {
            try
            {
                button_parcs.PerformClick();
            }
            catch (Exception x) 
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_contrats_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Contrats_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_reservations_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Reservations_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_clients_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Clients_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_employes_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Employes_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_utilisateurs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Utilisateurs_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_vehicules_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Vehicules_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_agences_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Agences_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_parcs_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                API.Controller.FormOpen(ref Parcs_Collection_Instance, this);
                ribbonControl1.SelectedPage = ribbonControl1.MergedRibbon.Pages["Gestion"];
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_connecter_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Connexion_Instance = new Connexion();
                Connexion_Instance.ShowDialog(this);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void button_deconnecter_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(API.Controller.LoginWaitFormType);
                API.User.LogOff();
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
    }
}