using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ControlSystem
{
    public class CustomerRegistraionClass
    {
        ConectionClass connection = new ConectionClass();
        SqlCommand cmd = new SqlCommand();
        public String message;

        public CustomerRegistraionClass(
                        String DataStart,
                        String Name,
                        String Mobile,
                        String Phone,
                        String Email,
                        String Address,
                        String City,
                        String PostCode,
                        String Frequency,
                        String Observation)
        {
            cmd.CommandText = "insert into Customer(DataStart," +
                                                  " Name, " +
                                                  " Mobile," +
                                                  " Phone," +
                                                  " Email," +
                                                  " Address," +
                                                  " City," +
                                                  " Postcode," +
                                                  " Frequency," +
                                                  " Observation) values" +
                                                  " (@DataStart," +
                                                  " @Name, " +
                                                  " @Mobile," +
                                                  " @Phone," +
                                                  " @Email," +
                                                  " @Address," +
                                                  " @City," +
                                                  " @Postcode," +
                                                  " @Frequency," +
                                                  " @Observation)";

            //Parameters
            cmd.Parameters.AddWithValue("@DataStart", Convert.ToDateTime(DataStart));
            cmd.Parameters.AddWithValue("@Name", Name);
            if (Mobile == "")
            {
                cmd.Parameters.AddWithValue("@Mobile", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Mobile", Convert.ToInt32(Mobile));
            }
            if (Phone == "")
            {
                
                cmd.Parameters.AddWithValue("@Phone", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Phone", Convert.ToInt32(Phone));
            }
            cmd.Parameters.AddWithValue("@EMail", Email);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@City", City);
            if(PostCode == "")
            {
                cmd.Parameters.AddWithValue("@PostCode", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@PostCode", Convert.ToInt32(PostCode));
            }
            cmd.Parameters.AddWithValue("@Frequency", Frequency);
            cmd.Parameters.AddWithValue("@Observation", Convert.ToString(Observation));

            //SQL Connection
            try
            {
                cmd.Connection = connection.conectar();
                cmd.ExecuteNonQuery();
                connection.desconectar();
                this.message = "Saved";
            }
            catch (SqlException e)
            {
                this.message = "Data Base Error";
            }
        }
    }
}
