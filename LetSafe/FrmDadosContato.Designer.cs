namespace LetSafe
{
    partial class FrmDadosContato
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
            this.lblPreenchaDados = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPreenchaDados
            // 
            this.lblPreenchaDados.AutoSize = true;
            this.lblPreenchaDados.Location = new System.Drawing.Point(62, 36);
            this.lblPreenchaDados.Name = "lblPreenchaDados";
            this.lblPreenchaDados.Size = new System.Drawing.Size(183, 30);
            this.lblPreenchaDados.TabIndex = 0;
            this.lblPreenchaDados.Text = "Preencha seus dados  \r\nEm breve entraremos em contato";
            this.lblPreenchaDados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 93);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(97, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome completo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(116, 235);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmDadosContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 339);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPreenchaDados);
            this.Name = "FrmDadosContato";
            this.Text = "FrmDadosContato";
            this.Load += new System.EventHandler(this.FrmDadosContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPreenchaDados;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblNome;
        private Label lblEmail;
        private Button btnEnviar;
    }
}