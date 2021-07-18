namespace Car_Rental_Project.GUI.Gestion
{
    partial class Vehicules_Collection
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
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicules_Collection));
            this.collectionManagementControl1 = new Car_Rental_Project.GUI.UC.CollectionManagementControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colimmatriculation_vehicule_pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphoto_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarque_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldistance_parcourue_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_energie_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite_energie_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprix_location_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_achat_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_derniere_maintenance_vehicule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_agence_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_parc_fk = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.collectionManagementControl1.Size = new System.Drawing.Size(812, 510);
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
            this.gridControl1.DataMember = "vehicule";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(812, 510);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "immatriculation_vehicule_pk";
            table1.MetaSerializable = "30|30|125|368";
            table1.Name = "vehicule";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "photo_vehicule";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "type_vehicule";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "marque_vehicule";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "description_vehicule";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "distance_parcourue_vehicule";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "type_energie_vehicule";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "quantite_energie_vehicule";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "prix_location_vehicule";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "date_achat_vehicule";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "date_derniere_maintenance_vehicule";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "id_agence_fk";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "id_parc_fk";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Name = "vehicule";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colimmatriculation_vehicule_pk,
            this.colphoto_vehicule,
            this.coltype_vehicule,
            this.colmarque_vehicule,
            this.coldescription_vehicule,
            this.coldistance_parcourue_vehicule,
            this.coltype_energie_vehicule,
            this.colquantite_energie_vehicule,
            this.colprix_location_vehicule,
            this.coldate_achat_vehicule,
            this.coldate_derniere_maintenance_vehicule,
            this.colid_agence_fk,
            this.colid_parc_fk});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colimmatriculation_vehicule_pk
            // 
            this.colimmatriculation_vehicule_pk.FieldName = "immatriculation_vehicule_pk";
            this.colimmatriculation_vehicule_pk.Name = "colimmatriculation_vehicule_pk";
            this.colimmatriculation_vehicule_pk.Visible = true;
            this.colimmatriculation_vehicule_pk.VisibleIndex = 0;
            // 
            // colphoto_vehicule
            // 
            this.colphoto_vehicule.FieldName = "photo_vehicule";
            this.colphoto_vehicule.Name = "colphoto_vehicule";
            this.colphoto_vehicule.Visible = true;
            this.colphoto_vehicule.VisibleIndex = 1;
            // 
            // coltype_vehicule
            // 
            this.coltype_vehicule.FieldName = "type_vehicule";
            this.coltype_vehicule.Name = "coltype_vehicule";
            this.coltype_vehicule.Visible = true;
            this.coltype_vehicule.VisibleIndex = 2;
            // 
            // colmarque_vehicule
            // 
            this.colmarque_vehicule.FieldName = "marque_vehicule";
            this.colmarque_vehicule.Name = "colmarque_vehicule";
            this.colmarque_vehicule.Visible = true;
            this.colmarque_vehicule.VisibleIndex = 3;
            // 
            // coldescription_vehicule
            // 
            this.coldescription_vehicule.FieldName = "description_vehicule";
            this.coldescription_vehicule.Name = "coldescription_vehicule";
            this.coldescription_vehicule.Visible = true;
            this.coldescription_vehicule.VisibleIndex = 4;
            // 
            // coldistance_parcourue_vehicule
            // 
            this.coldistance_parcourue_vehicule.FieldName = "distance_parcourue_vehicule";
            this.coldistance_parcourue_vehicule.Name = "coldistance_parcourue_vehicule";
            this.coldistance_parcourue_vehicule.Visible = true;
            this.coldistance_parcourue_vehicule.VisibleIndex = 5;
            // 
            // coltype_energie_vehicule
            // 
            this.coltype_energie_vehicule.FieldName = "type_energie_vehicule";
            this.coltype_energie_vehicule.Name = "coltype_energie_vehicule";
            this.coltype_energie_vehicule.Visible = true;
            this.coltype_energie_vehicule.VisibleIndex = 6;
            // 
            // colquantite_energie_vehicule
            // 
            this.colquantite_energie_vehicule.FieldName = "quantite_energie_vehicule";
            this.colquantite_energie_vehicule.Name = "colquantite_energie_vehicule";
            this.colquantite_energie_vehicule.Visible = true;
            this.colquantite_energie_vehicule.VisibleIndex = 7;
            // 
            // colprix_location_vehicule
            // 
            this.colprix_location_vehicule.FieldName = "prix_location_vehicule";
            this.colprix_location_vehicule.Name = "colprix_location_vehicule";
            this.colprix_location_vehicule.Visible = true;
            this.colprix_location_vehicule.VisibleIndex = 8;
            // 
            // coldate_achat_vehicule
            // 
            this.coldate_achat_vehicule.FieldName = "date_achat_vehicule";
            this.coldate_achat_vehicule.Name = "coldate_achat_vehicule";
            this.coldate_achat_vehicule.Visible = true;
            this.coldate_achat_vehicule.VisibleIndex = 9;
            // 
            // coldate_derniere_maintenance_vehicule
            // 
            this.coldate_derniere_maintenance_vehicule.FieldName = "date_derniere_maintenance_vehicule";
            this.coldate_derniere_maintenance_vehicule.Name = "coldate_derniere_maintenance_vehicule";
            this.coldate_derniere_maintenance_vehicule.Visible = true;
            this.coldate_derniere_maintenance_vehicule.VisibleIndex = 10;
            // 
            // colid_agence_fk
            // 
            this.colid_agence_fk.FieldName = "id_agence_fk";
            this.colid_agence_fk.Name = "colid_agence_fk";
            this.colid_agence_fk.Visible = true;
            this.colid_agence_fk.VisibleIndex = 11;
            // 
            // colid_parc_fk
            // 
            this.colid_parc_fk.FieldName = "id_parc_fk";
            this.colid_parc_fk.Name = "colid_parc_fk";
            this.colid_parc_fk.Visible = true;
            this.colid_parc_fk.VisibleIndex = 12;
            // 
            // Vehicules_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 510);
            this.Controls.Add(this.collectionManagementControl1);
            this.Name = "Vehicules_Collection";
            this.Text = "Vehicules_Collection";
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
        private DevExpress.XtraGrid.Columns.GridColumn colimmatriculation_vehicule_pk;
        private DevExpress.XtraGrid.Columns.GridColumn colphoto_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn colmarque_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coldistance_parcourue_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_energie_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite_energie_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn colprix_location_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_achat_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_derniere_maintenance_vehicule;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agence_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colid_parc_fk;
    }
}