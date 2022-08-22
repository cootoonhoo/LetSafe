namespace LetSafe
{
    partial class FrmCadastroApolice
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
            this.lblValorSeguro = new System.Windows.Forms.Label();
            this.lblInicioVigencia = new System.Windows.Forms.Label();
            this.lblFimVigencia = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbValorSeguro = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblCpfSegurado = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.cobProduto = new System.Windows.Forms.ComboBox();
            this.lblPossiuProd = new System.Windows.Forms.Label();
            this.lblSelectProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.cobTipoProduto = new System.Windows.Forms.ComboBox();
            this.cobListaProdutos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblValorSeguro
            // 
            this.lblValorSeguro.AutoSize = true;
            this.lblValorSeguro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorSeguro.Location = new System.Drawing.Point(12, 22);
            this.lblValorSeguro.Name = "lblValorSeguro";
            this.lblValorSeguro.Size = new System.Drawing.Size(106, 19);
            this.lblValorSeguro.TabIndex = 0;
            this.lblValorSeguro.Text = "Valor do seguro";
            // 
            // lblInicioVigencia
            // 
            this.lblInicioVigencia.AutoSize = true;
            this.lblInicioVigencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicioVigencia.Location = new System.Drawing.Point(22, 60);
            this.lblInicioVigencia.Name = "lblInicioVigencia";
            this.lblInicioVigencia.Size = new System.Drawing.Size(96, 19);
            this.lblInicioVigencia.TabIndex = 1;
            this.lblInicioVigencia.Text = "Inicio Vigência";
            // 
            // lblFimVigencia
            // 
            this.lblFimVigencia.AutoSize = true;
            this.lblFimVigencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFimVigencia.Location = new System.Drawing.Point(32, 93);
            this.lblFimVigencia.Name = "lblFimVigencia";
            this.lblFimVigencia.Size = new System.Drawing.Size(86, 19);
            this.lblFimVigencia.TabIndex = 2;
            this.lblFimVigencia.Text = "Fim Vigência";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(231, 372);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 39);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbValorSeguro
            // 
            this.txbValorSeguro.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbValorSeguro.Location = new System.Drawing.Point(124, 21);
            this.txbValorSeguro.Name = "txbValorSeguro";
            this.txbValorSeguro.Size = new System.Drawing.Size(200, 23);
            this.txbValorSeguro.TabIndex = 4;
            this.txbValorSeguro.Text = "5000,00";
            this.txbValorSeguro.Enter += new System.EventHandler(this.txbValorSeguro_Enter);
            this.txbValorSeguro.Leave += new System.EventHandler(this.txbValorSeguro_Leave);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetornar.Location = new System.Drawing.Point(125, 372);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(94, 39);
            this.btnRetornar.TabIndex = 5;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(124, 56);
            this.dtpInicio.MaxDate = new System.DateTime(2100, 8, 19, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpInicio.TabIndex = 6;
            this.dtpInicio.Value = new System.DateTime(2022, 8, 19, 0, 0, 0, 0);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(124, 89);
            this.dtpFim.MinDate = new System.DateTime(2022, 8, 19, 14, 36, 11, 0);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(200, 23);
            this.dtpFim.TabIndex = 7;
            this.dtpFim.Value = new System.DateTime(2022, 8, 19, 14, 36, 11, 0);
            // 
            // lblCpfSegurado
            // 
            this.lblCpfSegurado.AutoSize = true;
            this.lblCpfSegurado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpfSegurado.Location = new System.Drawing.Point(23, 124);
            this.lblCpfSegurado.Name = "lblCpfSegurado";
            this.lblCpfSegurado.Size = new System.Drawing.Size(95, 19);
            this.lblCpfSegurado.TabIndex = 8;
            this.lblCpfSegurado.Text = "CPF Segurado";
            // 
            // mtbCpf
            // 
            this.mtbCpf.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtbCpf.Location = new System.Drawing.Point(124, 123);
            this.mtbCpf.Mask = "000000000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(200, 23);
            this.mtbCpf.TabIndex = 12;
            this.mtbCpf.Text = "00000000000";
            this.mtbCpf.Enter += new System.EventHandler(this.mtbCpf_Enter);
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // cobProduto
            // 
            this.cobProduto.FormattingEnabled = true;
            this.cobProduto.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cobProduto.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cobProduto.Location = new System.Drawing.Point(124, 158);
            this.cobProduto.Name = "cobProduto";
            this.cobProduto.Size = new System.Drawing.Size(200, 23);
            this.cobProduto.TabIndex = 13;
            this.cobProduto.SelectedIndexChanged += new System.EventHandler(this.cobProduto_SelectedIndexChanged);
            this.cobProduto.Enter += new System.EventHandler(this.cobProduto_Enter);
            this.cobProduto.Leave += new System.EventHandler(this.cobProduto_Leave);
            // 
            // lblPossiuProd
            // 
            this.lblPossiuProd.AutoSize = true;
            this.lblPossiuProd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPossiuProd.Location = new System.Drawing.Point(11, 158);
            this.lblPossiuProd.Name = "lblPossiuProd";
            this.lblPossiuProd.Size = new System.Drawing.Size(107, 19);
            this.lblPossiuProd.TabIndex = 14;
            this.lblPossiuProd.Text = "Possiu Produto?";
            // 
            // lblSelectProduto
            // 
            this.lblSelectProduto.AutoSize = true;
            this.lblSelectProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectProduto.Location = new System.Drawing.Point(0, 195);
            this.lblSelectProduto.Name = "lblSelectProduto";
            this.lblSelectProduto.Size = new System.Drawing.Size(119, 19);
            this.lblSelectProduto.TabIndex = 15;
            this.lblSelectProduto.Text = "Selecione Produto";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProduto.Location = new System.Drawing.Point(18, 226);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(100, 19);
            this.lblNomeProduto.TabIndex = 17;
            this.lblNomeProduto.Text = "Nome Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(24, 263);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(94, 19);
            this.lblValor.TabIndex = 18;
            this.lblValor.Text = "Valor Produto";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoProduto.Location = new System.Drawing.Point(29, 301);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(89, 19);
            this.lblTipoProduto.TabIndex = 19;
            this.lblTipoProduto.Text = "Tipo Produto";
            // 
            // txbValor
            // 
            this.txbValor.Enabled = false;
            this.txbValor.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbValor.Location = new System.Drawing.Point(124, 262);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(200, 23);
            this.txbValor.TabIndex = 20;
            this.txbValor.Text = "5000,00";
            this.txbValor.Enter += new System.EventHandler(this.txbValor_Enter);
            this.txbValor.Leave += new System.EventHandler(this.txbValor_Leave);
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Enabled = false;
            this.txbNomeProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNomeProduto.Location = new System.Drawing.Point(124, 226);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(200, 23);
            this.txbNomeProduto.TabIndex = 21;
            // 
            // cobTipoProduto
            // 
            this.cobTipoProduto.Enabled = false;
            this.cobTipoProduto.FormattingEnabled = true;
            this.cobTipoProduto.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cobTipoProduto.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cobTipoProduto.Location = new System.Drawing.Point(124, 300);
            this.cobTipoProduto.Name = "cobTipoProduto";
            this.cobTipoProduto.Size = new System.Drawing.Size(200, 23);
            this.cobTipoProduto.TabIndex = 22;
            // 
            // cobListaProdutos
            // 
            this.cobListaProdutos.FormattingEnabled = true;
            this.cobListaProdutos.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.cobListaProdutos.Location = new System.Drawing.Point(125, 191);
            this.cobListaProdutos.Name = "cobListaProdutos";
            this.cobListaProdutos.Size = new System.Drawing.Size(200, 23);
            this.cobListaProdutos.TabIndex = 23;
            // 
            // FrmCadastroApolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 423);
            this.Controls.Add(this.cobListaProdutos);
            this.Controls.Add(this.cobTipoProduto);
            this.Controls.Add(this.txbNomeProduto);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblTipoProduto);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblSelectProduto);
            this.Controls.Add(this.lblPossiuProd);
            this.Controls.Add(this.cobProduto);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.lblCpfSegurado);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.txbValorSeguro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblFimVigencia);
            this.Controls.Add(this.lblInicioVigencia);
            this.Controls.Add(this.lblValorSeguro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroApolice";
            this.Text = "Cadastrar apólice";
            this.Load += new System.EventHandler(this.FrmCadastroApolice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValorSeguro;
        private Label lblInicioVigencia;
        private Label lblFimVigencia;
        private Button btnCadastrar;
        private TextBox txbValorSeguro;
        private Button btnRetornar;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lblCpfSegurado;
        private MaskedTextBox mtbCpf;
        private ComboBox cobProduto;
        private Label lblPossiuProd;
        private Label lblSelectProduto;
        private Label lblNomeProduto;
        private Label lblValor;
        private Label lblTipoProduto;
        private TextBox txbValor;
        private TextBox txbNomeProduto;
        private ComboBox cobTipoProduto;
        private ComboBox cobListaProdutos;
    }
}