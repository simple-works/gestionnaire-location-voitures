namespace Car_Rental_Project.GUI.Compte
{
    partial class Connexion
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.page_username = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button_suivant = new DevExpress.XtraEditors.SimpleButton();
            this.edit_nom_utilisateur = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.page_password = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lab_nom_employe_utilisateur_identifie = new DevExpress.XtraEditors.TextEdit();
            this.lab_nom_utilisateur_identifie = new DevExpress.XtraEditors.TextEdit();
            this.button_precedent = new DevExpress.XtraEditors.SimpleButton();
            this.edit_memoriser = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button_connexion = new DevExpress.XtraEditors.SimpleButton();
            this.edit_mot_passe = new DevExpress.XtraEditors.TextEdit();
            this.photo_utilisateur_identifie = new DevExpress.XtraEditors.PictureEdit();
            this.page_error = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lab_messsage = new DevExpress.XtraEditors.LabelControl();
            this.button_reessayer = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.page_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_nom_utilisateur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.page_password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab_nom_employe_utilisateur_identifie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_nom_utilisateur_identifie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_memoriser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_mot_passe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_utilisateur_identifie.Properties)).BeginInit();
            this.page_error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame1.Appearance.Options.UseBackColor = true;
            this.navigationFrame1.Controls.Add(this.page_username);
            this.navigationFrame1.Controls.Add(this.page_password);
            this.navigationFrame1.Controls.Add(this.page_error);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.page_username,
            this.page_password,
            this.page_error});
            this.navigationFrame1.SelectedPage = this.page_username;
            this.navigationFrame1.Size = new System.Drawing.Size(700, 504);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.PushFade;
            // 
            // page_username
            // 
            this.page_username.Caption = "page_username";
            this.page_username.Controls.Add(this.labelControl1);
            this.page_username.Controls.Add(this.button_suivant);
            this.page_username.Controls.Add(this.edit_nom_utilisateur);
            this.page_username.Controls.Add(this.pictureEdit2);
            this.page_username.Name = "page_username";
            this.page_username.Size = new System.Drawing.Size(700, 504);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(311, 388);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Nom d\'utilisateur";
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(178, 433);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(345, 23);
            this.button_suivant.TabIndex = 6;
            this.button_suivant.Text = "Suivant";
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // edit_nom_utilisateur
            // 
            this.edit_nom_utilisateur.Location = new System.Drawing.Point(178, 407);
            this.edit_nom_utilisateur.Name = "edit_nom_utilisateur";
            this.edit_nom_utilisateur.Size = new System.Drawing.Size(345, 20);
            this.edit_nom_utilisateur.TabIndex = 5;
            this.edit_nom_utilisateur.ToolTip = "Entrez";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Veuillez saisir votre nom d\'utilisateur.";
            this.dxValidationProvider1.SetValidationRule(this.edit_nom_utilisateur, conditionValidationRule1);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::Car_Rental_Project.Properties.Resources.anim_rotat;
            this.pictureEdit2.Location = new System.Drawing.Point(49, -29);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(602, 485);
            this.pictureEdit2.TabIndex = 4;
            // 
            // page_password
            // 
            this.page_password.Caption = "page_password";
            this.page_password.Controls.Add(this.lab_nom_employe_utilisateur_identifie);
            this.page_password.Controls.Add(this.lab_nom_utilisateur_identifie);
            this.page_password.Controls.Add(this.button_precedent);
            this.page_password.Controls.Add(this.edit_memoriser);
            this.page_password.Controls.Add(this.labelControl2);
            this.page_password.Controls.Add(this.button_connexion);
            this.page_password.Controls.Add(this.edit_mot_passe);
            this.page_password.Controls.Add(this.photo_utilisateur_identifie);
            this.page_password.Name = "page_password";
            this.page_password.Size = new System.Drawing.Size(700, 504);
            // 
            // lab_nom_employe_utilisateur_identifie
            // 
            this.lab_nom_employe_utilisateur_identifie.EditValue = "<user_employee_name>";
            this.lab_nom_employe_utilisateur_identifie.Location = new System.Drawing.Point(192, 346);
            this.lab_nom_employe_utilisateur_identifie.Name = "lab_nom_employe_utilisateur_identifie";
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.Options.UseBackColor = true;
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.Options.UseFont = true;
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.Options.UseTextOptions = true;
            this.lab_nom_employe_utilisateur_identifie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lab_nom_employe_utilisateur_identifie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lab_nom_employe_utilisateur_identifie.Properties.ReadOnly = true;
            this.lab_nom_employe_utilisateur_identifie.Size = new System.Drawing.Size(317, 18);
            this.lab_nom_employe_utilisateur_identifie.TabIndex = 14;
            // 
            // lab_nom_utilisateur_identifie
            // 
            this.lab_nom_utilisateur_identifie.EditValue = "<user_name>";
            this.lab_nom_utilisateur_identifie.Location = new System.Drawing.Point(192, 325);
            this.lab_nom_utilisateur_identifie.Name = "lab_nom_utilisateur_identifie";
            this.lab_nom_utilisateur_identifie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lab_nom_utilisateur_identifie.Properties.Appearance.Options.UseBackColor = true;
            this.lab_nom_utilisateur_identifie.Properties.Appearance.Options.UseTextOptions = true;
            this.lab_nom_utilisateur_identifie.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lab_nom_utilisateur_identifie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lab_nom_utilisateur_identifie.Properties.ReadOnly = true;
            this.lab_nom_utilisateur_identifie.Size = new System.Drawing.Size(317, 18);
            this.lab_nom_utilisateur_identifie.TabIndex = 13;
            // 
            // button_precedent
            // 
            this.button_precedent.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.button_precedent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_precedent.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.button_precedent.ImageUri.Uri = "Backward";
            this.button_precedent.Location = new System.Drawing.Point(12, 12);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(41, 44);
            this.button_precedent.TabIndex = 12;
            this.button_precedent.Click += new System.EventHandler(this.button_precedent_Click);
            // 
            // edit_memoriser
            // 
            this.edit_memoriser.EditValue = true;
            this.edit_memoriser.Location = new System.Drawing.Point(178, 462);
            this.edit_memoriser.Name = "edit_memoriser";
            this.edit_memoriser.Properties.Caption = "Mémoriser";
            this.edit_memoriser.Size = new System.Drawing.Size(75, 19);
            this.edit_memoriser.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(318, 388);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Mot de passe";
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(178, 433);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(345, 23);
            this.button_connexion.TabIndex = 9;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // edit_mot_passe
            // 
            this.edit_mot_passe.Location = new System.Drawing.Point(178, 407);
            this.edit_mot_passe.Name = "edit_mot_passe";
            this.edit_mot_passe.Properties.UseSystemPasswordChar = true;
            this.edit_mot_passe.Size = new System.Drawing.Size(345, 20);
            this.edit_mot_passe.TabIndex = 8;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Veuillez saisir votre mot de passe.";
            this.dxValidationProvider1.SetValidationRule(this.edit_mot_passe, conditionValidationRule2);
            // 
            // photo_utilisateur_identifie
            // 
            this.photo_utilisateur_identifie.Cursor = System.Windows.Forms.Cursors.Default;
            this.photo_utilisateur_identifie.EditValue = global::Car_Rental_Project.Properties.Resources.photo_client;
            this.photo_utilisateur_identifie.Location = new System.Drawing.Point(192, 39);
            this.photo_utilisateur_identifie.Name = "photo_utilisateur_identifie";
            this.photo_utilisateur_identifie.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.photo_utilisateur_identifie.Properties.Appearance.Options.UseBackColor = true;
            this.photo_utilisateur_identifie.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.photo_utilisateur_identifie.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.photo_utilisateur_identifie.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.photo_utilisateur_identifie.Properties.ZoomAccelerationFactor = 1D;
            this.photo_utilisateur_identifie.Size = new System.Drawing.Size(317, 276);
            this.photo_utilisateur_identifie.TabIndex = 2;
            // 
            // page_error
            // 
            this.page_error.BackgroundImage = global::Car_Rental_Project.Properties.Resources.rgb_255_185_156;
            this.page_error.Caption = "page_error";
            this.page_error.Controls.Add(this.panelControl1);
            this.page_error.Controls.Add(this.pictureEdit1);
            this.page_error.Name = "page_error";
            this.page_error.Size = new System.Drawing.Size(700, 504);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lab_messsage);
            this.panelControl1.Controls.Add(this.button_reessayer);
            this.panelControl1.Location = new System.Drawing.Point(352, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(336, 140);
            this.panelControl1.TabIndex = 6;
            // 
            // lab_messsage
            // 
            this.lab_messsage.Location = new System.Drawing.Point(24, 18);
            this.lab_messsage.Name = "lab_messsage";
            this.lab_messsage.Size = new System.Drawing.Size(288, 65);
            this.lab_messsage.TabIndex = 2;
            this.lab_messsage.Text = resources.GetString("lab_messsage.Text");
            // 
            // button_reessayer
            // 
            this.button_reessayer.Image = ((System.Drawing.Image)(resources.GetObject("button_reessayer.Image")));
            this.button_reessayer.Location = new System.Drawing.Point(20, 99);
            this.button_reessayer.Name = "button_reessayer";
            this.button_reessayer.Size = new System.Drawing.Size(296, 23);
            this.button_reessayer.TabIndex = 1;
            this.button_reessayer.Text = "Réessayer";
            this.button_reessayer.Click += new System.EventHandler(this.button_reessayer_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Car_Rental_Project.Properties.Resources.anim_4x4;
            this.pictureEdit1.Location = new System.Drawing.Point(3, 101);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(528, 398);
            this.pictureEdit1.TabIndex = 5;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // Connexion
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 504);
            this.Controls.Add(this.navigationFrame1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connexion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.page_username.ResumeLayout(false);
            this.page_username.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_nom_utilisateur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.page_password.ResumeLayout(false);
            this.page_password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab_nom_employe_utilisateur_identifie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab_nom_utilisateur_identifie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_memoriser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_mot_passe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_utilisateur_identifie.Properties)).EndInit();
            this.page_error.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage page_username;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton button_suivant;
        private DevExpress.XtraEditors.TextEdit edit_nom_utilisateur;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraBars.Navigation.NavigationPage page_password;
        private DevExpress.XtraEditors.SimpleButton button_precedent;
        private DevExpress.XtraEditors.CheckEdit edit_memoriser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton button_connexion;
        private DevExpress.XtraEditors.TextEdit edit_mot_passe;
        private DevExpress.XtraEditors.PictureEdit photo_utilisateur_identifie;
        private DevExpress.XtraBars.Navigation.NavigationPage page_error;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lab_messsage;
        private DevExpress.XtraEditors.SimpleButton button_reessayer;
        private DevExpress.XtraEditors.TextEdit lab_nom_employe_utilisateur_identifie;
        private DevExpress.XtraEditors.TextEdit lab_nom_utilisateur_identifie;
    }
}