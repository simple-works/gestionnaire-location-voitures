using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RCD_Project
{
    public partial class Form_Alert : DevExpress.XtraEditors.XtraForm
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            listBoxControl1.Items.Clear();
            foreach (var notification in API.Notification.ListeNotifications)
            {
                string text = "";
                text += string.Format("[{0}] ", notification.Value);
                text += string.Format("Marque: {0} - Immatriculation: {1}", notification.Key["marque_vehicule"], notification.Key["immatriculation_vehicule_pk"]);
                listBoxControl1.Items.Add(text);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FillList();
        }
    }
}