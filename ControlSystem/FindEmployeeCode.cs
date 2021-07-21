using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ControlSystem
{
    public class FindEmployeeCode
    {
        ConectionClass conexao = new ConectionClass();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public FindEmployeeCode(int Code)
            {

            

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.CommandText = ("select Code from Employee where Code =" +
                                    "select max(Code) from Employee");
                cmd.Parameters.Add("@Code",SqlDbType.Int).Value = Code;
                cmd.ExecuteReader();
                conexao.desconectar();
              
                this.mensagem = "Found";
            }
            catch (SqlException e)
            {
                this.mensagem = "Data Base Error";
            }

          
            

        }
        
    }
}

