namespace Car_Rental_Project.GUI.Gestion
{
    partial class Parcs_Collection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parcs_Collection));
            this.collectionManagementControl1 = new Car_Rental_Project.GUI.UC.CollectionManagementControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_parc_pk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphoto_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_creation_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresse_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colville_parc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode_postal_parc = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.collectionManagementControl1.Size = new System.Drawing.Size(789, 500);
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
            this.gridControl1.DataMember = "parc";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(789, 500);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_parc_pk";
            table1.MetaSerializable = "30|30|125|273";
            table1.Name = "parc";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "photo_parc";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "nom_parc";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "description_parc";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "date_creation_parc";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "adresse_parc";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ville_parc";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "code_postal_parc";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "parc";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_parc_pk,
            this.colphoto_parc,
            this.colnom_parc,
            this.coldescription_parc,
            this.coldate_creation_parc,
            this.coladresse_parc,
            this.colville_parc,
            this.colcode_postal_parc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_parc_pk
            // 
            this.colid_parc_pk.FieldName = "id_parc_pk";
            this.colid_parc_pk.Name = "colid_parc_pk";
            this.colid_parc_pk.Visible = true;
            this.colid_parc_pk.VisibleIndex = 0;
            // 
            // colphoto_parc
            // 
            this.colphoto_parc.FieldName = "photo_parc";
            this.colphoto_parc.Name = "colphoto_parc";
            this.colphoto_parc.Visible = true;
            this.colphoto_parc.VisibleIndex = 1;
            // 
            // colnom_parc
            // 
            this.colnom_parc.FieldName = "nom_parc";
            this.colnom_parc.Name = "colnom_parc";
            this.colnom_parc.Visible = true;
            this.colnom_parc.VisibleIndex = 2;
            // 
            // coldescription_parc
            // 
            this.coldescription_parc.FieldName = "description_parc";
            this.coldescription_parc.Name = "coldescription_parc";
            this.coldescription_parc.Visible = true;
            this.coldescription_parc.VisibleIndex = 3;
            // 
            // coldate_creation_parc
            // 
            this.coldate_creation_parc.FieldName = "date_creation_parc";
            this.coldate_creation_parc.Name = "coldate_creation_parc";
            this.coldate_creation_parc.Visible = true;
            this.coldate_creation_parc.VisibleIndex = 4;
            // 
            // coladresse_parc
            // 
            this.coladresse_parc.FieldName = "adresse_parc";
            this.coladresse_parc.Name = "coladresse_parc";
            this.coladresse_parc.Visible = true;
            this.coladresse_parc.VisibleIndex = 5;
            // 
            // colville_parc
            // 
            this.colville_parc.FieldName = "ville_parc";
            this.colville_parc.Name = "colville_parc";
            this.colville_parc.Visible = true;
            this.colville_parc.VisibleIndex = 6;
            // 
            // colcode_postal_parc
            // 
            this.colcode_postal_parc.FieldName = "code_postal_parc";
            this.colcode_postal_parc.Name = "colcode_postal_parc";
            this.colcode_postal_parc.Visible = true;
            this.colcode_postal_parc.VisibleIndex = 7;
            // 
            // Parcs_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.collectionManagementControl1);
            this.Name = "Parcs_Collection";
            this.Text = "Parcs_Collection";
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_parc_pk;
        private DevExpress.XtraGrid.Columns.GridColumn colphoto_parc;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_parc;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription_parc;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_creation_parc;
        private DevExpress.XtraGrid.Columns.GridColumn coladresse_parc;
        private DevExpress.XtraGrid.Columns.GridColumn colville_parc;
        private DevExpress.XtraGrid.Columns.GridColumn colcode_postal_parc;
    }
}