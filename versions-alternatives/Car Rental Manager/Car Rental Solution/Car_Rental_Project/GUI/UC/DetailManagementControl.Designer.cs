using System.ComponentModel;

namespace Car_Rental_Project.GUI.UC
{
    partial class DetailManagementControl
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
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.button_fermer = new DevExpress.XtraBars.BarButtonItem();
            this.button_enregistrer = new DevExpress.XtraBars.BarButtonItem();
            this.button_enregistrer_et_fermer = new DevExpress.XtraBars.BarButtonItem();
            this.button_enregistrer_et_nouveau = new DevExpress.XtraBars.BarButtonItem();
            this.button_annuler_changements = new DevExpress.XtraBars.BarButtonItem();
            this.button_supprimer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.group_buttons_detail = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 495);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(910, 26);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.button_fermer,
            this.button_enregistrer,
            this.button_enregistrer_et_fermer,
            this.button_enregistrer_et_nouveau,
            this.button_annuler_changements,
            this.button_supprimer});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(910, 139);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // button_fermer
            // 
            this.button_fermer.Caption = "Fermer";
            this.button_fermer.Id = 7;
            this.button_fermer.ImageOptions.ImageUri.Uri = "Close";
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_fermer_ItemClick);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Caption = "Enregistrer";
            this.button_enregistrer.Id = 8;
            this.button_enregistrer.ImageOptions.ImageUri.Uri = "Save";
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_enregistrer_ItemClick);
            // 
            // button_enregistrer_et_fermer
            // 
            this.button_enregistrer_et_fermer.Caption = "Enregistrer et Fermer";
            this.button_enregistrer_et_fermer.Id = 9;
            this.button_enregistrer_et_fermer.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.button_enregistrer_et_fermer.Name = "button_enregistrer_et_fermer";
            this.button_enregistrer_et_fermer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_enregistrer_et_fermer_ItemClick);
            // 
            // button_enregistrer_et_nouveau
            // 
            this.button_enregistrer_et_nouveau.Caption = "Enregistrer et Nouveau";
            this.button_enregistrer_et_nouveau.Id = 10;
            this.button_enregistrer_et_nouveau.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.button_enregistrer_et_nouveau.Name = "button_enregistrer_et_nouveau";
            this.button_enregistrer_et_nouveau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_enregistrer_et_nouveau_ItemClick);
            // 
            // button_annuler_changements
            // 
            this.button_annuler_changements.Caption = "Annuler les changements";
            this.button_annuler_changements.Id = 11;
            this.button_annuler_changements.ImageOptions.ImageUri.Uri = "Undo";
            this.button_annuler_changements.Name = "button_annuler_changements";
            this.button_annuler_changements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_annuler_changements_ItemClick);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Caption = "Supprimer";
            this.button_supprimer.Id = 12;
            this.button_supprimer.ImageOptions.ImageUri.Uri = "Delete";
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.button_supprimer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.group_buttons_detail});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Gestion";
            // 
            // group_buttons_detail
            // 
            this.group_buttons_detail.ItemLinks.Add(this.button_enregistrer);
            this.group_buttons_detail.ItemLinks.Add(this.button_enregistrer_et_fermer);
            this.group_buttons_detail.ItemLinks.Add(this.button_enregistrer_et_nouveau);
            this.group_buttons_detail.ItemLinks.Add(this.button_annuler_changements);
            this.group_buttons_detail.ItemLinks.Add(this.button_supprimer);
            this.group_buttons_detail.ItemLinks.Add(this.button_fermer, true);
            this.group_buttons_detail.Name = "group_buttons_detail";
            this.group_buttons_detail.ShowCaptionButton = false;
            this.group_buttons_detail.Text = "Gestion";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Gestion";
            // 
            // DetailManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DetailManagementControl";
            this.Size = new System.Drawing.Size(910, 521);
            this.Load += new System.EventHandler(this.DetailManagementControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem button_fermer;
        private DevExpress.XtraBars.BarButtonItem button_enregistrer;
        private DevExpress.XtraBars.BarButtonItem button_enregistrer_et_fermer;
        private DevExpress.XtraBars.BarButtonItem button_enregistrer_et_nouveau;
        private DevExpress.XtraBars.BarButtonItem button_annuler_changements;
        private DevExpress.XtraBars.BarButtonItem button_supprimer;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup group_buttons_detail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}
