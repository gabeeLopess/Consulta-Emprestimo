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
    public partial class FrmSelecionarItem : Form
    {
        public string NomeItem { get; private set; }
 

        public FrmSelecionarItem()
        {
            InitializeComponent();
        }

        private void CarregarItensgrid()
        {
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultarEmprestimoDAO dao = new ConsultarEmprestimoDAO(connection);
                List<ConsultaEmprestimoModel> itens = dao.GetItens();
                foreach(ConsultaEmprestimoModel item in itens)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodItem.Index].Value = item.CodItem;
                    row.Cells[colNomeItem.Index].Value = item.NomeItem;
                }
            }
        }
        private void FrmSelecionarItem_Load(object sender, EventArgs e)
        {
            CarregarItensgrid();
        }

        public void Fechar()
        {
            NomeItem = txtNomeItem.Text;

        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                txtNomeItem.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                Fechar();
            }
        }



        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItem.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string nomeItem = row.Cells[colNomeItem.Index].Value.ToString().Trim();
                bool exibir = nomeItem.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

    }
}
