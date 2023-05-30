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
    public partial class FrmSelecionarLocal : Form
    {
        public string codLocal { get; private set; }
        public string NomeLocal { get; private set; }   

        public FrmSelecionarLocal()
        {
            InitializeComponent();
        }

        private void CarregarLocaisgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach(LocalModel local in locais)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodLocal.Index].Value = local.CodLocal;
                    row.Cells[colLocal.Index].Value = local.Local;
                }
            }
        }

        private void FrmSelecionarLocal_Load(object sender, EventArgs e)
        {
            CarregarLocaisgrid();
        }

        public void Fechar()
        {
           
            NomeLocal = txtLocal.Text;
        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
              
                txtLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colLocal.Index].Value + "";
                Fechar();
            }
        }

  
        private void txtLocal_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtLocal.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string local = row.Cells[colLocal.Index].Value.ToString().Trim();
                bool exibir = local.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
