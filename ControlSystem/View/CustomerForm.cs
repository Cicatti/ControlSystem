using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class form_customer : Form
    {
        public form_customer()
        {
            InitializeComponent();
        }

        private void btn_Csubmit_Click(object sender, EventArgs e)
        {
            CustomerRegistraionClass cus = new CustomerRegistraionClass(
                                                dateTime_Start.Text,
                                                txt_name.Text,
                                                txt_mobile.Text,
                                                txtcustomerphone.Text,
                                                txt_email.Text,
                                                txt_address.Text,
                                                txt_city.Text,
                                                txt_postcode.Text,
                                                cbox_frequency.Text,
                                                txt_Observation.Text);
            if(cus.message == "Saved")
            {
                MessageBox.Show(cus.message);
                txt_name.Text = "";
                txt_mobile.Text = null;
                txtcustomerphone.Text = null;
                txt_email.Text = "";
                txt_address.Text = "";
                txt_city.Text = "";
                txt_postcode.Text = null;
                txt_Observation.Text = "";
                

            }
            else
            {
                MessageBox.Show(cus.message);
            }

            
        }
    }
}
