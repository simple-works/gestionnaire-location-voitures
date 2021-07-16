namespace Car_Rental_Project.GUI.Gestion
{
    partial class Utilisateurs_Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateurs_Collection));
            this.collectionManagementControl1 = new Car_Rental_Project.GUI.UC.CollectionManagementControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_utilisateur_pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmot_passe_utilisateur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrole_utilisateur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employe_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_heure_derniere_connexion_utilisatur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collectionManagementControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // collectionManagementControl1
            // 
            this.collectionManagementControl1.Controls.Add(this.gridControl1);
            this.collectionManagementControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionManagementControl1.Location = new System.Drawing.Point(0, 0);
            this.collectionManagementControl1.Name = "collectionManagementControl1";
            this.collectionManagementControl1.Size = new System.Drawing.Size(816, 501);
            this.collectionManagementControl1.TabIndex = 0;
            this.collectionManagementControl1.Nouveau += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Nouveau);
            this.collectionManagementControl1.Editer += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Editer);
            this.collectionManagementControl1.Supprimer += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Supprimer);
            this.collectionManagementControl1.Actualiser += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Actualiser);
            this.collectionManagementControl1.Apercu_Avant_Impression += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Apercu_Avant_Impression);
            this.collectionManagementControl1.Fermer += new DevExpress.XtraBars.ItemClickEventHandler(this.collectionManagementControl1_Fermer);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "utilisateur";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(816, 501);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "nom_utilisateur_pk";
            table1.MetaSerializable = "30|30|125|216";
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_utilisateur_pk,
            this.colmot_passe_utilisateur,
            this.colrole_utilisateur,
            this.colid_employe_fk,
            this.coldate_heure_derniere_connexion_utilisatur});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colnom_utilisateur_pk
            // 
            this.colnom_utilisateur_pk.FieldName = "nom_utilisateur_pk";
            this.colnom_utilisateur_pk.Name = "colnom_utilisateur_pk";
            this.colnom_utilisateur_pk.Visible = true;
            this.colnom_utilisateur_pk.VisibleIndex = 0;
            // 
            // colmot_passe_utilisateur
            // 
            this.colmot_passe_utilisateur.FieldName = "mot_passe_utilisateur";
            this.colmot_passe_utilisateur.Name = "colmot_passe_utilisateur";
            this.colmot_passe_utilisateur.Visible = true;
            this.colmot_passe_utilisateur.VisibleIndex = 1;
            // 
            // colrole_utilisateur
            // 
            this.colrole_utilisateur.FieldName = "role_utilisateur";
            this.colrole_utilisateur.Name = "colrole_utilisateur";
            this.colrole_utilisateur.Visible = true;
            this.colrole_utilisateur.VisibleIndex = 2;
            // 
            // colid_employe_fk
            // 
            this.colid_employe_fk.FieldName = "id_employe_fk";
            this.colid_employe_fk.Name = "colid_employe_fk";
            this.colid_employe_fk.Visible = true;
            this.colid_employe_fk.VisibleIndex = 3;
            // 
            // coldate_heure_derniere_connexion_utilisatur
            // 
            this.coldate_heure_derniere_connexion_utilisatur.FieldName = "date_heure_derniere_connexion_utilisatur";
            this.coldate_heure_derniere_connexion_utilisatur.Name = "coldate_heure_derniere_connexion_utilisatur";
            this.coldate_heure_derniere_connexion_utilisatur.Visible = true;
            this.coldate_heure_derniere_connexion_utilisatur.VisibleIndex = 4;
            // 
            // Utilisateurs_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 501);
            this.Controls.Add(this.collectionManagementControl1);
            this.Name = "Utilisateurs_Collection";
            this.Text = "Utilisateurs_Collection";
            this.collectionManagementControl1.ResumeLayout(false);
            this.collectionManagementControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UC.CollectionManagementControl collectionManagementControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_utilisateur_pk;
        private DevExpress.XtraGrid.Columns.GridColumn colmot_passe_utilisateur;
        private DevExpress.XtraGrid.Columns.GridColumn colrole_utilisateur;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employe_fk;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_heure_derniere_connexion_utilisatur;
    }
}