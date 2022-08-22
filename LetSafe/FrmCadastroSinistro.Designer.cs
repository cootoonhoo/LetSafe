namespace LetSafe
{
    partial class FrmCadastroSinistro
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
            this.components = new System.ComponentModel.Container();
            this.btnAbrirSinistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.frmCadastroApoliceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbApolices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.frmCadastroApoliceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirSinistro
            // 
            this.btnAbrirSinistro.Location = new System.Drawing.Point(89, 624);
            this.btnAbrirSinistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrirSinistro.Name = "btnAbrirSinistro";
            this.btnAbrirSinistro.Size = new System.Drawing.Size(359, 38);
            this.btnAbrirSinistro.TabIndex = 0;
            this.btnAbrirSinistro.Text = "Confirmar";
            this.btnAbrirSinistro.UseVisualStyleBackColor = true;
            this.btnAbrirSinistro.Click += new System.EventHandler(this.btnAbrirSinistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual é o tipo da ocorrência:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data da ocorrência:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(54, 283);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(225, 31);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id-Apolice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro de Sinistro";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Acidente",
            "Dano funcional",
            "Doença",
            "Incêndio",
            "Morte",
            "Perda parcial",
            "Perda total",
            "Quebra",
            "Reparos",
            "Roubo e Furto"});
            this.comboBox1.Location = new System.Drawing.Point(54, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 33);
            this.comboBox1.TabIndex = 9;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(89, 683);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(359, 38);
            this.btnRetornar.TabIndex = 10;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // frmCadastroApoliceBindingSource
            // 
            this.frmCadastroApoliceBindingSource.DataSource = typeof(LetSafe.FrmCadastroApolice);
            // 
            // cbbApolices
            // 
            this.cbbApolices.FormattingEnabled = true;
            this.cbbApolices.Location = new System.Drawing.Point(54, 404);
            this.cbbApolices.Name = "cbbApolices";
            this.cbbApolices.Size = new System.Drawing.Size(182, 33);
            this.cbbApolices.TabIndex = 11;
            // 
            // FrmCadastroSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 750);
            this.Controls.Add(this.cbbApolices);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirSinistro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCadastroSinistro";
            this.Text = "FrmCadastroSinistro";
            this.Load += new System.EventHandler(this.FrmCadastroSinistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmCadastroApoliceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirSinistro;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button btnRetornar;
        private BindingSource frmCadastroApoliceBindingSource;
        private ComboBox cbbApolices;
    }
}