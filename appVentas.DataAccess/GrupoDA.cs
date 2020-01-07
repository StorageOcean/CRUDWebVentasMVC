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
    public class GrupoDA
    {
        private readonly string _connectionString;

        public GrupoDA()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public List<GrupoBE> GetAllGrupos()
        {
            List<GrupoBE> lstGrupo = new List<GrupoBE>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_uspGetAllGrupos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GrupoBE grupoBE = new GrupoBE();
                    grupoBE.CodGrup = reader["COD_GRUP"].ToString();
                    grupoBE.NomGrup = reader["NOM_GRUP"].ToString();
                    lstGrupo.Add(grupoBE);
                }
                connection.Close();
                return lstGrupo;
            }             
        }
    }
}
