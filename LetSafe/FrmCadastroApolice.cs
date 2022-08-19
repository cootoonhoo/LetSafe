using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LetSafe
{
    public partial class FrmCadastroApolice : Form
    {
        Thread T1;
        public FrmCadastroApolice()
        {
            InitializeComponent();
        }

        private void txbValorSeguro_Enter(object sender, EventArgs e)
        {
            if (txbValorSeguro.Text == "5000,00" || txbValorSeguro.ForeColor == Color.Red) {
                txbValorSeguro.Text = "";
                txbValorSeguro.ForeColor = Color.Black;
            }
        }

        private void txbValorSeguro_Leave(object sender, EventArgs e)
        {
            if (txbValorSeguro.Text == "")
            {
                txbValorSeguro.Text = "5000,00";
                txbValorSeguro.ForeColor = Color.LightGray;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Validacoes()) {
                txbValorSeguro.Text = "Valor inválido";
                txbValorSeguro.ForeColor = Color.Red;
                return;
            }
            DateTime Inicio, Fim;
            decimal Valor;
            Valor = Decimal.Parse(txbValorSeguro.Text);
            Inicio = DateTime.Parse(dtpInicio.Value.ToString());
            Fim = DateTime.Parse(dtpFim.Value.ToString());

            DataBaseCon.CadastrarApolice(Valor, Inicio, Fim);
            NovoCadastro();
        }
        private bool Validacoes() {
            return decimal.TryParse(txbValorSeguro.Text, out _);
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Retornar();
        }
        private void Retornar() {
            T1 = new Thread(FormFunc);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
            this.Close();
        }
        private void FormFunc() {
            Application.Run(new FrmTelaFunc());
        }
        private void NovoCadastro() {
            var result = MessageBox.Show("Você deseja fazer mais um cadastro?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) {
                Retornar();
            }
        }
    }
}
