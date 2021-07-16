namespace Car_Rental_Project.GUI
{
    partial class Bug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bug));
            this.edit_details = new DevExpress.XtraEditors.MemoEdit();
            this.button_OK = new DevExpress.XtraEditors.SimpleButton();
            this.button_details = new DevExpress.XtraEditors.SimpleButton();
            this.lab_messsage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.edit_details.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edit_details
            // 
            this.edit_details.Location = new System.Drawing.Point(12, 310);
            this.edit_details.Name = "edit_details";
            this.edit_details.Properties.ReadOnly = true;
            this.edit_details.Size = new System.Drawing.Size(289, 154);
            this.edit_details.TabIndex = 0;
            this.edit_details.Visible = false;
            // 
            // button_OK
            // 
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(16, 138);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(238, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "Continuer";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_details
            // 
            this.button_details.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.button_details.AppearanceHovered.Options.UseFont = true;
            this.button_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_details.Image = ((System.Drawing.Image)(resources.GetObject("button_details.Image")));
            this.button_details.Location = new System.Drawing.Point(12, 470);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(289, 23);
            this.button_details.TabIndex = 1;
            this.button_details.Text = "Détails techniques";
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // lab_messsage
            // 
            this.lab_messsage.Location = new System.Drawing.Point(32, 18);
            this.lab_messsage.Name = "lab_messsage";
            this.lab_messsage.Size = new System.Drawing.Size(207, 104);
            this.lab_messsage.TabIndex = 2;
            this.lab_messsage.Text = "Oops ...\r\nUne erreur s\'est produite ...\r\n\r\nNous sommes désolé pour \r\nle désagréme" +
    "nt rencontré ...\r\n\r\nPour obtenir de l\'assistance Veuillez \r\nsignaler cette erreu" +
    "r au support technique.";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::Car_Rental_Project.Properties.Resources.anim_robot;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(660, 505);
            this.pictureEdit1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lab_messsage);
            this.panelControl1.Controls.Add(this.button_OK);
            this.panelControl1.Location = new System.Drawing.Point(377, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(271, 176);
            this.panelControl1.TabIndex = 4;
            // 
            // Bug
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 505);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.button_details);
            this.Controls.Add(this.edit_details);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bug";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Erreur";
            ((System.ComponentModel.ISupportInitialize)(this.edit_details.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit edit_details;
        private DevExpress.XtraEditors.SimpleButton button_OK;
        private DevExpress.XtraEditors.SimpleButton button_details;
        private DevExpress.XtraEditors.LabelControl lab_messsage;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}