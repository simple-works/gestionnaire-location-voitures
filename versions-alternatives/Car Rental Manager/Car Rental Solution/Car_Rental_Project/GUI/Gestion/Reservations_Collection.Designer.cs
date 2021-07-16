namespace Car_Rental_Project.GUI.Gestion
{
    partial class Reservations_Collection
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
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations_Collection));
            this.collectionManagementControl1 = new Car_Rental_Project.GUI.UC.CollectionManagementControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_client_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimmatriculation_vehicule_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_client_compagnon_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_employe_conducteur_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription_equipements_speciaux_contrat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_heure_depart_vehicule_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_heure_retour_vehicule_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_agence_depart_reservation_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_agence_retour_reservation_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collieu_depart_vehicule_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collieu_retour_vehicule_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrais_conducteur_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrais_equipements_speciaux_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontant_forfait_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontant_remise_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmode_paiement_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_utilisateur_commentateur_reservation_fk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcommentaire_reservation = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.collectionManagementControl1.Size = new System.Drawing.Size(769, 500);
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
            this.gridControl1.DataMember = "reservation";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(769, 500);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Car_Rental_Project.Properties.Settings.ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "id_reservation";
            table1.MetaSerializable = "30|30|125|482";
            table1.Name = "reservation";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "id_client_fk";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "immatriculation_vehicule_fk";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "id_client_compagnon_fk";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "id_employe_conducteur_fk";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "description_equipements_speciaux_contrat";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "date_heure_depart_vehicule_reservation";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "date_heure_retour_vehicule_reservation";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "id_agence_depart_reservation_fk";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "id_agence_retour_reservation_fk";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "lieu_depart_vehicule_reservation";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "lieu_retour_vehicule_reservation";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "frais_conducteur_reservation";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "frais_equipements_speciaux_reservation";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "montant_forfait_reservation";
            columnExpression15.Table = table1;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "montant_remise_reservation";
            columnExpression16.Table = table1;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "mode_paiement_reservation";
            columnExpression17.Table = table1;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "nom_utilisateur_commentateur_reservation_fk";
            columnExpression18.Table = table1;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "commentaire_reservation";
            columnExpression19.Table = table1;
            column19.Expression = columnExpression19;
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
            selectQuery1.Columns.Add(column14);
            selectQuery1.Columns.Add(column15);
            selectQuery1.Columns.Add(column16);
            selectQuery1.Columns.Add(column17);
            selectQuery1.Columns.Add(column18);
            selectQuery1.Columns.Add(column19);
            selectQuery1.Name = "reservation";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_reservation,
            this.colid_client_fk,
            this.colimmatriculation_vehicule_fk,
            this.colid_client_compagnon_fk,
            this.colid_employe_conducteur_fk,
            this.coldescription_equipements_speciaux_contrat,
            this.coldate_heure_depart_vehicule_reservation,
            this.coldate_heure_retour_vehicule_reservation,
            this.colid_agence_depart_reservation_fk,
            this.colid_agence_retour_reservation_fk,
            this.collieu_depart_vehicule_reservation,
            this.collieu_retour_vehicule_reservation,
            this.colfrais_conducteur_reservation,
            this.colfrais_equipements_speciaux_reservation,
            this.colmontant_forfait_reservation,
            this.colmontant_remise_reservation,
            this.colmode_paiement_reservation,
            this.colnom_utilisateur_commentateur_reservation_fk,
            this.colcommentaire_reservation});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid_reservation
            // 
            this.colid_reservation.FieldName = "id_reservation";
            this.colid_reservation.Name = "colid_reservation";
            this.colid_reservation.Visible = true;
            this.colid_reservation.VisibleIndex = 0;
            // 
            // colid_client_fk
            // 
            this.colid_client_fk.FieldName = "id_client_fk";
            this.colid_client_fk.Name = "colid_client_fk";
            this.colid_client_fk.Visible = true;
            this.colid_client_fk.VisibleIndex = 1;
            // 
            // colimmatriculation_vehicule_fk
            // 
            this.colimmatriculation_vehicule_fk.FieldName = "immatriculation_vehicule_fk";
            this.colimmatriculation_vehicule_fk.Name = "colimmatriculation_vehicule_fk";
            this.colimmatriculation_vehicule_fk.Visible = true;
            this.colimmatriculation_vehicule_fk.VisibleIndex = 2;
            // 
            // colid_client_compagnon_fk
            // 
            this.colid_client_compagnon_fk.FieldName = "id_client_compagnon_fk";
            this.colid_client_compagnon_fk.Name = "colid_client_compagnon_fk";
            this.colid_client_compagnon_fk.Visible = true;
            this.colid_client_compagnon_fk.VisibleIndex = 3;
            // 
            // colid_employe_conducteur_fk
            // 
            this.colid_employe_conducteur_fk.FieldName = "id_employe_conducteur_fk";
            this.colid_employe_conducteur_fk.Name = "colid_employe_conducteur_fk";
            this.colid_employe_conducteur_fk.Visible = true;
            this.colid_employe_conducteur_fk.VisibleIndex = 4;
            // 
            // coldescription_equipements_speciaux_contrat
            // 
            this.coldescription_equipements_speciaux_contrat.FieldName = "description_equipements_speciaux_contrat";
            this.coldescription_equipements_speciaux_contrat.Name = "coldescription_equipements_speciaux_contrat";
            this.coldescription_equipements_speciaux_contrat.Visible = true;
            this.coldescription_equipements_speciaux_contrat.VisibleIndex = 5;
            // 
            // coldate_heure_depart_vehicule_reservation
            // 
            this.coldate_heure_depart_vehicule_reservation.FieldName = "date_heure_depart_vehicule_reservation";
            this.coldate_heure_depart_vehicule_reservation.Name = "coldate_heure_depart_vehicule_reservation";
            this.coldate_heure_depart_vehicule_reservation.Visible = true;
            this.coldate_heure_depart_vehicule_reservation.VisibleIndex = 6;
            // 
            // coldate_heure_retour_vehicule_reservation
            // 
            this.coldate_heure_retour_vehicule_reservation.FieldName = "date_heure_retour_vehicule_reservation";
            this.coldate_heure_retour_vehicule_reservation.Name = "coldate_heure_retour_vehicule_reservation";
            this.coldate_heure_retour_vehicule_reservation.Visible = true;
            this.coldate_heure_retour_vehicule_reservation.VisibleIndex = 7;
            // 
            // colid_agence_depart_reservation_fk
            // 
            this.colid_agence_depart_reservation_fk.FieldName = "id_agence_depart_reservation_fk";
            this.colid_agence_depart_reservation_fk.Name = "colid_agence_depart_reservation_fk";
            this.colid_agence_depart_reservation_fk.Visible = true;
            this.colid_agence_depart_reservation_fk.VisibleIndex = 8;
            // 
            // colid_agence_retour_reservation_fk
            // 
            this.colid_agence_retour_reservation_fk.FieldName = "id_agence_retour_reservation_fk";
            this.colid_agence_retour_reservation_fk.Name = "colid_agence_retour_reservation_fk";
            this.colid_agence_retour_reservation_fk.Visible = true;
            this.colid_agence_retour_reservation_fk.VisibleIndex = 9;
            // 
            // collieu_depart_vehicule_reservation
            // 
            this.collieu_depart_vehicule_reservation.FieldName = "lieu_depart_vehicule_reservation";
            this.collieu_depart_vehicule_reservation.Name = "collieu_depart_vehicule_reservation";
            this.collieu_depart_vehicule_reservation.Visible = true;
            this.collieu_depart_vehicule_reservation.VisibleIndex = 10;
            // 
            // collieu_retour_vehicule_reservation
            // 
            this.collieu_retour_vehicule_reservation.FieldName = "lieu_retour_vehicule_reservation";
            this.collieu_retour_vehicule_reservation.Name = "collieu_retour_vehicule_reservation";
            this.collieu_retour_vehicule_reservation.Visible = true;
            this.collieu_retour_vehicule_reservation.VisibleIndex = 11;
            // 
            // colfrais_conducteur_reservation
            // 
            this.colfrais_conducteur_reservation.FieldName = "frais_conducteur_reservation";
            this.colfrais_conducteur_reservation.Name = "colfrais_conducteur_reservation";
            this.colfrais_conducteur_reservation.Visible = true;
            this.colfrais_conducteur_reservation.VisibleIndex = 12;
            // 
            // colfrais_equipements_speciaux_reservation
            // 
            this.colfrais_equipements_speciaux_reservation.FieldName = "frais_equipements_speciaux_reservation";
            this.colfrais_equipements_speciaux_reservation.Name = "colfrais_equipements_speciaux_reservation";
            this.colfrais_equipements_speciaux_reservation.Visible = true;
            this.colfrais_equipements_speciaux_reservation.VisibleIndex = 13;
            // 
            // colmontant_forfait_reservation
            // 
            this.colmontant_forfait_reservation.FieldName = "montant_forfait_reservation";
            this.colmontant_forfait_reservation.Name = "colmontant_forfait_reservation";
            this.colmontant_forfait_reservation.Visible = true;
            this.colmontant_forfait_reservation.VisibleIndex = 14;
            // 
            // colmontant_remise_reservation
            // 
            this.colmontant_remise_reservation.FieldName = "montant_remise_reservation";
            this.colmontant_remise_reservation.Name = "colmontant_remise_reservation";
            this.colmontant_remise_reservation.Visible = true;
            this.colmontant_remise_reservation.VisibleIndex = 15;
            // 
            // colmode_paiement_reservation
            // 
            this.colmode_paiement_reservation.FieldName = "mode_paiement_reservation";
            this.colmode_paiement_reservation.Name = "colmode_paiement_reservation";
            this.colmode_paiement_reservation.Visible = true;
            this.colmode_paiement_reservation.VisibleIndex = 16;
            // 
            // colnom_utilisateur_commentateur_reservation_fk
            // 
            this.colnom_utilisateur_commentateur_reservation_fk.FieldName = "nom_utilisateur_commentateur_reservation_fk";
            this.colnom_utilisateur_commentateur_reservation_fk.Name = "colnom_utilisateur_commentateur_reservation_fk";
            this.colnom_utilisateur_commentateur_reservation_fk.Visible = true;
            this.colnom_utilisateur_commentateur_reservation_fk.VisibleIndex = 17;
            // 
            // colcommentaire_reservation
            // 
            this.colcommentaire_reservation.FieldName = "commentaire_reservation";
            this.colcommentaire_reservation.Name = "colcommentaire_reservation";
            this.colcommentaire_reservation.Visible = true;
            this.colcommentaire_reservation.VisibleIndex = 18;
            // 
            // Reservations_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 500);
            this.Controls.Add(this.collectionManagementControl1);
            this.Name = "Reservations_Collection";
            this.Text = "Reservations_Collection";
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
        private DevExpress.XtraGrid.Columns.GridColumn colid_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colid_client_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colimmatriculation_vehicule_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colid_client_compagnon_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colid_employe_conducteur_fk;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription_equipements_speciaux_contrat;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_heure_depart_vehicule_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_heure_retour_vehicule_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agence_depart_reservation_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colid_agence_retour_reservation_fk;
        private DevExpress.XtraGrid.Columns.GridColumn collieu_depart_vehicule_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn collieu_retour_vehicule_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colfrais_conducteur_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colfrais_equipements_speciaux_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colmontant_forfait_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colmontant_remise_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colmode_paiement_reservation;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_utilisateur_commentateur_reservation_fk;
        private DevExpress.XtraGrid.Columns.GridColumn colcommentaire_reservation;
    }
}