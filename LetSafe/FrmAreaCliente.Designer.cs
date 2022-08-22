namespace LetSafe
{
    partial class FrmAreaCliente
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
            this.btnSinistro = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinistro
            // 
            this.btnSinistro.Location = new System.Drawing.Point(314, 168);
            this.btnSinistro.Name = "btnSinistro";
            this.btnSinistro.Size = new System.Drawing.Size(157, 34);
            this.btnSinistro.TabIndex = 0;
            this.btnSinistro.Text = "Abrir sinistro";
            this.btnSinistro.UseVisualStyleBackColor = true;
            this.btnSinistro.Click += new System.EventHandler(this.btnSinistro_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(314, 234);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(157, 34);
            this.btnHistorico.TabIndex = 1;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(314, 297);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(157, 34);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // FrmAreaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnSinistro);
            this.Name = "FrmAreaCliente";
            this.Text = "Área do cliente";
            this.Load += new System.EventHandler(this.FrmAreaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSinistro;
        private Button btnHistorico;
        private Button btnRetornar;
    }
}