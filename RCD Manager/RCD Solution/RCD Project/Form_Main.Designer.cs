namespace RCD_Project
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.rcD_ConnectionView1 = new RCD_Project.Views.RCD_ConnectionView.RCD_ConnectionView();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // rcD_ConnectionView1
            // 
            this.rcD_ConnectionView1.Appearance.BackColor = System.Drawing.Color.White;
            this.rcD_ConnectionView1.Appearance.Options.UseBackColor = true;
            this.rcD_ConnectionView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcD_ConnectionView1.Location = new System.Drawing.Point(0, 0);
            this.rcD_ConnectionView1.Name = "rcD_ConnectionView1";
            this.rcD_ConnectionView1.Size = new System.Drawing.Size(1023, 467);
            this.rcD_ConnectionView1.TabIndex = 0;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoHeight = true;
            this.alertControl1.FormMaxCount = 5;
            this.alertControl1.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alertControl1_AlertClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 467);
            this.Controls.Add(this.rcD_ConnectionView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RCD Manager 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.RCD_ConnectionView.RCD_ConnectionView rcD_ConnectionView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}

