using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrontPage;
using System.IO;

namespace ControlSystem
{
    public class EmployeeRegistraionClass
    {
        ConectionClass connection = new ConectionClass();
        SqlCommand cmd = new SqlCommand();
        public String message;
        private byte[] VTImage;
        private long FileSize = 0;

        public EmployeeRegistraionClass(
                        String      FirstName,
                        String      Middlename,
                        String      LastName,
                        String      Email,
                        String      DBO,
                        String      Address,
                        String      State,
                        String      PostCode,
                        String       Mobile,
                        String      HomePhone,
                        String      Departament,
                        String      DataHired,
                        String       DataTerminated,
                        String      Image)

        {
            cmd.CommandText = "insert into Employee(FirstName, " +
                                                  " MiddleName," +
                                                  " LastName, " +
                                                  " Email,"+
                                                  " DBO,"+
                                                  " Address,"+
                                                  " State,"+
                                                  " PostCode,"+
                                                  "  Mobile,"+
                                                  "  HomePhone,"+
                                                  "  Departament,"+
                                                  "  DataHired," +
                                                  "  DataTerminated,"+
                                                  "  Image) values"+
                                                  " (@FirstName, " +
                                                  " @MiddleName," +
                                                  " @LastName, " +
                                                  " @Email," +
                                                  " @DBO," +
                                                  " @Address," +
                                                  " @State," +
                                                  " @PostCode," +
                                                  " @Mobile," +
                                                  " @HomePhone," +
                                                  " @Departament," +
                                                  " @DataHired," +
                                                  " @DataTerminated," +
                                                  " @Image)";

            //Parameters
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@MiddleName",Middlename);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@EMail", Email);
            cmd.Parameters.AddWithValue("@DBO", Convert.ToDateTime(DBO));
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@State", State);
            if (PostCode == "")
            {
                cmd.Parameters.AddWithValue("@PostCode", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@PostCode", Convert.ToInt32(PostCode));
            }
            
            if (Mobile == "" )
            {
                cmd.Parameters.AddWithValue("@Mobile", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Mobile", Convert.ToInt32(Mobile));
            }
            if (HomePhone == "")
            {
                cmd.Parameters.AddWithValue("@HomePhone", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@HomePhone", Convert.ToInt32(HomePhone));
            }  
            cmd.Parameters.AddWithValue("@Departament", Departament);
            cmd.Parameters.AddWithValue("@DataHired", Convert.ToDateTime(DataHired));
            cmd.Parameters.AddWithValue("@DataTerminated",Convert.ToDateTime(DataTerminated));
            //cmd.Parameters.AddWithValue("@Image", Convert.ToString(Image));

            //Save Image on SQL
            try
            {
                if (string.IsNullOrEmpty(Image))
                    return;
                FileInfo arqlImage = new FileInfo(Image);
                FileSize = arqlImage.Length;
                FileStream fs = new FileStream(Image, FileMode.Open, FileAccess.Read, FileShare.Read);
                VTImage = new byte[Convert.ToInt32(this.FileSize)];
                int iBytesRead = fs.Read(VTImage, 0, Convert.ToInt32(this.FileSize));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.cmd.Parameters.Add("@Image", System.Data.SqlDbType.Image);
            this.cmd.Parameters["@Image"].Value = this.VTImage;


            // Data Base Connection
            try
            {
                cmd.Connection = connection.conectar();
                cmd.ExecuteNonQuery();
                connection.desconectar();
                this.message = "Success Save!!";
            }
            catch(SqlException e)
            {
                this.message = "Database Error";
            }
        }

 
    }


}
