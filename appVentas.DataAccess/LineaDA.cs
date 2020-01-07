using appVentas.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DataAccess
{
    public class LineaDA
    {
        private readonly string _connectionString;

        public LineaDA()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }


        public List<LineaBE> GetAllLineas()
        {
            List<LineaBE> lstLinea = new List<LineaBE>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_uspGetAllLineas", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LineaBE lineaBE = new LineaBE();
                    lineaBE.CodLin = reader["COD_LIN"].ToString();
                    lineaBE.NomLin = reader["NOM_LIN"].ToString();
                    lstLinea.Add(lineaBE);
                }
                connection.Close();
                return lstLinea;
            }
        }
    }
}
