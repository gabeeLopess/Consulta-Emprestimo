namespace FrmConsultaEmprestimo
{
    partial class FrmConsultaEmprestimo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItem = new System.Windows.Forms.Label();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(5, 16);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(320, 16);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(51, 13);
            this.lblTipoItem.TabIndex = 1;
            this.lblTipoItem.Text = "Tipo Item";
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Location = new System.Drawing.Point(320, 75);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(33, 13);
            this.lblLeitor.TabIndex = 2;
            this.lblLeitor.Text = "Leitor";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(5, 75);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 3;
            this.lblLocal.Text = "Local";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(5, 103);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(60, 13);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(203, 20);
            this.txtItem.TabIndex = 5;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Location = new System.Drawing.Point(380, 13);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(244, 21);
            this.cmbTipoItem.TabIndex = 6;
            this.cmbTipoItem.SelectedIndexChanged += new System.EventHandler(this.cmbTipoItem_SelectedIndexChanged);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(60, 72);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(203, 20);
            this.txtLocal.TabIndex = 7;
            // 
            // txtSecao
            // 
            this.txtSecao.Location = new System.Drawing.Point(380, 100);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.ReadOnly = true;
            this.txtSecao.Size = new System.Drawing.Size(203, 20);
            this.txtSecao.TabIndex = 8;
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(315, 103);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(38, 13);
            this.lblSecao.TabIndex = 9;
            this.lblSecao.Text = "Seção";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(60, 100);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(203, 20);
            this.txtAutor.TabIndex = 10;
            // 
            // txtLeitor
            // 
            this.txtLeitor.Location = new System.Drawing.Point(380, 72);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.ReadOnly = true;
            this.txtLeitor.Size = new System.Drawing.Size(203, 20);
            this.txtLeitor.TabIndex = 11;
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colAutor,
            this.colEditora,
            this.colSituacao,
            this.colDataReserva,
            this.colDataRetorno});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(3, 244);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(614, 235);
            this.gridLayout.TabIndex = 12;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item da Biblioteca";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // colDataReserva
            // 
            this.colDataReserva.HeaderText = "Data Reserva";
            this.colDataReserva.Name = "colDataReserva";
            this.colDataReserva.ReadOnly = true;
            // 
            // colDataRetorno
            // 
            this.colDataRetorno.HeaderText = "Data Retorno";
            this.colDataRetorno.Name = "colDataRetorno";
            this.colDataRetorno.ReadOnly = true;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(5, 46);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 17;
            this.lblSituacao.Text = "Situação";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(60, 43);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(247, 21);
            this.cmbSituacao.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(329, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 20);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(248, 8);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 20);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // button5
            // 
            this.button5.Image = global::FrmConsultaEmprestimo.Properties.Resources.icons8_lupa_16;
            this.button5.Location = new System.Drawing.Point(269, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 20);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblEditora);
            this.groupBox2.Controls.Add(this.txtSecao);
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.lblSecao);
            this.groupBox2.Controls.Add(this.lblAutor);
            this.groupBox2.Controls.Add(this.txtEditora);
            this.groupBox2.Controls.Add(this.txtLeitor);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.cmbTipoItem);
            this.groupBox2.Controls.Add(this.lblItem);
            this.groupBox2.Controls.Add(this.lblLeitor);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.lblTipoItem);
            this.groupBox2.Controls.Add(this.lblSituacao);
            this.groupBox2.Controls.Add(this.txtLocal);
            this.groupBox2.Controls.Add(this.cmbSituacao);
            this.groupBox2.Controls.Add(this.lblLocal);
            this.groupBox2.Location = new System.Drawing.Point(-5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 141);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.Image = global::FrmConsultaEmprestimo.Properties.Resources.icons8_lupa_16;
            this.button4.Location = new System.Drawing.Point(269, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 20);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::FrmConsultaEmprestimo.Properties.Resources.icons8_lupa_16;
            this.button6.Location = new System.Drawing.Point(586, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 21);
            this.button6.TabIndex = 28;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::FrmConsultaEmprestimo.Properties.Resources.icons8_lupa_16;
            this.button2.Location = new System.Drawing.Point(586, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 20);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(320, 46);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 27;
            this.lblEditora.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(380, 43);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.ReadOnly = true;
            this.txtEditora.Size = new System.Drawing.Size(203, 20);
            this.txtEditora.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Image = global::FrmConsultaEmprestimo.Properties.Resources.icons8_lupa_16;
            this.button1.Location = new System.Drawing.Point(269, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 20);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Location = new System.Drawing.Point(9, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 49);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(55, 170);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(247, 20);
            this.dtpDataInicio.TabIndex = 27;
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Location = new System.Drawing.Point(375, 170);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(244, 20);
            this.dtpDataFim.TabIndex = 28;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(137, 154);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(58, 13);
            this.lblDataInicio.TabIndex = 29;
            this.lblDataInicio.Text = "Data Inicio";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(469, 154);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(49, 13);
            this.lblDataFim.TabIndex = 30;
            this.lblDataFim.Text = "Data Fim";
            // 
            // FrmConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(620, 481);
            this.Controls.Add(this.lblDataFim);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmConsultaEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Empréstimo";
            this.Load += new System.EventHandler(this.FrmConsultaEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblDataFim;
    }
}

