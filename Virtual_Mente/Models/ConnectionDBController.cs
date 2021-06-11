using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace Virtual_Mente.Models
{
    public class ConnectionDBController : Controller
    {
        String connectString = "Data source=DESKTOP-6UKN1R4\\MSSQLSERVER2019\\MSSQLSERVER19;Initial Catalog=VirtualMente; Integrated Security=True";
       
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        
    
        /// <param name="parametros">Parámetros necesarios para la ejecución del Stored Procedure.</param>
        /// <param name="SP">Nombre del Stored Procedure a ejecutar.</param>
    
        public List<string> GetValores(SqlParameter[] parametros, string SP)
        {
            List<string> resultado = new List<string>();
            try
            {
                con = new SqlConnection(connectString);
                cmd = new SqlCommand
                {
                    Connection = con
                };
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                cmd.Parameters.AddRange(parametros);

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i <= reader.FieldCount; i++)
                        {
                            resultado.Add(reader.GetValue(i).ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Dispose();
                con.Dispose();
            }
            return resultado;
        }
    }
}
