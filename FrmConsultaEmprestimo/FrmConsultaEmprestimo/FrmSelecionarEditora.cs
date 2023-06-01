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
    public partial class FrmSelecionarEditora : Form
    {
        public string CodEditora { get; private set; }
        public string NomeEditora { get; private set; }
        public FrmSelecionarEditora()
        {
            InitializeComponent();
        }

        private void CarregarEditorasgrid()
        {
            gridLayout.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach(EditoraModel editora in editoras)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodEditora.Index].Value = editora.CodEditora;
                    row.Cells[colEditora.Index].Value = editora.NomeEditora;
                }
            }
        }
        
        private void FrmSelecionarEditora_Load(object sender, EventArgs e)
        {
            CarregarEditorasgrid();
        }

        private void Fechar()
        {
          
            NomeEditora = txtEditora.Text;
        }

     

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
          
                txtEditora.Text = gridLayout.Rows[e.RowIndex].Cells[colEditora.Index].Value + "";
                Fechar();
            }
        }

        private void txtEditora_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtEditora.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string nomeEditora = row.Cells[colEditora.Index].Value.ToString().Trim();
                bool exibir = nomeEditora.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void FrmSelecionarEditora_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FrmSelecionarEditora_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridLayout_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
