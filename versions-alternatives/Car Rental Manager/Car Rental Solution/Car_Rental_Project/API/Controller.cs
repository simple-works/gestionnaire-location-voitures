using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Data;
using System.Windows.Forms;

namespace Car_Rental_Project.API
{
    /// <summary>
    /// Fournit des méthode facilitant la manipulation de certains contrôles
    /// </summary>
    public static class Controller
    {
        /// <summary>
        /// Type du formulaire d'attente affiché lors du chargement d'un formulaire régulier.
        /// </summary>
        public static Type WaitFormType = typeof(GUI.Wait);
        /// <summary>
        /// Type du formulaire d'attente affiché lors du chargement d'un formulaire de connexion.
        /// </summary>
        public static Type LoginWaitFormType = typeof(GUI.Compte.Wait);

        /// <summary>
        /// Vérifie l'existence d'une instance d'un formulaire.
        /// </summary>
        /// <param name="form">Instance du formulaire</param>
        /// <returns>True si l'instance n'existe pas</returns>
        public static bool FormIsClosed(XtraForm form)
        {
            if (form == null || form.IsDisposed)
                return true;
            return false;
        }

        /// <summary>
        /// Ouvre un formulaire en instance unique.
        /// </summary>
        /// <typeparam name="FormType">Type de formulaire valide héritant de XtraForm</typeparam>
        /// <param name="form">Formulaire à ouvrir</param>
        public static void FormOpen<FormType>(ref FormType form) where FormType : XtraForm
        {
            SplashScreenManager.ShowForm(WaitFormType);
            if (FormIsClosed(form))
                form = (FormType)System.Activator.CreateInstance(typeof(FormType));
            form.Show();
            form.Focus();
            SplashScreenManager.CloseForm();
        }

        /// <summary>
        /// Ouvre un formulaire enfant (MdiChild) en instance unique dans un formulaire conteneur (MdiParent).
        /// </summary>
        /// <typeparam name="FormType">Type de formulaire valide héritant de XtraForm</typeparam>
        /// <param name="form">Formulaire à ouvrir</param>
        /// <param name="parentForm">Formulaire conteneur</param>
        public static void FormOpen<FormType>(ref FormType form, XtraForm parentForm) where FormType : XtraForm
        {
            SplashScreenManager.ShowForm(WaitFormType);
            if (FormIsClosed(form))
                form = (FormType)System.Activator.CreateInstance(typeof(FormType));
            form.MdiParent = parentForm;
            form.Show();
            form.Focus();
            SplashScreenManager.CloseForm();
        }

        /// <summary>
        /// Ouvre une instance non unique d'un formulaire.
        /// </summary>
        /// <typeparam name="FormType">Type de formulaire valide héritant de XtraForm</typeparam>
        /// <param name="form">Formulaire à ouvrir</param>
        public static void FormInstanceOpen<FormType>(ref FormType form) where FormType : XtraForm
        {
            SplashScreenManager.ShowForm(WaitFormType);
            form.Show();
            form.Focus();
            SplashScreenManager.CloseForm();
        }

        /// <summary>
        /// Ouvre une instance non unique d'un formulaire enfant (MdiChild) dans un formulaire conteneur (MdiParent).
        /// </summary>
        /// <typeparam name="FormType">Type de formulaire valide dont héritant de XtraForm</typeparam>
        /// <param name="form">Formulaire à ouvrir</param>
        /// <param name="parentForm">Formulaire conteneur</param>
        public static void FormInstanceOpen<FormType>(ref FormType form, XtraForm parentForm) where FormType : XtraForm
        {
            SplashScreenManager.ShowForm(WaitFormType);
            form.MdiParent = parentForm;
            form.Show();
            form.Focus();
            SplashScreenManager.CloseForm();
        }

        /// <summary>
        /// Active la fonctionalité de saisie semi-automatique pour un contrôle d'édition
        /// </summary>
        /// <param name="editControl">Contrôle d'édition ciblé</param>
        /// <param name="autoCompleteDataSource">Source des données utilisé pour la complétion</param>
        /// <param name="autoCompleteMode">Mode de la fonctionnalité de saisie semi-automatique utilisé</param>
        public static void EnableAutoComplete(TextEdit editControl, DataTable autoCompleteDataSource, AutoCompleteMode autoCompleteMode)
        {
            AutoCompleteStringCollection usersCollection = new AutoCompleteStringCollection();
            foreach (DataRow row in autoCompleteDataSource.Rows)
                usersCollection.Add(row[0].ToString());
            editControl.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            editControl.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            editControl.MaskBox.AutoCompleteCustomSource = usersCollection;
        }

        /// <summary>
        /// Configure une grille (GridView) avec des paramètres personnalisés pour l'usage actuel.
        /// </summary>
        /// <param name="gridView">GridView à configurer</param>
        public static void ConfigureGridView(GridView gridView)
        {
            gridView.OptionsBehavior.Editable = false;
        }

        /// <summary>
        /// Obtient la valeur de la cellue de la ligne actuellement sélectionné dans une grille 
        /// (GridView) à partir du nom du champs représenté par la colonne contenant la cellule.
        /// </summary>
        /// <param name="gridView">Grille ciblé</param>
        /// <param name="fieldName">Nom du champs représenté par la colonne contenant la cellule</param>
        /// <returns></returns>
        public static object GetGridViewFocusedRowValue(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName)
        {
            return gridView.GetRowCellValue(gridView.FocusedRowHandle, fieldName);
        }

        /// <summary>
        /// Vide le contenu des contôles d'édition placés à l'intérieur d'un LayoutControl.
        /// </summary>
        /// <param name="layoutControl">LayoutControl parent des contrôles</param>
        public static void ClearEditControlsWithinLayout(LayoutControl layoutControl)
        {
            foreach (System.Windows.Forms.Control control in layoutControl.Controls)
                if (control is BaseEdit)
                {
                    BaseEdit editControl = (BaseEdit)control;
                    editControl.EditValue = null;
                }
        }

        /// <summary>
        /// Crée par lot les événements EditValueChanged pour tous les 
        /// contôles d'édition placés à l'intérieur d'un LayoutControl
        /// et les gère avec la seule méthode en paramètre.
        /// </summary>
        /// <param name="layoutControl">LayoutControl parent des contrôles</param>
        /// <param name="control_EditValueChanged">Méthode qui gérera les événement créés</param>
        public static void CreateEditControlsEventsWithinLayout(LayoutControl layoutControl, EventHandler editControl_EditValueChanged)
        {
            foreach (System.Windows.Forms.Control control in layoutControl.Controls)
                if (control is BaseEdit)
                {
                    BaseEdit editControl = (BaseEdit)control;
                    editControl.EditValueChanged += editControl_EditValueChanged;
                }    
        }
    }
}
