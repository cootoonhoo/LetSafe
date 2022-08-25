namespace LetSafe
{
    partial class FrmUpdateCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtbLogradouro = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.mtbComplemento = new System.Windows.Forms.MaskedTextBox();
            this.mtbBairro = new System.Windows.Forms.MaskedTextBox();
            this.mtbCidade = new System.Windows.Forms.MaskedTextBox();
            this.cobEstado = new System.Windows.Forms.ComboBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(19, 77);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 28);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.Location = new System.Drawing.Point(19, 125);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 28);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblemail.Location = new System.Drawing.Point(19, 173);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(59, 28);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogradouro.Location = new System.Drawing.Point(19, 222);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(116, 28);
            this.lblLogradouro.TabIndex = 3;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(19, 270);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(84, 28);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplemento.Location = new System.Drawing.Point(17, 320);
            this.lblComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(137, 28);
            this.lblComplemento.TabIndex = 5;
            this.lblComplemento.Text = "Complemento";
            this.lblComplemento.Enter += new System.EventHandler(this.lblComplemento_Enter);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(20, 368);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(64, 28);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.Location = new System.Drawing.Point(19, 417);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(73, 28);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(17, 465);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 28);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.Location = new System.Drawing.Point(19, 513);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(45, 28);
            this.lblCep.TabIndex = 9;
            this.lblCep.Text = "CEP";
            // 
            // mtbNome
            // 
            this.mtbNome.Location = new System.Drawing.Point(164, 77);
            this.mtbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(291, 31);
            this.mtbNome.TabIndex = 10;
            this.mtbNome.Enter += new System.EventHandler(this.mtbNome_Enter);
            // 
            // mtbCpf
            // 
            this.mtbCpf.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtbCpf.Location = new System.Drawing.Point(164, 125);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbCpf.Mask = "000000000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(291, 31);
            this.mtbCpf.TabIndex = 11;
            this.mtbCpf.Text = "00000000000";
            this.mtbCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCpf_MaskInputRejected);
            this.mtbCpf.Click += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.Enter += new System.EventHandler(this.mtbCpf_Click);
            this.mtbCpf.Leave += new System.EventHandler(this.mtbCpf_Leave);
            // 
            // mtbEmail
            // 
            this.mtbEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtbEmail.Location = new System.Drawing.Point(164, 173);
            this.mtbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.Size = new System.Drawing.Size(291, 31);
            this.mtbEmail.TabIndex = 12;
            this.mtbEmail.Text = "exemplo@exemplo.com";
            this.mtbEmail.Click += new System.EventHandler(this.mtbEmail_Click);
            this.mtbEmail.Leave += new System.EventHandler(this.mtbEmail_Leave);
            // 
            // mtbLogradouro
            // 
            this.mtbLogradouro.Location = new System.Drawing.Point(164, 222);
            this.mtbLogradouro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbLogradouro.Name = "mtbLogradouro";
            this.mtbLogradouro.Size = new System.Drawing.Size(291, 31);
            this.mtbLogradouro.TabIndex = 13;
            this.mtbLogradouro.Enter += new System.EventHandler(this.mtbLogradouro_Enter);
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(164, 270);
            this.mtbNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(291, 31);
            this.mtbNumero.TabIndex = 14;
            this.mtbNumero.Enter += new System.EventHandler(this.mtbNumero_Enter);
            // 
            // mtbComplemento
            // 
            this.mtbComplemento.Location = new System.Drawing.Point(164, 320);
            this.mtbComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbComplemento.Name = "mtbComplemento";
            this.mtbComplemento.Size = new System.Drawing.Size(291, 31);
            this.mtbComplemento.TabIndex = 15;
            this.mtbComplemento.Enter += new System.EventHandler(this.lblComplemento_Enter);
            // 
            // mtbBairro
            // 
            this.mtbBairro.Location = new System.Drawing.Point(164, 368);
            this.mtbBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbBairro.Name = "mtbBairro";
            this.mtbBairro.Size = new System.Drawing.Size(291, 31);
            this.mtbBairro.TabIndex = 16;
            this.mtbBairro.Enter += new System.EventHandler(this.mtbBairro_Enter);
            // 
            // mtbCidade
            // 
            this.mtbCidade.Location = new System.Drawing.Point(164, 417);
            this.mtbCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbCidade.Name = "mtbCidade";
            this.mtbCidade.Size = new System.Drawing.Size(291, 31);
            this.mtbCidade.TabIndex = 17;
            this.mtbCidade.Enter += new System.EventHandler(this.mtbCidade_Enter);
            // 
            // cobEstado
            // 
            this.cobEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobEstado.FormattingEnabled = true;
            this.cobEstado.Items.AddRange(new object[] {
            "Acre(AC)",
            "Alagoas(AL)",
            "Amapá(AP)",
            "Amazonas(AM)",
            "Bahia(BA)",
            "Ceará(CE)",
            "Distrito Federal(DF)",
            "Espírito Santo(ES)",
            "Goiás(GO)",
            "Maranhão(MA)",
            "Mato Grosso(MT)",
            "Mato Grosso do Sul(MS)",
            "Minas Gerais(MG)",
            "Pará(PA)",
            "Paraíba(PB)",
            "Paraná(PR)",
            "Pernambuco(PE)",
            "Piauí(PI)",
            "Rio de Janeiro(RJ)",
            "Rio Grande do Norte(RN)",
            "Rio Grande do Sul(RS)",
            "Rondônia(RO)",
            "Roraima(RR)",
            "Santa Catarina(SC)",
            "São Paulo(SP)",
            "Sergipe(SE)",
            "Tocantins(TO)"});
            this.cobEstado.Location = new System.Drawing.Point(164, 465);
            this.cobEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobEstado.Name = "cobEstado";
            this.cobEstado.Size = new System.Drawing.Size(291, 33);
            this.cobEstado.TabIndex = 18;
            this.cobEstado.Leave += new System.EventHandler(this.cobEstado_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.mtbCep.Location = new System.Drawing.Point(164, 513);
            this.mtbCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(291, 31);
            this.mtbCep.TabIndex = 19;
            this.mtbCep.Text = "00000000";
            this.mtbCep.Click += new System.EventHandler(this.mtbCep_Click);
            this.mtbCep.Enter += new System.EventHandler(this.mtbCep_Enter);
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.Location = new System.Drawing.Point(334, 583);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(123, 65);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(203, 583);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 65);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastro.Location = new System.Drawing.Point(17, 15);
            this.lblCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(342, 45);
            this.lblCadastro.TabIndex = 22;
            this.lblCadastro.Text = "Cadastrar novo Cliente";
            // 
            // FrmUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 690);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.cobEstado);
            this.Controls.Add(this.mtbCidade);
            this.Controls.Add(this.mtbBairro);
            this.Controls.Add(this.mtbComplemento);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.mtbLogradouro);
            this.Controls.Add(this.mtbEmail);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.mtbNome);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUpdateCliente";
            this.Text = "Atualizar cliente";
            this.Load += new System.EventHandler(this.FrmUpdateCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private Label lblemail;
        private Label lblLogradouro;
        private Label lblNumero;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblCep;
        private MaskedTextBox mtbNome;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbEmail;
        private MaskedTextBox mtbLogradouro;
        private MaskedTextBox mtbNumero;
        private MaskedTextBox mtbComplemento;
        private MaskedTextBox mtbBairro;
        private MaskedTextBox mtbCidade;
        private ComboBox cobEstado;
        private MaskedTextBox mtbCep;
        private Button btnAtualizar;
        private Button btnCancelar;
        private Label lblCadastro;
    }
}