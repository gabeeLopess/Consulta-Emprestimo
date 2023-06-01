namespace FrmConsultaEmprestimo
{
    partial class FrmSelecionarEditora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditora
            // 
            this.txtEditora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEditora.Location = new System.Drawing.Point(51, 12);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.ReadOnly = true;
            this.txtEditora.Size = new System.Drawing.Size(349, 20);
            this.txtEditora.TabIndex = 23;
            this.txtEditora.TextChanged += new System.EventHandler(this.txtEditora_TextChanged);
            // 
            // lblEditora
            // 
            this.lblEditora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(11, 15);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 22;
            this.lblEditora.Text = "Editora";
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
            this.colCodEditora,
            this.colEditora});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(11, 47);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(389, 237);
            this.gridLayout.TabIndex = 21;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick_1);
            // 
            // colCodEditora
            // 
            this.colCodEditora.HeaderText = "Id";
            this.colCodEditora.Name = "colCodEditora";
            this.colCodEditora.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // FrmSelecionarEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 296);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.gridLayout);
            this.Name = "FrmSelecionarEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Editora";
            this.Load += new System.EventHandler(this.FrmSelecionarEditora_Load);
            this.DoubleClick += new System.EventHandler(this.FrmSelecionarEditora_DoubleClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmSelecionarEditora_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
    }
}