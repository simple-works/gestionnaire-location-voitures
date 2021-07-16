namespace Car_Rental_Project.GUI.Gestion
{
    partial class Agences_Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agences_Collection));
            this.collectionManagementControl1 = new Car_Rental_Project.GUI.UC.CollectionManagementControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_agence_pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphoto_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_creation_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresse_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colville_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_postal_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelephone_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfax_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail_agence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collien_Web_agence = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.collectionManagementControl1.Size = new System.Drawing.Size(870, 482);
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
            this.gridControl1.DataMember = "agence";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(870, 482);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_agence_pk";
            table1.MetaSerializable = "30|30|125|349";
            table1.Name = "agence";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "photo_agence";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "nom_agence";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "description_agence";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "date_creation_agence";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "adresse_agence";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ville_agence";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "code_postal_agence";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "telephone_agence";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "fax_agence";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "email_agence";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "lien_Web_agence";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
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
            selectQuery1.Name = "agence";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_agence_pk,
            this.colphoto_agence,
            this.colnom_agence,
            this.coldescription_agence,
            this.coldate_creation_agence,
            this.coladresse_agence,
            this.colville_agence,
            this.colcode_postal_agence,
            this.coltelephone_agence,
            this.colfax_agence,
            this.colemail_agence,
            this.collien_Web_agence});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_agence_pk
            // 
            this.colid_agence_pk.FieldName = "id_agence_pk";
            this.colid_agence_pk.Name = "colid_agence_pk";
            this.colid_agence_pk.Visible = true;
            this.colid_agence_pk.VisibleIndex = 0;
            // 
            // colphoto_agence
            // 
            this.colphoto_agence.FieldName = "photo_agence";
            this.colphoto_agence.Name = "colphoto_agence";
            this.colphoto_agence.Visible = true;
            this.colphoto_agence.VisibleIndex = 1;
            // 
            // colnom_agence
            // 
            this.colnom_agence.FieldName = "nom_agence";
            this.colnom_agence.Name = "colnom_agence";
            this.colnom_agence.Visible = true;
            this.colnom_agence.VisibleIndex = 2;
            // 
            // coldescription_agence
            // 
            this.coldescription_agence.FieldName = "description_agence";
            this.coldescription_agence.Name = "coldescription_agence";
            this.coldescription_agence.Visible = true;
            this.coldescription_agence.VisibleIndex = 3;
            // 
            // coldate_creation_agence
            // 
            this.coldate_creation_agence.FieldName = "date_creation_agence";
            this.coldate_creation_agence.Name = "coldate_creation_agence";
            this.coldate_creation_agence.Visible = true;
            this.coldate_creation_agence.VisibleIndex = 4;
            // 
            // coladresse_agence
            // 
            this.coladresse_agence.FieldName = "adresse_agence";
            this.coladresse_agence.Name = "coladresse_agence";
            this.coladresse_agence.Visible = true;
            this.coladresse_agence.VisibleIndex = 5;
            // 
            // colville_agence
            // 
            this.colville_agence.FieldName = "ville_agence";
            this.colville_agence.Name = "colville_agence";
            this.colville_agence.Visible = true;
            this.colville_agence.VisibleIndex = 6;
            // 
            // colcode_postal_agence
            // 
            this.colcode_postal_agence.FieldName = "code_postal_agence";
            this.colcode_postal_agence.Name = "colcode_postal_agence";
            this.colcode_postal_agence.Visible = true;
            this.colcode_postal_agence.VisibleIndex = 7;
            // 
            // coltelephone_agence
            // 
            this.coltelephone_agence.FieldName = "telephone_agence";
            this.coltelephone_agence.Name = "coltelephone_agence";
            this.coltelephone_agence.Visible = true;
            this.coltelephone_agence.VisibleIndex = 8;
            // 
            // colfax_agence
            // 
            this.colfax_agence.FieldName = "fax_agence";
            this.colfax_agence.Name = "colfax_agence";
            this.colfax_agence.Visible = true;
            this.colfax_agence.VisibleIndex = 9;
            // 
            // colemail_agence
            // 
            this.colemail_agence.FieldName = "email_agence";
            this.colemail_agence.Name = "colemail_agence";
            this.colemail_agence.Visible = true;
            this.colemail_agence.VisibleIndex = 10;
            // 
            // collien_Web_agence
            // 
            this.collien_Web_agence.FieldName = "lien_Web_agence";
            this.collien_Web_agence.Name = "collien_Web_agence";
            this.collien_Web_agence.Visible = true;
            this.collien_Web_agence.VisibleIndex = 11;
            // 
            // Agences_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 482);
            this.Controls.Add(this.collectionManagementControl1);
            this.Name = "Agences_Collection";
            this.Text = "Agences";
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_agence_pk;
        private DevExpress.XtraGrid.Columns.GridColumn colphoto_agence;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_agence;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription_agence;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_creation_agence;
        private DevExpress.XtraGrid.Columns.GridColumn coladresse_agence;
        private DevExpress.XtraGrid.Columns.GridColumn colville_agence;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_postal_agence;
        private DevExpress.XtraGrid.Columns.GridColumn coltelephone_agence;
        private DevExpress.XtraGrid.Columns.GridColumn colfax_agence;
        private DevExpress.XtraGrid.Columns.GridColumn colemail_agence;
        private DevExpress.XtraGrid.Columns.GridColumn collien_Web_agence;
    }
}