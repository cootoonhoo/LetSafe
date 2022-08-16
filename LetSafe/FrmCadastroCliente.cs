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
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void mtbCpf_Click(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "000000000-00") {
                mtbCpf.ForeColor = Color.Black;
                mtbCpf.Text = "";
            }
        }

        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            if (mtbCpf.Text == "         -")
            {
                mtbCpf.ForeColor = Color.LightGray;
                mtbCpf.Text = "000000000-00";
            }
        }

        private void mtbEmail_Click(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "exemplo@exemplo.com")
            {
                mtbEmail.ForeColor = Color.Black;
                mtbEmail.Text = "";
            }
        }

        private void mtbEmail_Leave(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "")
            {
                mtbEmail.ForeColor = Color.LightGray;
                mtbEmail.Text = "exemplo@exemplo.com";
            }
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            if (mtbCep.Text == "     -")
            {
                mtbCep.ForeColor = Color.LightGray;
                mtbCep.Text = "00000-000";
            }
        }

        private void mtbCep_Click(object sender, EventArgs e)
        {
            if (mtbCep.Text == "00000-000")
            {
                mtbCep.ForeColor = Color.Black;
                mtbCep.Text = "";
            }
        }

        private void cobEstado_Leave(object sender, EventArgs e)
        {
            if (!cobEstado.Items.Contains(cobEstado.Text)) {
                cobEstado.Text = "";
            }
        }
    }
}
