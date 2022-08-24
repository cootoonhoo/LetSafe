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
    public partial class FrmHistorico : Form
    {
        Thread t1;

        public string Cpf { get; set; }

        public FrmHistorico()
        {
            InitializeComponent();
        }

        public FrmHistorico(string cpf)
        {
            InitializeComponent();

            Cpf = cpf;

            dgvEndereco.DataSource = DataBaseCon.ResgatarEndereco(cpf);
            dgvApolice.DataSource = DataBaseCon.ResgatarApolice(cpf);
            dgvSinistro.DataSource = DataBaseCon.ResgatarSinistro(cpf);

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
            Application.Run(new FrmAreaCliente(Cpf));
        }

       
    }
}
