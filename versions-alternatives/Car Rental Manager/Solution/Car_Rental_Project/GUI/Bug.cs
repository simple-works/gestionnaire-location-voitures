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

namespace Car_Rental_Project.GUI
{
    public partial class Bug : DevExpress.XtraEditors.XtraForm
    {
        public Bug()
        {
            InitializeComponent();
        }

        public Bug(string detailsText) : this()
        {
            edit_details.Text = detailsText;
        }

        public Bug(string messageText, string captionText, string detailsText) : this()
        {
            lab_messsage.Text = messageText;
            Text = captionText;
            edit_details.Text = detailsText;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            edit_details.Visible = !edit_details.Visible;
        }
    }
}