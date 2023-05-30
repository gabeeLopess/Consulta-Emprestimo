using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaEmprestimo
{
    public partial class FrmSelecionarAutor : Form
    {
        public string CodAutor { get; private set; }
        public string NomeAutor { get; private set; }

        public FrmSelecionarAutor()
        {
            InitializeComponent();
        }

        private void CarregarAutoresgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach(AutorModel autor in autores)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodAutor.Index].Value = autor.CodAutor;
                    row.Cells[colNomeAutor.Index].Value = autor.NomeAutor;
                }
            }
        }
      

        private void FrmSelecionarAutor_Load(object sender, EventArgs e)
        {
            CarregarAutoresgrid();
        }

        public void Fechar()
        {
            
            NomeAutor = txtNomeAutor.Text;
        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
      
                txtNomeAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";
                Fechar();
            }
        }

        private void txtNomeAutor_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtNomeAutor.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string nomeLeitor = row.Cells[colCodAutor.Index].Value.ToString().Trim();
                bool exibir = nomeLeitor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void lblNomeAutor_Click(object sender, EventArgs e)
        {

        }

        private void gridLayout_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
