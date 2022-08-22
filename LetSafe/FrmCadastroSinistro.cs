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

        public string Cpf { get; set; }

        public FrmCadastroSinistro()
        {
            InitializeComponent();
        }

        public FrmCadastroSinistro(string cpf)
        {
            InitializeComponent();

            Cpf = cpf;
        }

        private void FrmCadastroSinistro_Load(object sender, EventArgs e)
        {
            List<string> list = DataBaseCon.ApolicesSegurado(Cpf);

            foreach (var item in list)
            {
                cbbApolices.Items.Add(item);
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormAnterior);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmAreaCliente());
        }

        private void btnAbrirSinistro_Click(object sender, EventArgs e)
        {

        }

    }
}
