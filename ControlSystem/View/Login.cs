using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSystem;
using ControlSystem.Classes;
using FrontPage;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public string entry;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            Button btnlogin = new Button();

            LoginClass log = new LoginClass(txtemail.Text);
         
            if  (log.message == "correct")
            {
                entry = "ok";
                this.Close();

            }
            else
            {
                entry = "false";
            }
            
        }
    }
}
