using System;
using System.Data;
using System.Windows.Forms;

namespace Car_Rental_Project.GUI.Gestion
{
    public partial class Agences_Detail : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionAgences = new DAI.DataManagement(DAI.DataDescription.Tables.Agence);
        private DataRow rowToUpdate;
        private bool editControlValueChanged = false;
        public Agences_Detail()
        {
            try
            {
                InitializeComponent();
                gestionAgences.SetAutoIncrement(0);
                API.Controller.CreateEditControlsEventsWithinLayout(dataLayoutControl1, editControl_EditValueChanged);
                ville_agenceComboBoxEdit.Properties.Items.AddRange(API.List.VillesMaroc);
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        /// <summary>
        /// Remplit les contôles d'édition à partir des valeurs des cellues de la ligne 
        /// actuellement sélectionné dans la grille (GridView).
        /// </summary>
        /// <param name="gridView">Grille source des données</param>
        public void FillEditControlsFromGridViewFocusedRow(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            rowToUpdate = gestionAgences.Table.Rows.Find(API.Controller.GetGridViewFocusedRowValue(gridView, "id_agence_pk"));
            FillEditControls();
            editControlValueChanged = false;
        }

        public void FillEditControls()
        {
            if (rowToUpdate != null)
            {
                id_agence_pkTextEdit.EditValue = rowToUpdate["id_agence_pk"];
                photo_agencePictureEdit.EditValue = rowToUpdate["photo_agence"];
                nom_agenceTextEdit.EditValue = rowToUpdate["nom_agence"];
                description_agenceMemoEdit.EditValue = rowToUpdate["description_agence"];
                date_creation_agenceDateEdit.EditValue = rowToUpdate["date_creation_agence"];
                adresse_agenceMemoEdit.EditValue = rowToUpdate["adresse_agence"];
                ville_agenceComboBoxEdit.EditValue = rowToUpdate["ville_agence"];
                code_postal_agenceTextEdit.EditValue = rowToUpdate["code_postal_agence"];
                telephone_agenceTextEdit.EditValue = rowToUpdate["telephone_agence"];
                fax_agenceTextEdit.EditValue = rowToUpdate["fax_agence"];
                email_agenceHyperLinkEdit.EditValue = rowToUpdate["email_agence"];
                lien_Web_agenceHyperLinkEdit.EditValue = rowToUpdate["lien_Web_agence"];
            }
        }

        public void FillRowToUpdate()
        {
            if (rowToUpdate == null)
            {
                rowToUpdate = gestionAgences.Table.NewRow();
                rowToUpdate["id_agence_pk"] = id_agence_pkTextEdit.EditValue;
                rowToUpdate["photo_agence"] = API.Picture.ImageToByteArray(photo_agencePictureEdit.Image);
                rowToUpdate["nom_agence"] = nom_agenceTextEdit.EditValue;
                rowToUpdate["description_agence"] = description_agenceMemoEdit.EditValue;
                rowToUpdate["date_creation_agence"] = date_creation_agenceDateEdit.EditValue;
                rowToUpdate["adresse_agence"] = adresse_agenceMemoEdit.EditValue;
                rowToUpdate["ville_agence"] = ville_agenceComboBoxEdit.EditValue;
                rowToUpdate["code_postal_agence"] = code_postal_agenceTextEdit.EditValue;
                rowToUpdate["telephone_agence"] = telephone_agenceTextEdit.EditValue;
                rowToUpdate["fax_agence"] = fax_agenceTextEdit.EditValue;
                rowToUpdate["email_agence"] = email_agenceHyperLinkEdit.EditValue;
                rowToUpdate["lien_Web_agence"] = lien_Web_agenceHyperLinkEdit.EditValue;
            }
        }

        private void Agences_Detail_Load(object sender, EventArgs e)
        {
            try
            {
                if (rowToUpdate != null)
                {
                    string id = rowToUpdate[0].ToString();
                    string title = rowToUpdate["nom_agence"].ToString();
                    Text += string.Format(" ({0} - {1})", id, title);
                }
                else
                {
                    Text += " (Nouveau)";
                    id_agence_pkTextEdit.EditValue = Convert.ToInt64(gestionAgences.GetLastRowCellValue(0)) + 1;
                    editControlValueChanged = false;
                }
                nom_agenceTextEdit.Select();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void editControl_EditValueChanged(object sender, EventArgs e)
        {
            
            try
            {
                editControlValueChanged = true;
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
        private bool detailManagementControl1_Enregistrer()
        {
            if (dxValidationProvider1.Validate())
            {
                if (rowToUpdate != null)
                {
                    gestionAgences.Update(
                        id_agence_pkTextEdit.EditValue,
                        API.Picture.ImageToByteArray(photo_agencePictureEdit.Image),
                        nom_agenceTextEdit.EditValue,
                        description_agenceMemoEdit.EditValue,
                        date_creation_agenceDateEdit.EditValue,
                        adresse_agenceMemoEdit.EditValue,
                        ville_agenceComboBoxEdit.EditValue,
                        code_postal_agenceTextEdit.EditValue,
                        telephone_agenceTextEdit.EditValue,
                        fax_agenceTextEdit.EditValue,
                        email_agenceHyperLinkEdit.EditValue,
                        lien_Web_agenceHyperLinkEdit.EditValue
                    );
                }
                else
                {
                    gestionAgences.Insert(
                        null,
                        API.Picture.ImageToByteArray(photo_agencePictureEdit.Image),
                        nom_agenceTextEdit.EditValue,
                        description_agenceMemoEdit.EditValue,
                        date_creation_agenceDateEdit.EditValue,
                        adresse_agenceMemoEdit.EditValue,
                        ville_agenceComboBoxEdit.EditValue,
                        code_postal_agenceTextEdit.EditValue,
                        telephone_agenceTextEdit.EditValue,
                        fax_agenceTextEdit.EditValue,
                        email_agenceHyperLinkEdit.EditValue,
                        lien_Web_agenceHyperLinkEdit.EditValue
                    );
                    FillRowToUpdate();
                }
                gestionAgences.Save();
                editControlValueChanged = false;
                Program.MainForm.Agences_Collection_Instance.InitializeGrid();
            }
            else
            {
                API.Message.Exclamation(@"Certains champs semblent contenir des données invalides.\nVeuillez vérifier que les informations entrées sont correcte.", "Validation");
            }
            return dxValidationProvider1.Validate();
        }
        private void detailManagementControl1_Enregistrer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                detailManagementControl1_Enregistrer();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void detailManagementControl1_Enregistrer_Et_Fermer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (detailManagementControl1_Enregistrer())
                    Close();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void detailManagementControl1_Enregistrer_Et_Nouveau(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (detailManagementControl1_Enregistrer())
                {
                    API.Controller.ClearEditControlsWithinLayout(dataLayoutControl1);
                    rowToUpdate = null;
                    nom_agenceTextEdit.Select();
                }
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void detailManagementControl1_Annuler(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                if (editControlValueChanged)
                {
                    if (API.Message.YesNoQuestion("Annuler les modifications apportées ?", "Réinitialistion"))
                    {
                        if (rowToUpdate != null)
                            FillEditControls();
                        else
                        {
                            API.Controller.ClearEditControlsWithinLayout(dataLayoutControl1);
                            id_agence_pkTextEdit.EditValue = Convert.ToInt64(gestionAgences.GetLastRowCellValue(0)) + 1;
                            editControlValueChanged = false;
                        }
                    }
                }
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void detailManagementControl1_Supprimer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (rowToUpdate != null)
                {
                    string id = rowToUpdate[0].ToString();
                    if (API.Message.YesNoQuestion("Supprimer ?", "Suppression"))
                    {
                        gestionAgences.UpdateToDeletedFlag(id);
                        gestionAgences.Save();
                        Program.MainForm.Agences_Collection_Instance.InitializeGrid();
                        Close();
                    }
                }
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private bool detailManagementControl1_Fermer()
        {
            if (editControlValueChanged)
            {
                int answer = API.Message.YesNoCancelQuestion("Enregistrer les modifications apportées ?", "Enregistrement");
                if (answer == 1)
                    return detailManagementControl1_Enregistrer();
                else if (answer == 0)
                    return true;
                else
                    return false;
            }
            return true;
        }
        private void detailManagementControl1_Fermer(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            try
            {
                if (detailManagementControl1_Fermer())
                    Close();
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }

        private void Agences_Detail_FormClosing(object sender, FormClosingEventArgs e)
        {            
            try
            {
                if (detailManagementControl1_Fermer())
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            catch (Exception x)
            {
                API.Message.Exception(x.ToString());
            }
        }
    }
}