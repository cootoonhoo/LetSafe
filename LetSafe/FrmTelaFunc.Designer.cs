namespace LetSafe
{
    partial class FrmTelaFunc
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
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadApolice = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(314, 123);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(212, 34);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadApolice
            // 
            this.btnCadApolice.Location = new System.Drawing.Point(314, 188);
            this.btnCadApolice.Name = "btnCadApolice";
            this.btnCadApolice.Size = new System.Drawing.Size(212, 34);
            this.btnCadApolice.TabIndex = 1;
            this.btnCadApolice.Text = "Cadastrar apólice";
            this.btnCadApolice.UseVisualStyleBackColor = true;
            this.btnCadApolice.Click += new System.EventHandler(this.btnCadApolice_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(314, 249);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(212, 34);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // FrmTelaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnCadApolice);
            this.Controls.Add(this.btnCadCliente);
            this.Name = "FrmTelaFunc";
            this.Text = "Funcionário";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadCliente;
        private Button btnCadApolice;
        private Button btnRetornar;
    }
}