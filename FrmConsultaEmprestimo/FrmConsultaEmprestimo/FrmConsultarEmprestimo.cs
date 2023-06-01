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
    public partial class FrmConsultaEmprestimo : Form
    {
        public FrmConsultaEmprestimo()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtItem.Text = "";
            cmbTipoItem.SelectedIndex = -1;
            cmbSituacao.SelectedIndex = -1;
            txtLeitor.Text = "";
            txtEditora.Text = "";
            txtSecao.Text = "";
            txtAutor.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
 
        private void FrmConsultaEmprestimo_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
