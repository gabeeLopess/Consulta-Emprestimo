using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    public class EditoraDAO
    {
        private SqlConnection Connection { get; }
        public EditoraDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<EditoraModel> GetEditoras()
        {
            List<EditoraModel> editoras = new List<EditoraModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codEditora, nome FROM mvtBiibEditora");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        editoras.Add(populateDr(dr));
                    }
                }
            }

            return editoras;
        }

        private EditoraModel populateDr(SqlDataReader dr)
        {
            string codEditora = "";
            string nomeEditora = "";

            if (DBNull.Value != dr["codEditora"])
            {
                codEditora = dr["codEditora"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nomeEditora = dr["nome"] + "";
            }

            return new EditoraModel()
            {

                CodEditora = codEditora,
                NomeEditora = nomeEditora,


            };
        }
    }
}
