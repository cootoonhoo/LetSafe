namespace LetSafe
{
    partial class FrmTelaCliente
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
            this.btnConsultaCpf = new System.Windows.Forms.Button();
            this.btnOrcamento = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaCpf
            // 
            this.btnConsultaCpf.Location = new System.Drawing.Point(310, 154);
            this.btnConsultaCpf.Name = "btnConsultaCpf";
            this.btnConsultaCpf.Size = new System.Drawing.Size(181, 34);
            this.btnConsultaCpf.TabIndex = 0;
            this.btnConsultaCpf.Text = "Consultar por CPF";
            this.btnConsultaCpf.UseVisualStyleBackColor = true;
            this.btnConsultaCpf.Click += new System.EventHandler(this.btnConsultaCpf_Click);
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.Location = new System.Drawing.Point(310, 208);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(181, 34);
            this.btnOrcamento.TabIndex = 1;
            this.btnOrcamento.Text = "Orçamento";
            this.btnOrcamento.UseVisualStyleBackColor = true;
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(310, 270);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(181, 34);
            this.btnRetornar.TabIndex = 3;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // FrmTelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnOrcamento);
            this.Controls.Add(this.btnConsultaCpf);
            this.Name = "FrmTelaCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConsultaCpf;
        private Button btnOrcamento;
        private Button btnRetornar;
    }
}