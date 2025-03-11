namespace ControleEstoqueApp
{
    partial class FrmControleDeEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            txtPreco = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblQtd = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(24, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(35, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(113, 23);
            txtNome.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(184, 26);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(78, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(268, 26);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(24, 7);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(65, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(184, 7);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(69, 15);
            lblQtd.TabIndex = 6;
            lblQtd.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(268, 7);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Location = new Point(309, 77);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(390, 77);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(2, 106);
            dtgView.Name = "dtgView";
            dtgView.Size = new Size(483, 188);
            dtgView.TabIndex = 10;
            dtgView.MouseDoubleClick += dtgView_MouseDoubleClick;
            // 
            // FrmControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 304);
            Controls.Add(dtgView);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblQtd);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FrmControleDeEstoque";
            Text = "Controle de estoque";
            Load += FrmControleDeEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtPreco;
        private Label lblId;
        private Label lblNome;
        private Label lblQtd;
        private Label lblPreco;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dtgView;
    }
}
