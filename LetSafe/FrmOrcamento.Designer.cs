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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txbValorProduto = new System.Windows.Forms.TextBox();
            this.lblValorFranquia = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 587);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Realizar Orçamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cbDepartamento.Location = new System.Drawing.Point(33, 153);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(210, 33);
            this.cbDepartamento.TabIndex = 11;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(33, 250);
            this.cbProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(210, 33);
            this.cbProduto.TabIndex = 12;
            // 
            // txbValorProduto
            // 
            this.txbValorProduto.Location = new System.Drawing.Point(33, 348);
            this.txbValorProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbValorProduto.Name = "txbValorProduto";
            this.txbValorProduto.Size = new System.Drawing.Size(210, 31);
            this.txbValorProduto.TabIndex = 13;
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
            this.btnRetornar.Location = new System.Drawing.Point(46, 664);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(340, 38);
            this.btnRetornar.TabIndex = 15;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // FrmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 750);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.lblValorFranquia);
            this.Controls.Add(this.txbValorProduto);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private Label label6;
        private ComboBox cbDepartamento;
        private ComboBox cbProduto;
        private TextBox txbValorProduto;
        private Label lblValorFranquia;
        private Button btnRetornar;
    }
}