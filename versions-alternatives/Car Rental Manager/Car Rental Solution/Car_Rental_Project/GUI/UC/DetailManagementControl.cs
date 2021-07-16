using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.Design;
using DevExpress.XtraBars.Ribbon;
using System.Drawing.Design;
using DevExpress.XtraBars;

namespace Car_Rental_Project.GUI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class DetailManagementControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        [Category("MODEL DETAIL PROPERTIES"), DefaultValue("Gestion")]
        public string PageTitle { get; set; } = "Gestion";
        [Category("MODEL DETAIL PROPERTIES"), DefaultValue(null)]
        [Editor("DevExpress.Utils.Design.DXImageEditor, DevExpress.Design.v16.2", typeof(UITypeEditor))]
        public Image PageImage { get; set; } = null;
        #endregion

        #region Events
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Enregistrer;
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Enregistrer_Et_Fermer;
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Enregistrer_Et_Nouveau;
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Annuler;
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Supprimer;
        [Category("MODEL DETAIL EVENTS")]
        public event ItemClickEventHandler Fermer;
        #endregion

        public DetailManagementControl()
        {
            InitializeComponent();
        }

        private void DetailManagementControl_Load(object sender, EventArgs e)
        {
            ribbonPage1.Text = PageTitle;
            ribbonPage1.Image = PageImage;
        }

        public void HandleEvent(ItemClickEventHandler eventHandler, ItemClickEventArgs e)
        {
            if (eventHandler != null)
                eventHandler(this, e);
        }
        private void button_enregistrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Enregistrer, e);
        }

        private void button_enregistrer_et_fermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Enregistrer_Et_Fermer, e);
        }

        private void button_enregistrer_et_nouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Enregistrer_Et_Nouveau, e);
        }

        private void button_annuler_changements_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Annuler, e);
        }

        private void button_supprimer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Supprimer, e);
        }

        private void button_fermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Fermer, e);
        }
    }
}
