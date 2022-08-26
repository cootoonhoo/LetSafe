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
    public partial class FrmAreaCliente : Form
    {
        Thread t1;

        public string Cpf { get; set; }

        public FrmAreaCliente()
        {
            InitializeComponent();
        }

        public FrmAreaCliente(string cpf)
        {
            InitializeComponent();

            Cpf = cpf;
        }

        private void btnSinistro_Click(object sender, EventArgs e)
        {
            FrmProgram.openChild(new FrmCadastroSinistro(Cpf));
            this.Close();
            //t1 = new Thread(AbrirFormSinistro);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private async void btnHistorico_Click(object sender, EventArgs e)
        {
            lblCarregandoHistórico.Text = "Carregando histórico ... Aguarde";
            lblCarregandoHistórico.ForeColor = Color.Red;
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblCarregandoHistórico.Text = "Carregado com sucesso";
            lblCarregandoHistórico.ForeColor = Color.Green;
            await Task.Delay(TimeSpan.FromSeconds(1));           
            FrmProgram.openChild((new FrmHistorico(Cpf)));
            this.Close();
            //t1 = new Thread(AbrirFormHistorico);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            FrmProgram.openChild(new FrmConsultarCliente());
            this.Close();
            //t1 = new Thread(AbrirFormTelaCliente);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void AbrirFormSinistro(object obj)
        {
            Application.Run(new FrmCadastroSinistro(Cpf));
        }

        private void AbrirFormHistorico(object obj)
        {
            Application.Run(new FrmHistorico(Cpf));
        }

        private void AbrirFormTelaCliente(object obj)
        {
            Application.Run(new FrmTelaCliente());
        }

        private void FrmAreaCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
