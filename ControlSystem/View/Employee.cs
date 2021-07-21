using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSystem;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace FrontPage
{
    public partial class Employee : Form
    {
       
        public Employee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
              
        
    
        }

        private void btnFindimage_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() ==  DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog2.FileName;
                pictureBox1.Load();
                lblLocalPicture.Text = openFileDialog2.FileName;
            }
            




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             EmployeeRegistraionClass cad = new EmployeeRegistraionClass(
                                         txtFirstName.Text,
                                         txtmiddlename.Text,
                                         txtlastname.Text,
                                         txtemail.Text,
                                         dtpdbo.Text,
                                         txtaddress.Text,
                                         txtstate.Text,
                                         txtpostcode.Text,
                                         txtmobile.Text,
                                         txthomephone.Text,
                                         txtDepartament.Text,
                                         dtphired.Text,
                                         dtpterminated.Text,
                                         lblLocalPicture.Text);
           
             MessageBox.Show(cad.message);       
        }

        private void lblCode_Click(object sender, EventArgs e)
        {   
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            string sql = "select FirstName,MiddleName,LastName,DBO,Address,State,Postcode,Mobile,HomePhone,Departament from employee";
            ConectionClass conexao = new ConectionClass();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = conexao.conectar();

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;

           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name;

            name = dataGridView1.CurrentRow.ToString();

            MessageBox.Show(name);
        }
    }       
         
    
}
