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
            this.lblCarregandoHistórico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinistro
            // 
            this.btnSinistro.Location = new System.Drawing.Point(220, 101);
            this.btnSinistro.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinistro.Name = "btnSinistro";
            this.btnSinistro.Size = new System.Drawing.Size(110, 20);
            this.btnSinistro.TabIndex = 0;
            this.btnSinistro.Text = "Abrir sinistro";
            this.btnSinistro.UseVisualStyleBackColor = true;
            this.btnSinistro.Click += new System.EventHandler(this.btnSinistro_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(220, 140);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(110, 20);
            this.btnHistorico.TabIndex = 1;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(220, 178);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(110, 20);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // lblCarregandoHistórico
            // 
            this.lblCarregandoHistórico.AutoSize = true;
            this.lblCarregandoHistórico.Location = new System.Drawing.Point(243, 219);
            this.lblCarregandoHistórico.Name = "lblCarregandoHistórico";
            this.lblCarregandoHistórico.Size = new System.Drawing.Size(0, 15);
            this.lblCarregandoHistórico.TabIndex = 3;
            // 
            // FrmAreaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.lblCarregandoHistórico);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnSinistro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAreaCliente";
            this.Text = "Área do cliente";
            this.Load += new System.EventHandler(this.FrmAreaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSinistro;
        private Button btnHistorico;
        private Button btnRetornar;
        private Label lblCarregandoHistórico;
    }
}