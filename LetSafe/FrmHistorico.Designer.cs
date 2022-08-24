namespace LetSafe
{
    partial class FrmHistorico
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.dgvApolice = new System.Windows.Forms.DataGridView();
            this.dgvSinistro = new System.Windows.Forms.DataGridView();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApolice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seus Dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suas Apolices:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suas Sinistros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seus Endereços:";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(25, 522);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(89, 38);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // dgvApolice
            // 
            this.dgvApolice.AllowUserToAddRows = false;
            this.dgvApolice.AllowUserToDeleteRows = false;
            this.dgvApolice.AllowUserToResizeColumns = false;
            this.dgvApolice.AllowUserToResizeRows = false;
            this.dgvApolice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvApolice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApolice.Location = new System.Drawing.Point(25, 294);
            this.dgvApolice.Name = "dgvApolice";
            this.dgvApolice.RowTemplate.Height = 25;
            this.dgvApolice.Size = new System.Drawing.Size(539, 94);
            this.dgvApolice.TabIndex = 9;
            // 
            // dgvSinistro
            // 
            this.dgvSinistro.AllowUserToAddRows = false;
            this.dgvSinistro.AllowUserToDeleteRows = false;
            this.dgvSinistro.AllowUserToResizeColumns = false;
            this.dgvSinistro.AllowUserToResizeRows = false;
            this.dgvSinistro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSinistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinistro.Location = new System.Drawing.Point(25, 425);
            this.dgvSinistro.Name = "dgvSinistro";
            this.dgvSinistro.RowTemplate.Height = 25;
            this.dgvSinistro.Size = new System.Drawing.Size(350, 92);
            this.dgvSinistro.TabIndex = 10;
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AllowUserToResizeColumns = false;
            this.dgvEndereco.AllowUserToResizeRows = false;
            this.dgvEndereco.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Location = new System.Drawing.Point(25, 179);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.RowTemplate.Height = 25;
            this.dgvEndereco.Size = new System.Drawing.Size(631, 82);
            this.dgvEndereco.TabIndex = 11;
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblDadosCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDadosCliente.Location = new System.Drawing.Point(25, 44);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(52, 21);
            this.lblDadosCliente.TabIndex = 12;
            this.lblDadosCliente.Text = "dados";
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 564);
            this.Controls.Add(this.lblDadosCliente);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.dgvSinistro);
            this.Controls.Add(this.dgvApolice);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHistorico";
            this.Text = "FrmHistorico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApolice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRetornar;
        private DataGridView dgvApolice;
        private DataGridView dgvSinistro;
        private DataGridView dgvEndereco;
        private Label lblDadosCliente;
    }
}