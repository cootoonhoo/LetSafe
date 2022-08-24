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
    public partial class FrmTelaCliente : Form
    {
        Thread t1;

        public FrmTelaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultaCpf_Click(object sender, EventArgs e)
        {
            FrmProgram.openChild(new FrmAreaCliente());
            this.Close();
            //t1 = new Thread(AbrirFormCpf);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            FrmProgram.openChild(new FrmOrcamento());
            this.Close();
            //t1 = new Thread(AbrirFormOrcamento);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            //t1 = new Thread(AbrirFormPrincipal);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void AbrirFormCpf(object obj)
        {
            Application.Run(new FrmConsultarCliente());
        }

        private void AbrirFormOrcamento(object obj)
        {
            Application.Run(new FrmOrcamento());
        }

        private void AbrirFormPrincipal(object obj)
        {
            Application.Run(new FrmMenuPrincipal());
        }
    }
}
