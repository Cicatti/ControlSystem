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
using WinFormsApp1;

namespace FrontPage
{
    public partial class FrontpageForm : Form
    {
        public FrontpageForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            form_customer opencustomerforme = new form_customer();
            opencustomerforme.ShowDialog();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee opencustomerforme = new Employee();
            opencustomerforme.ShowDialog();

        }

        private void FrontpageForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
