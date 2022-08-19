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
        public FrmAreaCliente()
        {
            InitializeComponent();
        }

        private void btnSinistro_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormSinistro);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormHistorico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormTelaCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormSinistro(object obj)
        {
            Application.Run(new FrmCadastroSinistro());
        }

        private void AbrirFormHistorico(object obj)
        {
            Application.Run(new FrmHistorico());
        }

        private void AbrirFormTelaCliente(object obj)
        {
            Application.Run(new FrmTelaCliente());
        }
    }
}
