using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaEmprestimo
{
    public partial class FrmSelecionarSecao : Form
    {
        public string codSecao { get; private set; }
        public string DescricaoSecao { get; private set; }

        public FrmSelecionarSecao()
        {
            InitializeComponent();
        }

        private void CarregarSecaosgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDao dao = new SecaoDao(connection);
                List<SecaoModel> secaos = dao.GetSecaos();
                foreach(SecaoModel secao in secaos)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodSecao.Index].Value = secao.CodSecao;
                    row.Cells[colSecao.Index].Value = secao.DescricaoSecao;
                }

            }
        }

        private void FrmSelecionarSecao_Load(object sender, EventArgs e)
        {
            CarregarSecaosgrid();
        }

        public void Fechar()
        {
      
            DescricaoSecao = txtSecao.Text;
        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
        
                txtSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
                Fechar();
            }
        }

   
        private void txtSecao_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtSecao.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string secao = row.Cells[colSecao.Index].Value.ToString().Trim();
                bool exibir = secao.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
