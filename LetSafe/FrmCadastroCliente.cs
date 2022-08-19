using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetSafe
{
    public partial class FrmCadastroCliente : Form
    {
        Dictionary<String, String> Estados = new();
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            Estados.Add("Acre(AC)","AC");
            Estados.Add("Alagoas(AL)", "AL");
            Estados.Add("Amapá(AP)", "AP");
            Estados.Add("Amazonas(AM)", "AM");
            Estados.Add("Ceará(CE)", "Ce");
            Estados.Add("Distrito Federal(DF)", "DF");
            Estados.Add("Espírito Santo(ES)", "ES");
            Estados.Add("Mato Grosso(MT)", "MT");
            Estados.Add("Mato Grosso do Sul(MS)", "MS");
            Estados.Add("Minas Gerais(MG)", "MG");
            Estados.Add("Pará(PA)", "PA");
            Estados.Add("Paraíba(PB)", "PB");
            Estados.Add("Paraná(PR)", "PR");
            Estados.Add("Pernambuco(PE)", "PE");
            Estados.Add("Piauí(PI)", "PI");
            Estados.Add("Rio de Janeiro(RJ)", "RJ");
            Estados.Add("Rio Grande do Norte(RN)", "RN");
            Estados.Add("Rio Grande do Sul(RS)", "RS");
            Estados.Add("Roraima(RR)", "RR");
            Estados.Add("Santa Catarina(SC)", "SC");
            Estados.Add("São Paulo(SP)", "RR");
            Estados.Add("Sergipe(SE)", "SE");
            Estados.Add("Tocantins(TO)", "TO");           
        }
        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "000000000-00") {
                mtbCpf.ForeColor = Color.Black;
                mtbCpf.Text = "";
            }
            if (mtbCpf.ForeColor == Color.Red) {
                mtbCpf.ForeColor = Color.Black;
                mtbCpf.Text = "";
            }
        }

        private void mtbEmail_Leave(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "")
            {
                mtbEmail.ForeColor = Color.LightGray;
                mtbEmail.Text = "exemplo@exemplo.com";
            }
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {

        }

        private void mtbCep_Click(object sender, EventArgs e)
        {
            if (mtbCep.Text == "00000-000")
            {
                mtbCep.ForeColor = Color.Black;
                mtbCep.Text = "";
            }
        }

        private void cobEstado_Leave(object sender, EventArgs e)
        {
            if (!cobEstado.Items.Contains(cobEstado.Text)) {
                cobEstado.Text = "";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool validacao = Verificacao();
            if (!validacao) return;
            CadastrarDadosNoBanco();

            var result = MessageBox.Show("Você deseja cadastrar uma apolice?", "Teste", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Thread T1 = new Thread(CadastroApolice);
            }
            else {
                this.Close();
                Thread T1 = new Thread(Return);
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread T1 = new Thread(Return);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }
        private void mtbNome_Enter(object sender, EventArgs e)
        {
            if (mtbNome.ForeColor == Color.Red) {
                mtbNome.Text = "";
                mtbNome.ForeColor = Color.Black;
            }
        }

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "         -")
            {
                mtbCpf.ForeColor = Color.LightGray;
                mtbCpf.Text = "000000000-00";
            }
        }
        private void mtbEmail_Click(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "exemplo@exemplo.com")
            {
                mtbEmail.ForeColor = Color.Black;
                mtbEmail.Text = "";
            }
            if (mtbEmail.ForeColor == Color.Red) {
                mtbEmail.ForeColor = Color.Black;
                mtbEmail.Text = "";
            }
        }
        private bool Verificacao() {
            Regex rxEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            bool aux = true;
            if (String.IsNullOrEmpty(mtbNome.Text)) {
                aux = false;
                mtbNome.ForeColor = Color.Red;
                mtbNome.Text = "Nome inválido";
            }
            if (!int.TryParse(mtbCpf.Text, out _))
            {
                aux = false;
                mtbCpf.ForeColor = Color.Red;
                mtbCpf.Text = "Cpf inválido";
            }
            if (!rxEmail.IsMatch(mtbEmail.Text))
            {
                aux = false;
                mtbEmail.ForeColor = Color.Red;
                mtbEmail.Text = "Email inválido";
            }
            if (!int.TryParse(mtbNumero.Text, out _))
            {
                aux = false;
                mtbNumero.ForeColor = Color.Red;
                mtbNumero.Text = "Numero inválido";
            }
            if (String.IsNullOrEmpty(mtbComplemento.Text))
            {
                aux = false;
                mtbComplemento.ForeColor = Color.Red;
                mtbComplemento.Text = "Complemento inválido";
            }
            if (String.IsNullOrEmpty(mtbBairro.Text))
            {
                aux = false;
                mtbBairro.ForeColor = Color.Red;
                mtbBairro.Text = "Bairro inválido";
            }
            if (String.IsNullOrEmpty(mtbCidade.Text))
            {
                aux = false;
                mtbCidade.ForeColor = Color.Red;
                mtbCidade.Text = "Cidade inválida";
            }
            if (String.IsNullOrEmpty(mtbLogradouro.Text))
            {
                aux = false;
                mtbLogradouro.ForeColor = Color.Red;
                mtbLogradouro.Text = "Logradouro inválido";
            }
            return aux;
        }
        private void CadastrarDadosNoBanco() {
            string nome, cpf, email;
            nome = mtbNome.Text;
            cpf = mtbCpf.Text;
            email = mtbEmail.Text;
            DataBaseCon.CadastrarSegurado(nome, cpf, email);

            string logradouro, complemento, bairro, cidade, estado, cep;
            int numero = int.Parse(mtbNumero.Text);

            logradouro = mtbLogradouro.Text;
            complemento = mtbComplemento.Text;
            cidade = mtbCidade.Text;
            bairro = mtbBairro.Text;
            cep = mtbCep.Text;
            estado = Estados[cobEstado.Text];

            DataBaseCon.CadastrarEndereco(logradouro, numero, complemento, bairro, cidade, estado, cep);
        }
        private void Return() {
            Application.Run(new FrmTelaFunc());
        }
        private void CadastroApolice() {
            Application.Run(new FrmCadastroApolice());
        }

        private void mtbLogradouro_Enter(object sender, EventArgs e)
        {
            if (mtbLogradouro.ForeColor == Color.Red) {
                mtbLogradouro.Text = "";
                mtbLogradouro.ForeColor = Color.Black;
            }
        }

        private void mtbNumero_Enter(object sender, EventArgs e)
        {
            if (mtbNumero.ForeColor == Color.Red) {
                mtbNumero.Text = "";
                mtbNumero.ForeColor = Color.Black;
            }
        }

        private void lblComplemento_Enter(object sender, EventArgs e)
        {
            if (mtbComplemento.ForeColor == Color.Red)
            {
                mtbComplemento.Text = "";
                mtbComplemento.ForeColor = Color.Black;
            }
        }

        private void mtbBairro_Enter(object sender, EventArgs e)
        {
            if (mtbBairro.ForeColor == Color.Red)
            {
                mtbBairro.Text = "";
                mtbBairro.ForeColor = Color.Black;
            }
        }

        private void mtbCep_Enter(object sender, EventArgs e)
        {
            if (mtbCep.ForeColor == Color.Red)
            {
                mtbCep.Text = "";
                mtbCep.ForeColor = Color.Black;
            }
        }

        private void mtbCidade_Enter(object sender, EventArgs e)
        {
            if (mtbCidade.ForeColor == Color.Red)
            {
                mtbCidade.Text = "";
                mtbCidade.ForeColor = Color.Black;
            }
        }
    }
}
