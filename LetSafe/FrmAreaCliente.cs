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
        public FrmAreaCliente()
        {
            InitializeComponent();
        }

        private void btnSinistro_Click(object sender, EventArgs e)
        {
            FrmCadastroSinistro frmCadastroSinistro = new FrmCadastroSinistro();
            frmCadastroSinistro.Show();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmHistorico frmHistorico = new FrmHistorico();
            frmHistorico.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
