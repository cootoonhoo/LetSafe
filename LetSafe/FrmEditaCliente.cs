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
    public partial class FrmEditaCliente : Form
    {
        Thread t1;

        public FrmEditaCliente()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var cpf = mtbCpf.Text.Replace("-", "");
            dgvCliente.DataSource = DataBaseCon.ConsultaCliente(cpf);

            if (dgvCliente.Rows.Count == 1)
            {
                MessageBox.Show("Nenhum cliente encontrado.");
            }
            else
            {
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirTelaFunc);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirTelaFunc(object obj)
        {
            Application.Run(new FrmTelaFunc());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //criar função para update de dados
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cpf = mtbCpf.Text.ToString();
            var msgAlerta = MessageBox.Show("Deseja mesmo excluir este cliente?", "Alerta!!", MessageBoxButtons.YesNo);

            if (msgAlerta == DialogResult.Yes)
            {
                DataBaseCon.DeletaCliente(cpf);
            }
        }
    }
}
