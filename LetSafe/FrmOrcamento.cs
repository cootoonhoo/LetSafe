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
        Thread t1;

        public FrmOrcamento()
        {
            InitializeComponent();
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
                    string[] produtosVeiculos = new string[] { "Caminhao", "Carro", "Moto"};
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

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valorDoProduto = Convert.ToDecimal(txbValorProduto.Text);
            decimal valorFranquia = valorDoProduto * 0.2m;
            lblValorFranquia.Text = valorFranquia.ToString("C2");
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormAnterior);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmTelaCliente());
        }
    }
}
