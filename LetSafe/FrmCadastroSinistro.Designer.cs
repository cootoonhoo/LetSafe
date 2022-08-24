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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTipoOcorrencia = new System.Windows.Forms.ComboBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.frmCadastroApoliceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbApolices = new System.Windows.Forms.ComboBox();
            this.dtpDataOcorrencia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.frmCadastroApoliceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirSinistro
            // 
            this.btnAbrirSinistro.Location = new System.Drawing.Point(62, 374);
            this.btnAbrirSinistro.Name = "btnAbrirSinistro";
            this.btnAbrirSinistro.Size = new System.Drawing.Size(251, 23);
            this.btnAbrirSinistro.TabIndex = 0;
            this.btnAbrirSinistro.Text = "Confirmar";
            this.btnAbrirSinistro.UseVisualStyleBackColor = true;
            this.btnAbrirSinistro.Click += new System.EventHandler(this.btnAbrirSinistro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual é o tipo da ocorrência:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data da ocorrência:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registro de Sinistro";
            // 
            // cbbTipoOcorrencia
            // 
            this.cbbTipoOcorrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoOcorrencia.FormattingEnabled = true;
            this.cbbTipoOcorrencia.Items.AddRange(new object[] {
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
            this.cbbTipoOcorrencia.Location = new System.Drawing.Point(39, 196);
            this.cbbTipoOcorrencia.Name = "cbbTipoOcorrencia";
            this.cbbTipoOcorrencia.Size = new System.Drawing.Size(151, 23);
            this.cbbTipoOcorrencia.TabIndex = 9;
            this.cbbTipoOcorrencia.SelectedIndexChanged += new System.EventHandler(this.cb_TipoProduto_SelectedIndexChanged);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(62, 410);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(251, 23);
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
            this.cbbApolices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbApolices.FormattingEnabled = true;
            this.cbbApolices.Location = new System.Drawing.Point(39, 96);
            this.cbbApolices.Margin = new System.Windows.Forms.Padding(2);
            this.cbbApolices.Name = "cbbApolices";
            this.cbbApolices.Size = new System.Drawing.Size(151, 23);
            this.cbbApolices.TabIndex = 11;
            this.cbbApolices.SelectedIndexChanged += new System.EventHandler(this.cbbApolices_SelectedIndexChanged);
            // 
            // dtpDataOcorrencia
            // 
            this.dtpDataOcorrencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOcorrencia.Location = new System.Drawing.Point(39, 144);
            this.dtpDataOcorrencia.MinDate = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            this.dtpDataOcorrencia.Name = "dtpDataOcorrencia";
            this.dtpDataOcorrencia.Size = new System.Drawing.Size(151, 23);
            this.dtpDataOcorrencia.TabIndex = 12;
            this.dtpDataOcorrencia.Value = new System.DateTime(2022, 8, 23, 0, 0, 0, 0);
            // 
            // FrmCadastroSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.dtpDataOcorrencia);
            this.Controls.Add(this.cbbApolices);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cbbTipoOcorrencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbrirSinistro);
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
        private Label label3;
        private Label label4;
        private ComboBox cbbTipoOcorrencia;
        private Button btnRetornar;
        private BindingSource frmCadastroApoliceBindingSource;
        private ComboBox cbbApolices;
        private DateTimePicker dtpDataOcorrencia;
    }
}