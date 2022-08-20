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
    public partial class FrmDadosContato : Form
    {
        public FrmDadosContato()
        {
            InitializeComponent();
        }

        private void FrmDadosContato_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(lblEmail.Text) || !String.IsNullOrWhiteSpace(txtNome.Text))
            {
                var resultado = MessageBox.Show("Dados enviados com sucesso\nAguarde nosso contato", "Enviando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            
            else
            {
                MessageBox.Show("Preencha os dados corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);               
            }
                
        }
         private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmOrcamento());
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Thread T1 = new Thread(AbrirFormAnterior);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
            this.Close();
        }
    }
}
