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
        public FrmTelaFunc()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.Show();
        }

        private void btnCadApolice_Click(object sender, EventArgs e)
        {
            FrmCadastroApolice frmCadastroApolice = new FrmCadastroApolice();
            frmCadastroApolice.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
