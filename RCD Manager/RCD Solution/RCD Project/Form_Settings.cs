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
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            edit_activerNotif.EditValue = API.Notification.NotificationsActives;
            edit_activerSon.EditValue = API.Notification.EffetSonoreNotificationsActif;
            edit_frequence.EditValue = API.Notification.FrequenceNotifications;

            edit_dureeExploitation.EditValue = API.Business.DureeExploitationVehicule;
            edit_intervallePremiereMaint.EditValue = Convert.ToInt32(API.Business.IntervalleMaintenanceVehicule.TotalDays / 30);
            edit_distanceVidange.EditValue = API.Business.DistanceMinimumVidangeVehicule;

            edit_frequence.Enabled = edit_activerNotif.Checked;
        }

        private void edit_activerNotif_CheckedChanged(object sender, EventArgs e)
        {
            edit_frequence.Enabled = edit_activerSon.Enabled = edit_activerNotif.Checked;
            API.Notification.SetNotificationsActives(edit_activerNotif.Checked);
            Form_Main.SetTimer(edit_activerNotif.Checked);
        }

        private void edit_frequence_EditValueChanged(object sender, EventArgs e)
        {
            API.Notification.SetFrequenceNotifications(Convert.ToInt32(edit_frequence.EditValue));
            Form_Main.SetTimer(edit_activerNotif.Checked);
        }

        private void edit_dureeExploitation_EditValueChanged(object sender, EventArgs e)
        {
            API.Business.SetDureeExploitationVehicule(Convert.ToInt32(edit_dureeExploitation.EditValue));
        }

        private void edit_intervallePremiereMaint_EditValueChanged(object sender, EventArgs e)
        {
            double jours = Convert.ToDouble(edit_intervallePremiereMaint.EditValue)*30;
            API.Business.SetIntervalleMaintenanceVehicule(TimeSpan.FromDays(jours));
        }

        private void edit_distanceVidange_EditValueChanged(object sender, EventArgs e)
        {
            API.Business.SetDistanceMinimumVidangeVehicule(Convert.ToDouble(edit_distanceVidange.EditValue));
        }

        private void edit_activerSon_CheckedChanged(object sender, EventArgs e)
        {
            API.Notification.SetEffetSonoreNotificationsActif(edit_activerSon.Checked);
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Form_Alert alerts = new Form_Alert();
            alerts.ShowDialog();
        }
    }
}