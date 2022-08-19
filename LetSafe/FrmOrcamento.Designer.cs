namespace LetSafe
{
    partial class FrmOrcamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorFranquiaSera = new System.Windows.Forms.Label();
            this.btnRealizarOrcamento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.lblValorFranquia = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorSeguro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRealizarCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qual o tipo do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qual o departamento do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor pago no produto:";
            // 
            // lblValorFranquiaSera
            // 
            this.lblValorFranquiaSera.AutoSize = true;
            this.lblValorFranquiaSera.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorFranquiaSera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorFranquiaSera.Location = new System.Drawing.Point(33, 446);
            this.lblValorFranquiaSera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorFranquiaSera.Name = "lblValorFranquiaSera";
            this.lblValorFranquiaSera.Size = new System.Drawing.Size(308, 32);
            this.lblValorFranquiaSera.TabIndex = 7;
            this.lblValorFranquiaSera.Text = "O valor da franquia será de:";
            // 
            // btnRealizarOrcamento
            // 
            this.btnRealizarOrcamento.Location = new System.Drawing.Point(296, 415);
            this.btnRealizarOrcamento.Name = "btnRealizarOrcamento";
            this.btnRealizarOrcamento.Size = new System.Drawing.Size(175, 23);
            this.btnRealizarOrcamento.TabIndex = 8;
            this.btnRealizarOrcamento.Text = "Realizar Orçamento";
            this.btnRealizarOrcamento.UseVisualStyleBackColor = true;
            this.btnRealizarOrcamento.Click += new System.EventHandler(this.btnRealizarOrcamento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Realizar Orçamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Items.AddRange(new object[] {
            "Eletrônicos",
            "Pessoais",
            "Residencial",
            "Veículos"});
            this.cbDepartamento.Location = new System.Drawing.Point(32, 92);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(210, 33);
            this.cbDepartamento.TabIndex = 11;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(32, 150);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(210, 33);
            this.cbProduto.TabIndex = 12;

            // 
            // txbValorProduto
            // 
            this.txbValorProduto.Location = new System.Drawing.Point(32, 209);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(210, 31);
            this.txbValorProduto.TabIndex = 13;
            this.txbValorProduto.TextAlignChanged += new System.EventHandler(this.txbValorProduto_TextAlignChanged);

            this.txbValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValorProduto_KeyPress);
            // 
            // lblValorFranquia
            // 
            this.lblValorFranquia.AutoSize = true;
            this.lblValorFranquia.BackColor = System.Drawing.SystemColors.Info;
            this.lblValorFranquia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorFranquia.Location = new System.Drawing.Point(329, 493);
            this.lblValorFranquia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorFranquia.Name = "lblValorFranquia";
            this.lblValorFranquia.Size = new System.Drawing.Size(0, 32);
            this.lblValorFranquia.TabIndex = 14;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(40, 415);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(175, 23);
            this.btnRetornar.TabIndex = 15;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "O valor do seguro será de:";
            // 
            // lblValorSeguro
            // 
            this.lblValorSeguro.AutoSize = true;
            this.lblValorSeguro.BackColor = System.Drawing.SystemColors.Info;
            this.lblValorSeguro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorSeguro.Location = new System.Drawing.Point(221, 335);
            this.lblValorSeguro.Name = "lblValorSeguro";
            this.lblValorSeguro.Size = new System.Drawing.Size(0, 21);
            this.lblValorSeguro.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "R$:";
            // 
            // lblRealizarCadastro
            // 
            this.lblRealizarCadastro.AutoSize = true;
            this.lblRealizarCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRealizarCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRealizarCadastro.Location = new System.Drawing.Point(550, 414);
            this.lblRealizarCadastro.Name = "lblRealizarCadastro";
            this.lblRealizarCadastro.Size = new System.Drawing.Size(0, 21);
            this.lblRealizarCadastro.TabIndex = 19;
            this.lblRealizarCadastro.Click += new System.EventHandler(this.lblRealizarCadastro_Click);
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRealizarCadastro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblValorSeguro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.lblValorFranquia);
            this.Controls.Add(this.txbValorProduto);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRealizarOrcamento);
            this.Controls.Add(this.lblValorFranquiaSera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrcamento";
            this.Text = "FrmOrcamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblValorFranquiaSera;
        private Button btnRealizarOrcamento;
        private Label label6;
        private ComboBox cbDepartamento;
        private ComboBox cbProduto;
        private TextBox txbValorProduto;
        private Label lblValorFranquia;
        private Button btnRetornar;
        private Label label5;
        private Label lblValorSeguro;
        private Label label7;
        private Label lblRealizarCadastro;
    }
}