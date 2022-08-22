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
    public partial class FrmConsultarCliente : Form
    {
        Thread t1;

        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string cpf = mtxbCpf.Text.Replace("-", "");

            if (DataBaseCon.ClienteCadastrado(cpf))
            {
                this.Close();
                t1 = new Thread(AbrirFormCliente);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                MessageBox.Show("CPF não encontrado!");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormAnterior);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormCliente(object obj)
        {
            string cpf = mtxbCpf.Text.Replace("-", "");
            Application.Run(new FrmAreaCliente(cpf));
        }

        private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmTelaCliente());
        }
    }
}
