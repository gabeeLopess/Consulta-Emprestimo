using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace FrmConsultaEmprestimo
{
    public class ConsultarEmprestimoDAO
    {
        private SqlConnection Connection { get; }

        public ConsultarEmprestimoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaEmprestimoModel> BuscaEmprestimo(ConsultaEmprestimoModel consulta)
        {

            List<ConsultaEmprestimoModel> buscas = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();

                sql.AppendLine("SELECT TOP 1 r.nomeItem, i.nomeAutor, i.nomeEditora, r.stts, r.dataReserva, r.prazoReserva");
                sql.AppendLine("FROM mvtBibReserva r INNER JOIN mvtBibItemAcervo i ON r.codItem = i.codItem");
                sql.AppendLine("WHERE r.nomeItem LIKE '%' + @nomeItem + '%'");
                sql.AppendLine("OR r.nomeLeitor LIKE '%' + @nomeLeitor + '%'");
                sql.AppendLine("AND r.stts = @stts ORDER BY codReserva desc");

                command.Parameters.AddWithValue("@nomeItem", consulta.NomeItem);
                command.Parameters.AddWithValue("@nomeLeitor", consulta.NomeLeitor);
                command.Parameters.AddWithValue("@statusItem", consulta.StatusItem);

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrItem(dr));
                    }
                }
            }
            return buscas;
        }
           
        public ConsultaEmprestimoModel PopulateDrItem(SqlDataReader dr)
        {

            string codItem = "";
            string nomeItem = "";
            string nomeLeitor = "";
            string dataReserva = "";
            string prazoReserva = "";
            string situacao = "";

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nomeItem = dr["nomeItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nomeLeitor = dr["nomeLeitor"] + "";
            }
            if (DBNull.Value != dr["dataReserva"])
            {
                prazoReserva = dr["dataReserva"] + "";
            }
            if (DBNull.Value != dr["prazoReserva"])
            {
                prazoReserva = dr["prazoReserva"] + "";
            }
            return new ConsultaEmprestimoModel()
            {
                CodItem = codItem,
                NomeItem = nomeItem,
                NomeLeitor = nomeLeitor,
                DataInicio = dataReserva,
                DataFim = prazoReserva,
                Situacao = situacao
            };
        }
    }

}
