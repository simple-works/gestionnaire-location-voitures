namespace Car_Rental_Project.GUI.UC
{
    partial class CollectionManagementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.button_nouveau = new DevExpress.XtraBars.BarButtonItem();
            this.button_editer = new DevExpress.XtraBars.BarButtonItem();
            this.button_supprimer = new DevExpress.XtraBars.BarButtonItem();
            this.button_actualiser = new DevExpress.XtraBars.BarButtonItem();
            this.button_apercu_avant_impression = new DevExpress.XtraBars.BarButtonItem();
            this.button_fermer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_buttons_collection = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.button_nouveau,
            this.button_editer,
            this.button_supprimer,
            this.button_actualiser,
            this.button_apercu_avant_impression,
            this.button_fermer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(924, 139);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // button_nouveau
            // 
            this.button_nouveau.Caption = "Nouveau";
            this.button_nouveau.Id = 1;
            this.button_nouveau.ImageOptions.ImageUri.Uri = "New";
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_nouveau_ItemClick);
            // 
            // button_editer
            // 
            this.button_editer.Caption = "Éditer";
            this.button_editer.Id = 2;
            this.button_editer.ImageOptions.ImageUri.Uri = "Edit";
            this.button_editer.Name = "button_editer";
            this.button_editer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_editer_ItemClick);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Caption = "Supprimer";
            this.button_supprimer.Id = 3;
            this.button_supprimer.ImageOptions.ImageUri.Uri = "Delete";
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_supprimer_ItemClick);
            // 
            // button_actualiser
            // 
            this.button_actualiser.Caption = "Actualiser";
            this.button_actualiser.Id = 4;
            this.button_actualiser.ImageOptions.ImageUri.Uri = "Refresh";
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_actualiser_ItemClick);
            // 
            // button_apercu_avant_impression
            // 
            this.button_apercu_avant_impression.Caption = "Aperçu avant impression";
            this.button_apercu_avant_impression.Id = 5;
            this.button_apercu_avant_impression.ImageOptions.ImageUri.Uri = "Preview";
            this.button_apercu_avant_impression.Name = "button_apercu_avant_impression";
            this.button_apercu_avant_impression.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_apercu_avant_impression_ItemClick);
            // 
            // button_fermer
            // 
            this.button_fermer.Caption = "Fermer";
            this.button_fermer.Id = 13;
            this.button_fermer.ImageOptions.ImageUri.Uri = "Close";
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_fermer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_buttons_collection});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Gestion";
            // 
            // group_buttons_collection
            // 
            this.group_buttons_collection.ItemLinks.Add(this.button_nouveau);
            this.group_buttons_collection.ItemLinks.Add(this.button_editer);
            this.group_buttons_collection.ItemLinks.Add(this.button_supprimer);
            this.group_buttons_collection.ItemLinks.Add(this.button_actualiser);
            this.group_buttons_collection.ItemLinks.Add(this.button_apercu_avant_impression, true);
            this.group_buttons_collection.ItemLinks.Add(this.button_fermer, true);
            this.group_buttons_collection.Name = "group_buttons_collection";
            this.group_buttons_collection.ShowCaptionButton = false;
            this.group_buttons_collection.Text = "Gestion";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 483);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(924, 26);
            // 
            // CollectionManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CollectionManagementControl";
            this.Size = new System.Drawing.Size(924, 509);
            this.Load += new System.EventHandler(this.CollectionManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_buttons_collection;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem button_nouveau;
        private DevExpress.XtraBars.BarButtonItem button_editer;
        private DevExpress.XtraBars.BarButtonItem button_supprimer;
        private DevExpress.XtraBars.BarButtonItem button_actualiser;
        private DevExpress.XtraBars.BarButtonItem button_apercu_avant_impression;
        private DevExpress.XtraBars.BarButtonItem button_fermer;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}
