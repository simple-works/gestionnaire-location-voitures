using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RCD_Project
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        private DAI.DataManagement gestionVehicules;
        private static Timer timer1 = new Timer();

        public Form_Main()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (API.Notification.NotificationsActives)
            {
                SetTimer(true);
            }
        }

        public static void SetTimer(bool start)
        {
            timer1.Interval = API.Notification.FrequenceNotifications * 1000;
            if (start) timer1.Start(); else timer1.Stop();
        }
        private void AfficherAlerte(string titre, string message, object tag)
        {
            AlertInfo info = new AlertInfo(titre, message);
            info.Tag = tag;
            alertControl1.Show(this, info);
            if (API.Notification.EffetSonoreNotificationsActif)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.alert_31);
                player.Play();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            gestionVehicules = new DAI.DataManagement(DAI.DataDescription.TableInfos.Vehicule);
            API.Notification.ListeNotifications.Clear();

            foreach (DataRow vehicule in gestionVehicules.Table.Rows)
            {
                // Identifiants du véhicule
                string immatriculationVehicule = vehicule["immatriculation_vehicule_pk"].ToString();
                string marqueVehicule = vehicule["marque_vehicule"].ToString();

                // Données techniques du véhicule
                object _distance_parcourue = vehicule["distance_parcourue_vehicule"];
                object _date_achat = vehicule["date_achat_vehicule"];
                object _date_maintenance = vehicule["date_derniere_maintenance_vehicule"];
                double distanceParcourueVehicule = (_distance_parcourue != DBNull.Value) ? Convert.ToDouble(_distance_parcourue) : 0;
                DateTime dateAchatVehicule = (_date_achat != DBNull.Value) ? Convert.ToDateTime(_date_achat) : new DateTime(1, 1, 1);
                DateTime dateDerniereMaintenanceVehicule = (_date_maintenance != DBNull.Value) ? Convert.ToDateTime(_date_maintenance) : new DateTime(1, 1, 1);

                // Données déduites
                DateTime datePremiereMaintenaceVehicule = API.Business.DatePremiereMaintenaceVehicule(dateAchatVehicule);
                DateTime dateProchaineMaintenaceVehicule = API.Business.DateProchaineMaintenaceVehicule(dateDerniereMaintenanceVehicule);
                int JoursRestantPourPremiereMaintenance = API.Business.RemainingTimeToDate(datePremiereMaintenaceVehicule, API.Business.TimeUnit.Days);
                int JoursRestantPourProchaineMaintenance = API.Business.RemainingTimeToDate(dateProchaineMaintenaceVehicule, API.Business.TimeUnit.Days);

                // Message de notification général
                string msg = string.Format("Le véhicule {0} d'immatricualtion {1} requiert votre attention !", marqueVehicule, immatriculationVehicule);

                // Valeurs
                string vidange = "Vidange";
                string maintenance = "Maintenance";
                string typeNotification = "";

                // Notification de vidange
                if (API.Business.VehiculeExigeVidange(distanceParcourueVehicule))
                {
                    if (!API.Notification.ListeNotifications.ContainsKey(vehicule) ||
                        (API.Notification.ListeNotifications.TryGetValue(vehicule, out typeNotification) && typeNotification != vidange))
                    {
                        API.Notification.ListeNotifications.Add(vehicule, vidange);
                    }
                    AfficherAlerte(msg, "Le véhicule requiert un remplacement de son huile moteur (Vidange).", vehicule);
                }

                // Notification de maintenance
                if (JoursRestantPourPremiereMaintenance >= 0 && JoursRestantPourPremiereMaintenance <= 7)
                {
                    if (!API.Notification.ListeNotifications.ContainsKey(vehicule) ||
                        (API.Notification.ListeNotifications.TryGetValue(vehicule, out typeNotification) && typeNotification != maintenance))
                    {
                        API.Notification.ListeNotifications.Add(vehicule, maintenance);
                    }
                    AfficherAlerte(msg,
                        string.Format("Le jour de la première maintenance du véhicule s'approche ({0} jours restants)", JoursRestantPourPremiereMaintenance),
                        vehicule);
                }
                else if (JoursRestantPourProchaineMaintenance >= 0 && JoursRestantPourProchaineMaintenance <= 7)
                {
                    if (!API.Notification.ListeNotifications.ContainsKey(vehicule) ||
                        (API.Notification.ListeNotifications.TryGetValue(vehicule, out typeNotification) && typeNotification != maintenance))
                    {
                        API.Notification.ListeNotifications.Add(vehicule, maintenance);
                    }
                    AfficherAlerte(msg,
                        string.Format("Le jour de la prochaine maintenance du véhicule s'approche ({0} jours restants)", JoursRestantPourProchaineMaintenance),
                        vehicule);
                }
            }
        }

        private void alertControl1_AlertClick(object sender, AlertClickEventArgs e)
        {
            Form_Alert alerts = new Form_Alert();
            alerts.ShowDialog();
        }
    }
}
