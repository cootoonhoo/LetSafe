namespace LetSafe
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmTelaFunc frmTelaFunc = new FrmTelaFunc();
            frmTelaFunc.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmTelaCliente frmTelaCliente = new FrmTelaCliente();
            frmTelaCliente.Show();
        }
    }
}