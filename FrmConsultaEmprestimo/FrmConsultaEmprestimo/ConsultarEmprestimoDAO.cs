using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaEmprestimo
{
    public class ConsultarEmprestimoDAO
    {
        private SqlConnection Connection { get; }

        public ConsultarEmprestimoDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public bool Validacao(ConsultaEmprestimoModel emprestimo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {
            if (string.IsNullOrEmpty(emprestimo.NomeItem) || string.IsNullOrWhiteSpace(emprestimo.NomeItem))
            {
                MessageBox.Show("Informe o Item", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(emprestimo.TipoItem) || string.IsNullOrWhiteSpace(emprestimo.TipoItem))
            {
                MessageBox.Show("Informe o campo tipo item", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(local.Local) || string.IsNullOrWhiteSpace(local.Local))
            {
                MessageBox.Show("Informe o campo local", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(autor.NomeAutor) || string.IsNullOrWhiteSpace(autor.NomeAutor))
            {
                MessageBox.Show("Informe o campo Nome do autor", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(emprestimo.NomeLeitor) || string.IsNullOrWhiteSpace(emprestimo.NomeLeitor))
            {
                MessageBox.Show("Informe o campo Leitor", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(editora.NomeEditora) || string.IsNullOrWhiteSpace(editora.NomeEditora))
            {
                MessageBox.Show("Informe o campo Editora", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(secao.DescricaoSecao) || string.IsNullOrWhiteSpace(secao.DescricaoSecao))
            {
                MessageBox.Show("Informe o campo Seção", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(emprestimo.DataInicio) || string.IsNullOrWhiteSpace(emprestimo.DataInicio))
            {
                MessageBox.Show("Informe o campo Data Inicio", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(emprestimo.DataFim) || string.IsNullOrWhiteSpace(emprestimo.DataFim))
            {
                MessageBox.Show("Informe o campo Data Fim", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        public void consult(ConsultaEmprestimoModel emprestimo, AutorModel autor, EditoraModel editora, LocalModel local, SecaoModel secao)
        {

        }










        public List<ConsultaEmprestimoModel> GetItens()
        {
            List<ConsultaEmprestimoModel> emprestimos = new List<ConsultaEmprestimoModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nomeItem, nomeLeitor, " +
                    "dataReserva, prazoReserva, " +
                    "situacao FROM -- mvt");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        emprestimos.Add(PopulateDr(dr));
                    }
                }
            }
            return emprestimos;
        }


        public ConsultaEmprestimoModel PopulateDr(SqlDataReader dr)
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
