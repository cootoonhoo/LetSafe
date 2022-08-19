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
            this.SuspendLayout();
            // 
            // lblValorSeguro
            // 
            this.lblValorSeguro.AutoSize = true;
            this.lblValorSeguro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorSeguro.Location = new System.Drawing.Point(12, 21);
            this.lblValorSeguro.Name = "lblValorSeguro";
            this.lblValorSeguro.Size = new System.Drawing.Size(106, 19);
            this.lblValorSeguro.TabIndex = 0;
            this.lblValorSeguro.Text = "Valor do seguro";
            // 
            // lblInicioVigencia
            // 
            this.lblInicioVigencia.AutoSize = true;
            this.lblInicioVigencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicioVigencia.Location = new System.Drawing.Point(12, 56);
            this.lblInicioVigencia.Name = "lblInicioVigencia";
            this.lblInicioVigencia.Size = new System.Drawing.Size(96, 19);
            this.lblInicioVigencia.TabIndex = 1;
            this.lblInicioVigencia.Text = "Inicio Vigência";
            // 
            // lblFimVigencia
            // 
            this.lblFimVigencia.AutoSize = true;
            this.lblFimVigencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFimVigencia.Location = new System.Drawing.Point(12, 89);
            this.lblFimVigencia.Name = "lblFimVigencia";
            this.lblFimVigencia.Size = new System.Drawing.Size(86, 19);
            this.lblFimVigencia.TabIndex = 2;
            this.lblFimVigencia.Text = "Fim Vigência";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(230, 125);
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
            this.btnRetornar.Location = new System.Drawing.Point(124, 125);
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
            this.dtpInicio.MaxDate = new System.DateTime(2022, 8, 19, 0, 0, 0, 0);
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
            // FrmCadastroApolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 180);
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
    }
}