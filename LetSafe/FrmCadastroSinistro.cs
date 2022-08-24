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
    public partial class FrmCadastroSinistro : Form
    {
        Thread t1;

        public string Cpf { get; set; }

        public FrmCadastroSinistro()
        {
            InitializeComponent();
        }

        public FrmCadastroSinistro(string cpf)
        {
            InitializeComponent();

            Cpf = cpf;
        }

        private void FrmCadastroSinistro_Load(object sender, EventArgs e)
        {
            cbbApolices.Items.Clear();
            cbbApolices.DataSource = DataBaseCon.ConsultaApolicesSegurados(Cpf);
            cbbApolices.DisplayMember = "nome_produto";
            cbbApolices.ValueMember = "id_apolice";
            



            //List<string> list = DataBaseCon.ApolicesSegurado(Cpf);

            //foreach (var item in list)
            //{
            //    cbbApolices.Items.Add(item);
            //}
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
            Application.Run(new FrmAreaCliente(Cpf));
        }

        private void btnAbrirSinistro_Click(object sender, EventArgs e)
        {
            CadastrarDadosSinistroNoBanco();
            MessageBox.Show("Sinistro cadastrado com sucesso", "Cadastro efetuado", MessageBoxButtons.OK);
        }

        private void cbbApolices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTipoOcorrencia.Items.Clear();
            switch (cbbApolices.Text)
            {
                case "Carro":
                case "Moto":
                case "Caminhao":
                    string[] veiculos = new string[] { "Acidente", "Dano funcional", "Perda parcial", "Perda total", "Roubo e Furto" };
                    cbbTipoOcorrencia.Items.AddRange(veiculos);
                    break;
                case "SeguroAcidente":
                case "SeguroPatrimonio":
                case "SeguroViagem":
                case "SeguroVida":
                    string[] pessoal = new string[] { "Acidente", "Doença", "Morte" };
                    cbbTipoOcorrencia.Items.AddRange(pessoal);
                    break;
                case "Apartamento":
                case "Casa":
                case "Escritório":
                case "Fazenda":
                    string[] residencial = new string[] { "Incêndio", "Quebra", "Reparos", "Roubo e Furto" };
                    cbbTipoOcorrencia.Items.AddRange(residencial);
                    break;
                case "Celular":
                case "Computador":
                case "Notebook":
                case "Smartwatch":
                case "Tablet":
                    string[] eletronico = new string[] { "Acidente", "Dano funcional", "Quebra", "Reparos", "Roubo e Furto" };
                    cbbTipoOcorrencia.Items.AddRange(eletronico);
                    break;
            }


        }

        private void CadastrarDadosSinistroNoBanco()
        {
            string tipoOcorrencia = cbbTipoOcorrencia.Text;
            DateTime dataOcorrencia = DateTime.Parse(dtpDataOcorrencia.Value.ToString());
            int idApolice = Convert.ToInt32(cbbApolices.SelectedValue);
            DataBaseCon.CadastrarSInistro(tipoOcorrencia, dataOcorrencia, idApolice);

        }

        private void cb_TipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}


