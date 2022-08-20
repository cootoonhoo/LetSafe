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

        public FrmCadastroSinistro()
        {
            InitializeComponent();
        }

        private void FrmCadastroSinistro_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmAreaCliente());
        }

        private void btnRetornar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormAnterior);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
