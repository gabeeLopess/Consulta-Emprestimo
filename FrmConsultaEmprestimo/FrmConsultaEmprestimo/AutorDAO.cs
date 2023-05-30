using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    public class AutorDAO
    {
        private SqlConnection Connection { get; }
        public AutorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<AutorModel> GetAutores()
        {
            List<AutorModel> autores = new List<AutorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codAutor, nome FROM mvtBiibAutor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        autores.Add(populateDr(dr));
                    }
                }
            }

            return autores;
        }

        private AutorModel populateDr(SqlDataReader dr)
        {
            string codAutor = "";
            string nomeAutor = "";

            if (DBNull.Value != dr["codAutor"])
            {
                codAutor = dr["codAutor"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nomeAutor = dr["nome"] + "";
            }

            return new AutorModel()
            {
                CodAutor = codAutor,
                NomeAutor = nomeAutor,

            };
        }

    }
}
