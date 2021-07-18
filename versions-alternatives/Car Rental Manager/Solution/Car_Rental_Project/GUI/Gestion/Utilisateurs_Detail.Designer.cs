namespace Car_Rental_Project.GUI.Gestion
{
    partial class Utilisateurs_Detail
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateurs_Detail));
            this.detailManagementControl1 = new Car_Rental_Project.GUI.UC.DetailManagementControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.nom_utilisateur_pkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mot_passe_utilisateurTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.role_utilisateurComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.id_employe_fkGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForid_employe_fk = new DevExpress.XtraLayout.LayoutControlItem();
            this.date_heure_derniere_connexion_utilisaturDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemFordate_heure_derniere_connexion_utilisatur = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFornom_utilisateur_pk = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormot_passe_utilisateur = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForrole_utilisateur = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.detailManagementControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_utilisateur_pkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mot_passe_utilisateurTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_utilisateurComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_employe_fkGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_employe_fk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_heure_derniere_connexion_utilisaturDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_heure_derniere_connexion_utilisaturDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_heure_derniere_connexion_utilisatur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom_utilisateur_pk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormot_passe_utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForrole_utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            this.SuspendLayout();
            // 
            // detailManagementControl1
            // 
            this.detailManagementControl1.Controls.Add(this.dataLayoutControl1);
            this.detailManagementControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailManagementControl1.Location = new System.Drawing.Point(0, 0);
            this.detailManagementControl1.Name = "detailManagementControl1";
            this.detailManagementControl1.Size = new System.Drawing.Size(803, 495);
            this.detailManagementControl1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.nom_utilisateur_pkTextEdit);
            this.dataLayoutControl1.Controls.Add(this.mot_passe_utilisateurTextEdit);
            this.dataLayoutControl1.Controls.Add(this.role_utilisateurComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.id_employe_fkGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.date_heure_derniere_connexion_utilisaturDateEdit);
            this.dataLayoutControl1.DataMember = "utilisateur";
            this.dataLayoutControl1.DataSource = this.sqlDataSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(803, 327);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(803, 327);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "nom_utilisateur_pk";
            table1.MetaSerializable = "30|30|125|210";
            table1.Name = "utilisateur";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "mot_passe_utilisateur";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "role_utilisateur";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "id_employe_fk";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "date_heure_derniere_connexion_utilisatur";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "utilisateur";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(783, 307);
            // 
            // nom_utilisateur_pkTextEdit
            // 
            this.nom_utilisateur_pkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "utilisateur.nom_utilisateur_pk", true));
            this.nom_utilisateur_pkTextEdit.Location = new System.Drawing.Point(24, 62);
            this.nom_utilisateur_pkTextEdit.Name = "nom_utilisateur_pkTextEdit";
            this.nom_utilisateur_pkTextEdit.Size = new System.Drawing.Size(755, 20);
            this.nom_utilisateur_pkTextEdit.StyleController = this.dataLayoutControl1;
            this.nom_utilisateur_pkTextEdit.TabIndex = 4;
            // 
            // mot_passe_utilisateurTextEdit
            // 
            this.mot_passe_utilisateurTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "utilisateur.mot_passe_utilisateur", true));
            this.mot_passe_utilisateurTextEdit.Location = new System.Drawing.Point(24, 102);
            this.mot_passe_utilisateurTextEdit.Name = "mot_passe_utilisateurTextEdit";
            this.mot_passe_utilisateurTextEdit.Size = new System.Drawing.Size(755, 20);
            this.mot_passe_utilisateurTextEdit.StyleController = this.dataLayoutControl1;
            this.mot_passe_utilisateurTextEdit.TabIndex = 5;
            // 
            // role_utilisateurComboBoxEdit
            // 
            this.role_utilisateurComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "utilisateur.role_utilisateur", true));
            this.role_utilisateurComboBoxEdit.Location = new System.Drawing.Point(24, 142);
            this.role_utilisateurComboBoxEdit.Name = "role_utilisateurComboBoxEdit";
            this.role_utilisateurComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.role_utilisateurComboBoxEdit.Size = new System.Drawing.Size(755, 20);
            this.role_utilisateurComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.role_utilisateurComboBoxEdit.TabIndex = 6;
            // 
            // id_employe_fkGridLookUpEdit
            // 
            this.id_employe_fkGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "utilisateur.id_employe_fk", true));
            this.id_employe_fkGridLookUpEdit.Location = new System.Drawing.Point(24, 62);
            this.id_employe_fkGridLookUpEdit.Name = "id_employe_fkGridLookUpEdit";
            this.id_employe_fkGridLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.id_employe_fkGridLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.id_employe_fkGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.id_employe_fkGridLookUpEdit.Properties.NullText = "";
            this.id_employe_fkGridLookUpEdit.Properties.View = this.gridLookUpEdit1View;
            this.id_employe_fkGridLookUpEdit.Size = new System.Drawing.Size(755, 20);
            this.id_employe_fkGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.id_employe_fkGridLookUpEdit.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForid_employe_fk
            // 
            this.ItemForid_employe_fk.Control = this.id_employe_fkGridLookUpEdit;
            this.ItemForid_employe_fk.Location = new System.Drawing.Point(0, 0);
            this.ItemForid_employe_fk.Name = "ItemForid_employe_fk";
            this.ItemForid_employe_fk.Size = new System.Drawing.Size(759, 261);
            this.ItemForid_employe_fk.Text = "Employé propriétaire du compte utilisateur";
            this.ItemForid_employe_fk.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForid_employe_fk.TextSize = new System.Drawing.Size(202, 13);
            // 
            // date_heure_derniere_connexion_utilisaturDateEdit
            // 
            this.date_heure_derniere_connexion_utilisaturDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sqlDataSource1, "utilisateur.date_heure_derniere_connexion_utilisatur", true));
            this.date_heure_derniere_connexion_utilisaturDateEdit.EditValue = null;
            this.date_heure_derniere_connexion_utilisaturDateEdit.Location = new System.Drawing.Point(24, 182);
            this.date_heure_derniere_connexion_utilisaturDateEdit.Name = "date_heure_derniere_connexion_utilisaturDateEdit";
            this.date_heure_derniere_connexion_utilisaturDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_heure_derniere_connexion_utilisaturDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_heure_derniere_connexion_utilisaturDateEdit.Properties.ReadOnly = true;
            this.date_heure_derniere_connexion_utilisaturDateEdit.Size = new System.Drawing.Size(755, 20);
            this.date_heure_derniere_connexion_utilisaturDateEdit.StyleController = this.dataLayoutControl1;
            this.date_heure_derniere_connexion_utilisaturDateEdit.TabIndex = 8;
            // 
            // ItemFordate_heure_derniere_connexion_utilisatur
            // 
            this.ItemFordate_heure_derniere_connexion_utilisatur.Control = this.date_heure_derniere_connexion_utilisaturDateEdit;
            this.ItemFordate_heure_derniere_connexion_utilisatur.Location = new System.Drawing.Point(0, 120);
            this.ItemFordate_heure_derniere_connexion_utilisatur.Name = "ItemFordate_heure_derniere_connexion_utilisatur";
            this.ItemFordate_heure_derniere_connexion_utilisatur.Size = new System.Drawing.Size(759, 141);
            this.ItemFordate_heure_derniere_connexion_utilisatur.Text = "Date et heure de la dernière connexion";
            this.ItemFordate_heure_derniere_connexion_utilisatur.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemFordate_heure_derniere_connexion_utilisatur.TextSize = new System.Drawing.Size(202, 13);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
            this.tabbedControlGroup1.SelectedTabPageIndex = 1;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(783, 307);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornom_utilisateur_pk,
            this.ItemFormot_passe_utilisateur,
            this.ItemForrole_utilisateur,
            this.ItemFordate_heure_derniere_connexion_utilisatur});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(759, 261);
            this.layoutControlGroup3.Text = "Généralités";
            // 
            // ItemFornom_utilisateur_pk
            // 
            this.ItemFornom_utilisateur_pk.Control = this.nom_utilisateur_pkTextEdit;
            this.ItemFornom_utilisateur_pk.Location = new System.Drawing.Point(0, 0);
            this.ItemFornom_utilisateur_pk.Name = "ItemFornom_utilisateur_pk";
            this.ItemFornom_utilisateur_pk.Size = new System.Drawing.Size(759, 40);
            this.ItemFornom_utilisateur_pk.Text = "Nom d\'utilisateur";
            this.ItemFornom_utilisateur_pk.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemFornom_utilisateur_pk.TextSize = new System.Drawing.Size(202, 13);
            // 
            // ItemFormot_passe_utilisateur
            // 
            this.ItemFormot_passe_utilisateur.Control = this.mot_passe_utilisateurTextEdit;
            this.ItemFormot_passe_utilisateur.Location = new System.Drawing.Point(0, 40);
            this.ItemFormot_passe_utilisateur.Name = "ItemFormot_passe_utilisateur";
            this.ItemFormot_passe_utilisateur.Size = new System.Drawing.Size(759, 40);
            this.ItemFormot_passe_utilisateur.Text = "Mot de passe";
            this.ItemFormot_passe_utilisateur.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemFormot_passe_utilisateur.TextSize = new System.Drawing.Size(202, 13);
            // 
            // ItemForrole_utilisateur
            // 
            this.ItemForrole_utilisateur.Control = this.role_utilisateurComboBoxEdit;
            this.ItemForrole_utilisateur.Location = new System.Drawing.Point(0, 80);
            this.ItemForrole_utilisateur.Name = "ItemForrole_utilisateur";
            this.ItemForrole_utilisateur.Size = new System.Drawing.Size(759, 40);
            this.ItemForrole_utilisateur.Text = "Rôle";
            this.ItemForrole_utilisateur.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForrole_utilisateur.TextSize = new System.Drawing.Size(202, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForid_employe_fk});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(759, 261);
            this.layoutControlGroup4.Text = "Propriété";
            // 
            // Utilisateurs_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.detailManagementControl1);
            this.Name = "Utilisateurs_Detail";
            this.Text = "Utilisateurs_Detail";
            this.detailManagementControl1.ResumeLayout(false);
            this.detailManagementControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom_utilisateur_pkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mot_passe_utilisateurTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_utilisateurComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_employe_fkGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForid_employe_fk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_heure_derniere_connexion_utilisaturDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_heure_derniere_connexion_utilisaturDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFordate_heure_derniere_connexion_utilisatur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom_utilisateur_pk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormot_passe_utilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForrole_utilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.DetailManagementControl detailManagementControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit nom_utilisateur_pkTextEdit;
        private DevExpress.XtraEditors.TextEdit mot_passe_utilisateurTextEdit;
        private DevExpress.XtraEditors.ComboBoxEdit role_utilisateurComboBoxEdit;
        private DevExpress.XtraEditors.GridLookUpEdit id_employe_fkGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit date_heure_derniere_connexion_utilisaturDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForid_employe_fk;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornom_utilisateur_pk;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormot_passe_utilisateur;
        private DevExpress.XtraLayout.LayoutControlItem ItemForrole_utilisateur;
        private DevExpress.XtraLayout.LayoutControlItem ItemFordate_heure_derniere_connexion_utilisatur;
    }
}