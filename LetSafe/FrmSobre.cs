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
    public partial class FrmSobre : Form
    {
        Thread t1;

        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            lblInfo1.Text = "Marco Antonio";
            lblInfo2.Text = "Mariane";
            lblInfo3.Text = "Matheus Amaro";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirFormPrincipal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void linkLbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AcessaLink1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLbl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AcessaLink2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLbl3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AcessaLink3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AcessaLink1()
        {
            linkLbl1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/cootoonhoo");
        }

        private void AcessaLink2()
        {
            linkLbl2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/carvalhosmari");
        }

        private void AcessaLink3()
        {
            linkLbl3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/MatAmaro");
        }

        private void AbrirFormPrincipal(object obj)
        {
            Application.Run(new FrmMenuPrincipal());
        }

    }
}
