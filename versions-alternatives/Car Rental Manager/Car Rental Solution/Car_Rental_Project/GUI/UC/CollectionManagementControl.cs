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
using System.Drawing.Design;
using DevExpress.XtraBars;

namespace Car_Rental_Project.GUI.UC
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CollectionManagementControl : DevExpress.XtraEditors.XtraUserControl
    {
        #region Properties
        [Category("MODEL COLLECTION PROPERTIES"), DefaultValue("Gestion")]
        public string PageTitle { get; set; } = "Gestion";
        [Category("MODEL COLLECTION PROPERTIES"), DefaultValue(null)]
        [Editor("DevExpress.Utils.Design.DXImageEditor, DevExpress.Design.v16.2", typeof(UITypeEditor))]
        public Image PageImage { get; set; } = null;
        #endregion

        #region Events
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Nouveau;
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Editer;
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Supprimer;
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Actualiser;
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Apercu_Avant_Impression;
        [Category("MODEL COLLECTION EVENTS")]
        public event ItemClickEventHandler Fermer;
        #endregion

        public CollectionManagementControl()
        {
            InitializeComponent();            
        }

        private void CollectionManagementControl_Load(object sender, EventArgs e)
        {
            ribbonPage1.Text = PageTitle;
            ribbonPage1.Image = PageImage;
        }
        public void HandleEvent(ItemClickEventHandler eventHandler, ItemClickEventArgs e)
        {
            if (eventHandler != null)
                eventHandler(this, e);
        }
        private void button_nouveau_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Nouveau, e);
        }

        private void button_editer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Editer, e);
        }

        private void button_supprimer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Supprimer, e);
        }

        private void button_actualiser_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Actualiser, e);
        }

        private void button_apercu_avant_impression_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Apercu_Avant_Impression, e);
        }

        private void button_fermer_ItemClick(object sender, ItemClickEventArgs e)
        {
            HandleEvent(Fermer, e);
        }
    }
}
