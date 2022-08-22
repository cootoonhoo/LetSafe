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
using System.Text.RegularExpressions;

namespace LetSafe
{
    public partial class FrmCadastroApolice : Form
    {
        Dictionary<string, int> TipoProdutos = new Dictionary<string, int>();
        Thread T1;
        public FrmCadastroApolice()
        {
            InitializeComponent();
        }

        private void txbValorSeguro_Enter(object sender, EventArgs e)
        {
            if (txbValorSeguro.Text == "5000,00" || txbValorSeguro.ForeColor == Color.Red)
            {
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
            int IdProduto = 0;
            if (cobProduto.Text.Contains("Não")) cobProduto.Text = "Não";
            else cobProduto.Text = "Sim";

            if (!Validacoes())
            {
                txbValorSeguro.Text = "Valor inválido";
                txbValorSeguro.ForeColor = Color.Red;
                return;
            }
            DateTime Inicio, Fim;
            decimal Valor;
            Valor = Decimal.Parse(txbValorSeguro.Text);
            Inicio = DateTime.Parse(dtpInicio.Value.ToString());
            Fim = DateTime.Parse(dtpFim.Value.ToString());

            if (cobProduto.Text == ("Não"))
            {
                
            }
            else
            {
                string Numero = cobListaProdutos.Text.Replace(" ", "").Split("-")[0];
                IdProduto = int.Parse(Numero);
            }

            DataBaseCon.CadastrarApolice(Valor, Inicio, Fim, DataBaseCon.IdSeguradoPorCpf(mtbCpf.Text), IdProduto);
            NovoCadastro();
        }
        private bool Validacoes()
        {
            Regex rxCpf = new Regex(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
            string cpf = mtbCpf.Text.Replace("-", "");
            if (!decimal.TryParse(txbValorSeguro.Text, out _)) return false;
            if (dtpInicio.Value.Date < DateTime.Now.Date) return false;
            if (dtpFim.Value <= DateTime.Now) return false;
            if (mtbCpf.Text.Contains(" ")) return false;
            if (!rxCpf.IsMatch(cpf)) return false;
            if (cobProduto.Text != "Sim" && cobListaProdutos.Text != "Não") return false;
            if (cobProduto.Text == "Não")
            {
                if (!decimal.TryParse(txbValor.Text, out _)) return false;
                if (!TipoProdutos.ContainsKey(cobTipoProduto.Text)) return false;
            }
            return true;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Retornar();
        }
        private void Retornar()
        {
            T1 = new Thread(FormFunc);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
            this.Close();
        }
        private void FormFunc()
        {
            Application.Run(new FrmTelaFunc());
        }
        private void NovoCadastro()
        {
            var result = MessageBox.Show("Você deseja fazer mais um cadastro?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Retornar();
            }
        }

        private void FrmCadastroApolice_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (var depto in DataBaseCon.TiposProdutos())
            {
                TipoProdutos.Add(depto, i);
                i++;
            }
            cobTipoProduto.Items.Clear();
            foreach (var item in TipoProdutos)
            {
                cobTipoProduto.Items.Add(item.Key);
            }
        }

        private void mtbCpf_Enter(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "000000000-00")
            {
                mtbCpf.ForeColor = Color.Black;
                mtbCpf.Text = "";
            }
            if (mtbCpf.ForeColor == Color.Red)
            {
                mtbCpf.ForeColor = Color.Black;
                mtbCpf.Text = "";
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

        private void cobProduto_Enter(object sender, EventArgs e)
        {
            if (cobProduto.Text.Contains("Não")) cobProduto.Text = "Não";
            else cobProduto.Text = "Sim";
        }

        private void cobProduto_Leave(object sender, EventArgs e)
        {
            if (cobProduto.Text.Contains("Não"))
            {
                cobProduto.Text = "Não";
            }
            else
            {
                cobProduto.Text = "Sim";
            }
        }

        private void txbValor_Enter(object sender, EventArgs e)
        {
            if (txbValor.Text == "5000,00")
            {
                txbValor.Text = "";
                txbValor.ForeColor = Color.Black;
            }
        }

        private void txbValor_Leave(object sender, EventArgs e)
        {
            if (txbValor.Text == "")
            {
                txbValor.Text = "5000,00";
                txbValor.ForeColor = Color.LightGray;
            }
        }
        private void RespostaSim()
        {
            cobListaProdutos.Enabled = true;
            txbNomeProduto.Enabled = false;
            txbValor.Enabled = false;
            cobTipoProduto.Enabled = false;
        }
        private void RespostaNao()
        {
            cobListaProdutos.Enabled = false;
            txbNomeProduto.Enabled = true;
            txbValor.Enabled = true;
            cobTipoProduto.Enabled = true;
        }

        private void cobProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobProduto.Text == "Sim")
            {
                RespostaSim();

                if (mtbCpf.Text == "000000000-00" || mtbCpf.Text.Contains(" "))
                {
                    cobListaProdutos.Text = "CPF inválido";
                    return;
                }
                cobListaProdutos.Items.Clear();
                List<string> lista = DataBaseCon.ApolicesSegurado(mtbCpf.Text.Replace("-", ""));
                foreach (var item in lista)
                    cobListaProdutos.Items.Add(item);
                if (lista.Count == 0) cobListaProdutos.Items.Add("Nenhum produto encotrado");
            }
            else if (cobProduto.Text == "Não")
            {
                RespostaNao();
            }
        }
    }
}
