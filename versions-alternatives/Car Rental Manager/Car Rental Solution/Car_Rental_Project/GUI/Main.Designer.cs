using System;

namespace Car_Rental_Project.GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Car_Rental_Project.GUI.Splash), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.button_connecter = new DevExpress.XtraBars.BarButtonItem();
            this.button_deconnecter = new DevExpress.XtraBars.BarButtonItem();
            this.button_composants = new DevExpress.XtraBars.BarSubItem();
            this.button_contrats = new DevExpress.XtraBars.BarButtonItem();
            this.button_reservations = new DevExpress.XtraBars.BarButtonItem();
            this.button_clients = new DevExpress.XtraBars.BarButtonItem();
            this.button_employes = new DevExpress.XtraBars.BarButtonItem();
            this.button_utilisateurs = new DevExpress.XtraBars.BarButtonItem();
            this.button_vehicules = new DevExpress.XtraBars.BarButtonItem();
            this.button_agences = new DevExpress.XtraBars.BarButtonItem();
            this.button_parcs = new DevExpress.XtraBars.BarButtonItem();
            this.page_accueil = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_buttons_authentification = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_gestion = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_buttons_composant = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.group_groups_items_gestion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.group_items_actes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_contrats = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_reservations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.group_items_personnes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_clients = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_employes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_utilisateurs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.group_items_produits = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_vehicules = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.group_items_emplacements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_agences = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.item_parcs = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.group_groups_items_compte = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 3000;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.button_connecter,
            this.button_deconnecter,
            this.button_composants,
            this.button_contrats,
            this.button_reservations,
            this.button_clients,
            this.button_employes,
            this.button_utilisateurs,
            this.button_vehicules,
            this.button_agences,
            this.button_parcs});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_accueil,
            this.page_gestion});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(997, 146);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            // 
            // button_connecter
            // 
            this.button_connecter.Caption = "Se connecter";
            this.button_connecter.Id = 1;
            this.button_connecter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_connecter.ImageOptions.Image")));
            this.button_connecter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("button_connecter.ImageOptions.LargeImage")));
            this.button_connecter.Name = "button_connecter";
            this.button_connecter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_connecter_ItemClick);
            // 
            // button_deconnecter
            // 
            this.button_deconnecter.Caption = "Se déconnecter";
            this.button_deconnecter.Id = 2;
            this.button_deconnecter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_deconnecter.ImageOptions.Image")));
            this.button_deconnecter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("button_deconnecter.ImageOptions.LargeImage")));
            this.button_deconnecter.Name = "button_deconnecter";
            this.button_deconnecter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_deconnecter_ItemClick);
            // 
            // button_composants
            // 
            this.button_composants.Caption = "Composants";
            this.button_composants.Id = 3;
            this.button_composants.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_composants.ImageOptions.Image")));
            this.button_composants.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("button_composants.ImageOptions.LargeImage")));
            this.button_composants.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.button_contrats, "Contrats", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_reservations),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_clients),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_employes),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_utilisateurs),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_vehicules),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_agences),
            new DevExpress.XtraBars.LinkPersistInfo(this.button_parcs)});
            this.button_composants.Name = "button_composants";
            // 
            // button_contrats
            // 
            this.button_contrats.Caption = "Contrats";
            this.button_contrats.Id = 15;
            this.button_contrats.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_contrats.ImageOptions.Image")));
            this.button_contrats.Name = "button_contrats";
            this.button_contrats.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_contrats_ItemClick);
            // 
            // button_reservations
            // 
            this.button_reservations.Caption = "Réservations";
            this.button_reservations.Id = 16;
            this.button_reservations.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_reservations.ImageOptions.Image")));
            this.button_reservations.Name = "button_reservations";
            this.button_reservations.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_reservations_ItemClick);
            // 
            // button_clients
            // 
            this.button_clients.Caption = "Clients";
            this.button_clients.Id = 17;
            this.button_clients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_clients.ImageOptions.Image")));
            this.button_clients.Name = "button_clients";
            this.button_clients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_clients_ItemClick);
            // 
            // button_employes
            // 
            this.button_employes.Caption = "Employés";
            this.button_employes.Id = 19;
            this.button_employes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_employes.ImageOptions.Image")));
            this.button_employes.Name = "button_employes";
            this.button_employes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_employes_ItemClick);
            // 
            // button_utilisateurs
            // 
            this.button_utilisateurs.Caption = "Utilisateurs";
            this.button_utilisateurs.Id = 20;
            this.button_utilisateurs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_utilisateurs.ImageOptions.Image")));
            this.button_utilisateurs.Name = "button_utilisateurs";
            this.button_utilisateurs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_utilisateurs_ItemClick);
            // 
            // button_vehicules
            // 
            this.button_vehicules.Caption = "Véhicules";
            this.button_vehicules.Id = 21;
            this.button_vehicules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_vehicules.ImageOptions.Image")));
            this.button_vehicules.Name = "button_vehicules";
            this.button_vehicules.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_vehicules_ItemClick);
            // 
            // button_agences
            // 
            this.button_agences.Caption = "Agences";
            this.button_agences.Id = 22;
            this.button_agences.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_agences.ImageOptions.Image")));
            this.button_agences.Name = "button_agences";
            this.button_agences.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_agences_ItemClick);
            // 
            // button_parcs
            // 
            this.button_parcs.Caption = "Parcs";
            this.button_parcs.Id = 23;
            this.button_parcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("button_parcs.ImageOptions.Image")));
            this.button_parcs.Name = "button_parcs";
            this.button_parcs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_parcs_ItemClick);
            // 
            // page_accueil
            // 
            this.page_accueil.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_buttons_authentification});
            this.page_accueil.Name = "page_accueil";
            this.page_accueil.Text = "Accueil";
            // 
            // group_buttons_authentification
            // 
            this.group_buttons_authentification.ItemLinks.Add(this.button_connecter);
            this.group_buttons_authentification.ItemLinks.Add(this.button_deconnecter);
            this.group_buttons_authentification.Name = "group_buttons_authentification";
            this.group_buttons_authentification.ShowCaptionButton = false;
            this.group_buttons_authentification.Text = "Authentification";
            // 
            // page_gestion
            // 
            this.page_gestion.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_buttons_composant});
            this.page_gestion.Name = "page_gestion";
            this.page_gestion.Text = "Gestion";
            // 
            // group_buttons_composant
            // 
            this.group_buttons_composant.ItemLinks.Add(this.button_composants);
            this.group_buttons_composant.Name = "group_buttons_composant";
            this.group_buttons_composant.ShowCaptionButton = false;
            this.group_buttons_composant.Text = "Composant";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 492);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(997, 21);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("b4ef4575-76fd-4af2-9053-40ffb514b336");
            this.dockPanel1.ImageUri.Uri = "Open;Size16x16";
            this.dockPanel1.Location = new System.Drawing.Point(0, 146);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(254, 200);
            this.dockPanel1.Size = new System.Drawing.Size(254, 346);
            this.dockPanel1.Text = "Explorateur";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.accordionControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 38);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(245, 304);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.group_groups_items_gestion,
            this.group_groups_items_compte});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(245, 304);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // group_groups_items_gestion
            // 
            this.group_groups_items_gestion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.group_items_actes,
            this.group_items_personnes,
            this.group_items_produits,
            this.group_items_emplacements});
            this.group_groups_items_gestion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_groups_items_gestion.ImageOptions.Image")));
            this.group_groups_items_gestion.Name = "group_groups_items_gestion";
            this.group_groups_items_gestion.Text = "Gestion";
            // 
            // group_items_actes
            // 
            this.group_items_actes.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.item_contrats,
            this.item_reservations});
            this.group_items_actes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_items_actes.ImageOptions.Image")));
            this.group_items_actes.Name = "group_items_actes";
            this.group_items_actes.Text = "Actes";
            // 
            // item_contrats
            // 
            this.item_contrats.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_contrats.ImageOptions.Image")));
            this.item_contrats.Name = "item_contrats";
            this.item_contrats.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_contrats.Text = "Contrats";
            this.item_contrats.Click += new System.EventHandler(this.item_contrats_Click);
            // 
            // item_reservations
            // 
            this.item_reservations.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_reservations.ImageOptions.Image")));
            this.item_reservations.Name = "item_reservations";
            this.item_reservations.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_reservations.Text = "Réservations";
            this.item_reservations.Click += new System.EventHandler(this.item_reservations_Click);
            // 
            // group_items_personnes
            // 
            this.group_items_personnes.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.item_clients,
            this.item_employes,
            this.item_utilisateurs});
            this.group_items_personnes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_items_personnes.ImageOptions.Image")));
            this.group_items_personnes.Name = "group_items_personnes";
            this.group_items_personnes.Text = "Personnes";
            // 
            // item_clients
            // 
            this.item_clients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_clients.ImageOptions.Image")));
            this.item_clients.Name = "item_clients";
            this.item_clients.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_clients.Text = "Clients";
            this.item_clients.Click += new System.EventHandler(this.item_clients_Click);
            // 
            // item_employes
            // 
            this.item_employes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_employes.ImageOptions.Image")));
            this.item_employes.Name = "item_employes";
            this.item_employes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_employes.Text = "Employés";
            this.item_employes.Click += new System.EventHandler(this.item_employes_Click);
            // 
            // item_utilisateurs
            // 
            this.item_utilisateurs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_utilisateurs.ImageOptions.Image")));
            this.item_utilisateurs.Name = "item_utilisateurs";
            this.item_utilisateurs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_utilisateurs.Text = "Utilisateurs";
            this.item_utilisateurs.Click += new System.EventHandler(this.item_utilisateurs_Click);
            // 
            // group_items_produits
            // 
            this.group_items_produits.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.item_vehicules});
            this.group_items_produits.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_items_produits.ImageOptions.Image")));
            this.group_items_produits.Name = "group_items_produits";
            this.group_items_produits.Text = "Produits";
            // 
            // item_vehicules
            // 
            this.item_vehicules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_vehicules.ImageOptions.Image")));
            this.item_vehicules.Name = "item_vehicules";
            this.item_vehicules.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_vehicules.Text = "Véhicules";
            this.item_vehicules.Click += new System.EventHandler(this.item_vehicules_Click);
            // 
            // group_items_emplacements
            // 
            this.group_items_emplacements.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.item_agences,
            this.item_parcs});
            this.group_items_emplacements.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_items_emplacements.ImageOptions.Image")));
            this.group_items_emplacements.Name = "group_items_emplacements";
            this.group_items_emplacements.Text = "Emplacements";
            // 
            // item_agences
            // 
            this.item_agences.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_agences.ImageOptions.Image")));
            this.item_agences.Name = "item_agences";
            this.item_agences.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_agences.Text = "Agences";
            this.item_agences.Click += new System.EventHandler(this.item_agences_Click);
            // 
            // item_parcs
            // 
            this.item_parcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("item_parcs.ImageOptions.Image")));
            this.item_parcs.Name = "item_parcs";
            this.item_parcs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.item_parcs.Text = "Parcs";
            this.item_parcs.Click += new System.EventHandler(this.item_parcs_Click);
            // 
            // group_groups_items_compte
            // 
            this.group_groups_items_compte.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("group_groups_items_compte.ImageOptions.Image")));
            this.group_groups_items_compte.Name = "group_groups_items_compte";
            this.group_groups_items_compte.Text = "Compte";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 513);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Car Rental Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage page_accueil;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_buttons_authentification;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem button_connecter;
        private DevExpress.XtraBars.BarButtonItem button_deconnecter;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_groups_items_gestion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_items_actes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_contrats;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_reservations;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_items_personnes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_clients;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_employes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_utilisateurs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_items_produits;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_vehicules;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_items_emplacements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_agences;
        private DevExpress.XtraBars.Navigation.AccordionControlElement item_parcs;
        private DevExpress.XtraBars.Navigation.AccordionControlElement group_groups_items_compte;
        private DevExpress.XtraBars.BarSubItem button_composants;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_gestion;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_buttons_composant;
        private DevExpress.XtraBars.BarButtonItem button_contrats;
        private DevExpress.XtraBars.BarButtonItem button_reservations;
        private DevExpress.XtraBars.BarButtonItem button_clients;
        private DevExpress.XtraBars.BarButtonItem button_employes;
        private DevExpress.XtraBars.BarButtonItem button_utilisateurs;
        private DevExpress.XtraBars.BarButtonItem button_vehicules;
        private DevExpress.XtraBars.BarButtonItem button_agences;
        private DevExpress.XtraBars.BarButtonItem button_parcs;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}