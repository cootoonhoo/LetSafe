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
    public partial class FrmProgram : Form
    {
        public FrmProgram()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            panelFuncionarioSubMenu.Visible = false;
            panelClienteSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelFuncionarioSubMenu.Visible == true)
                panelFuncionarioSubMenu.Visible = false;
            if (panelClienteSubMenu.Visible == true)
                panelClienteSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFuncionarioSubMenu);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelClienteSubMenu);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            openChild(new FrmRelatorios());
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e) {
            openChild(new FrmCadastroCliente());
        }

        private static Form activeForm = null;
        public static void openChild(Form childForm) 
        {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnConsultaCPF_Click(object sender, EventArgs e)
        {
            openChild(new FrmEditaCliente());
        }

        private void btnCadastrarApolice_Click(object sender, EventArgs e)
        {
            openChild(new FrmCadastroApolice());
        }

        private void btnConsultarCPF_Click(object sender, EventArgs e)
        {
            openChild(new FrmConsultarCliente());
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            openChild(new FrmOrcamento());
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            openChild(new FrmSobre());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja sair mesmo do programa?", "Sair", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
