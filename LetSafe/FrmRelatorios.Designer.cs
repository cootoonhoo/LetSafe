namespace LetSafe
{
    partial class FrmRelatorios
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
            this.lblRelatórios = new System.Windows.Forms.Label();
            this.cobRelatorios = new System.Windows.Forms.ComboBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatórios
            // 
            this.lblRelatórios.AutoSize = true;
            this.lblRelatórios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRelatórios.Location = new System.Drawing.Point(12, 19);
            this.lblRelatórios.Name = "lblRelatórios";
            this.lblRelatórios.Size = new System.Drawing.Size(69, 19);
            this.lblRelatórios.TabIndex = 0;
            this.lblRelatórios.Text = "Relatórios";
            // 
            // cobRelatorios
            // 
            this.cobRelatorios.FormattingEnabled = true;
            this.cobRelatorios.Items.AddRange(new object[] {
            "Apolices por segurado",
            "Cidades com maior arrecadacao",
            "Endereco dos segurados",
            "Logradouros por pessoa",
            "Segurados não finaliazdos",
            "Seguros mais procurados",
            "Sinistro por estado",
            "Sinistro por segurado"});
            this.cobRelatorios.Location = new System.Drawing.Point(87, 19);
            this.cobRelatorios.Name = "cobRelatorios";
            this.cobRelatorios.Size = new System.Drawing.Size(175, 23);
            this.cobRelatorios.TabIndex = 1;
            this.cobRelatorios.Text = "Apolices por segurado";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(286, 19);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRelatorio.Location = new System.Drawing.Point(12, 57);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.RowTemplate.Height = 25;
            this.dgvRelatorio.Size = new System.Drawing.Size(606, 291);
            this.dgvRelatorio.TabIndex = 3;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 376);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.cobRelatorios);
            this.Controls.Add(this.lblRelatórios);
            this.Name = "FrmRelatorios";
            this.Text = "FrmRelatorios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRelatórios;
        private ComboBox cobRelatorios;
        private Button btnGerar;
        private DataGridView dgvRelatorio;
    }
}