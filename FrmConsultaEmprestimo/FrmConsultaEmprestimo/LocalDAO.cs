using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    internal class LocalDAO
    {
        private SqlConnection Connection { get; }
        public LocalDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<LocalModel> GetLocais()
        {
            List<LocalModel> locais = new List<LocalModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codLocal, descricaoLocal FROM MvtBIBLocal");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        locais.Add(populateDr(dr));
                    }
                }
            }
            return locais;
        }

        private LocalModel populateDr(SqlDataReader dr)
        {
            string codLocal = "";
            string descricaoLocal = "";

            if (DBNull.Value != dr["codLocal"])
            {
                codLocal = dr["codLocal"] + "";
            }
            if (DBNull.Value != dr["descricaoLocal"])
            {
                descricaoLocal = dr["descricaoLocal"] + "";
            }

            return new LocalModel()
            {

                CodLocal = codLocal,
                NomeLocal = descricaoLocal,


            };
        }
    }
}
