using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using FrontPage;

namespace ControlSystem.Classes
{
    public class LoginClass
    {
        public String message;
        public LoginClass(string Email)
        {
            //Login Check
            try
            {
                string sql = "select * from Employee where Email = @Email";
                ConectionClass conexao = new ConectionClass();
                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@EMail", Email);

                cmd.Connection = conexao.conectar();

                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read())
                {
                    conexao.desconectar();
                    message = "correct";
                }
                else
                {
                    message = "Email Incorrect";
                    conexao.desconectar();
                    MessageBox.Show(message);
                }

            }
            catch (Exception error)
            {
                this.message = "Error:" + error;
            }
        }
    }
}
