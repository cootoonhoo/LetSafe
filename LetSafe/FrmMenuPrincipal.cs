namespace LetSafe
{
    public partial class FrmMenuPrincipal : Form
    {
        Thread t1;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormSobre);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormFunc);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormFunc(object obj)
        {
            Application.Run(new FrmTelaFunc());
        }

        private void AbrirFormCliente(object obj)
        {
            Application.Run(new FrmTelaCliente());
        }

        private void AbrirFormSobre(object obj)
        {
            Application.Run(new FrmSobre());
        }
    }
}