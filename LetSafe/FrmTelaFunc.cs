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
    public partial class FrmTelaFunc : Form
    {
        Thread t1;

        public FrmTelaFunc()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormCadCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCadApolice_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormCadApolice);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormEditaCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormRelatorio);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormPrincipal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormCadCliente(object obj)
        {
            Application.Run(new FrmCadastroCliente());
        }

        private void AbrirFormCadApolice(object obj)
        {
            Application.Run(new FrmCadastroApolice());
        }

        private void AbrirFormEditaCliente(object obj)
        {
            Application.Run(new FrmEditaCliente());
        }

        private void AbrirFormRelatorio(object obj)
        {
            Application.Run(new FrmRelatorios());
        }

        private void AbrirFormPrincipal(object obj)
        {
            Application.Run(new FrmMenuPrincipal());
        }

        
    }
}
