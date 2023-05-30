using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultaEmprestimo
{
    internal class LeitoDAO
    {
        private SqlConnection Connection { get; }
        public LeitoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaEmprestimoModel> GetLeitores()
        {
            List<ConsultaEmprestimoModel> leitores = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codLeitor, leitor FROM MvtBIBLeitor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(populateDr(dr));

                    }
                }

            }
            return leitores;
        }


        private ConsultaEmprestimoModel populateDr(SqlDataReader dr)
        {
            string codLeitor = "";
            string leitor = "";

            if (DBNull.Value != dr["codLeitor"])
            {
                codLeitor = dr["codLeitor"] + "";
            }
            if (DBNull.Value != dr["leitor"])
            {
                leitor = dr["leitor"] + "";
            }

            return new ConsultaEmprestimoModel()
            {

                CodLeitor = codLeitor,
                NomeLeitor = leitor,


            };
        }
    }
}
