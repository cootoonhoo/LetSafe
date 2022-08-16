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
        public FrmTelaCliente()
        {
            InitializeComponent();
        }

        private void btnAbrirSinistro_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frmConsultarCliente = new FrmConsultarCliente();
            frmConsultarCliente.Show();
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            FrmOrcamento frmOrcamento = new FrmOrcamento();
            frmOrcamento.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
