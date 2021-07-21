using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ControlSystem
{
    public class ConectionClass
    {
        SqlConnection con = new SqlConnection();
        public String message;

        // String Connection
        public ConectionClass()
        {
            try
            {
                con.ConnectionString = "Data Source=WIN-FS71EF50E3L;Initial Catalog=RodrigoTeste;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            }
            catch(SqlException e)
            {
                this.message = "Data Base Error";
            }
            

        }
        //Data Base Connect
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Data Base Disconnect
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        
        }
    }
}
