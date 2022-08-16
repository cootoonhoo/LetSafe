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
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            FrmAreaCliente frmAreaCliente = new FrmAreaCliente();
            frmAreaCliente.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
