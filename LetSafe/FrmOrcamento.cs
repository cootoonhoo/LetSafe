using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetSafe
{
    public partial class FrmOrcamento : Form
    {
        public FrmOrcamento()
        {
            InitializeComponent();
            txbValorProduto.Text = " ";
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProduto.Items.Clear();
            cbProduto.Text = String.Empty;
            switch (cbDepartamento.Text)
            {
                case "Eletrônicos":
                    string [] produtosEletronicos = new string[] { "Celular", "Computador", "Notebook", "Smartwatch", "Tablet" };
                    cbProduto.Items.AddRange(produtosEletronicos);
                    break;
                case "Veículos":
                    string[] produtosVeiculos = new string[] { "Caminhão", "Carro", "Moto"};
                    cbProduto.Items.AddRange(produtosVeiculos);
                    break;
                case "Residencial":
                    string[] produtosResidencial = new string[] { "Apartamento", "Casa", "Escritório", "Fazenda", "Prédio" };
                    cbProduto.Items.AddRange(produtosResidencial);
                    break;
                case "Pessoais":
                    string[] produtosPessoais = new string[] { "Seguro Acidente", "Seguro Patrimonio", "Seguro Viagem", "Seguro Vida" };
                    cbProduto.Items.AddRange(produtosPessoais);
                    break;
            }
            
        }

        private void btnRealizarOrcamento_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cbProduto.Text) && !String.IsNullOrEmpty(cbDepartamento.Text) && !String.IsNullOrWhiteSpace(txbValorProduto.Text))
            {
                decimal valorDoProduto = Convert.ToDecimal(txbValorProduto.Text);
                decimal valorSeguro12x = (valorDoProduto * 0.2m) / 12;
                decimal valorFranquia = valorDoProduto * 0.1m;
                lblValorSeguro.Text = "(12x) " + valorSeguro12x.ToString("C2");
                lblValorFranquia.Text = valorFranquia.ToString("C2");
                lblRealizarCadastro.Text = "Realizar Cadastro";
            }           
        }
      

        private void txbValorProduto_TextAlignChanged(object sender, EventArgs e)
        {

            string valorInserido = txbValorProduto.Text;
            bool ConvertendoValor = decimal.TryParse(valorInserido, out decimal valorProd);
            if (!ConvertendoValor && String.IsNullOrEmpty(txbValorProduto.Text))
            {
                MessageBox.Show("Só é possível inserir números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == ','|| e.KeyChar == 0x0008))
            {
                txbValorProduto.Text = String.Empty;
                MessageBox.Show("Só é possível inserir números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = ' ';
            }
            
        }

        public void DadosContato()
        {
            Application.Run(new FrmDadosContato());
        }

        public void TelaCliente()
        {
            Application.Run(new FrmTelaCliente());
        }
        private void lblRealizarCadastro_Click(object sender, EventArgs e)
        {

            Thread T1 = new Thread(DadosContato);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
            this.Close();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(TelaCliente);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
            this.Close();
        }
    }
}
