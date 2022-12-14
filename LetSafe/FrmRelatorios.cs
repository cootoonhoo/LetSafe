using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LetSafe
{
    public partial class FrmRelatorios : Form
    {
        Thread t1;

        Dictionary<string, string[]> Relatorios = new(); 
        public FrmRelatorios()
        {
            InitializeComponent();
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            Relatorios.Add("Apolices por segurado", new string[] {"vw_qtd_apolices_segurado", "Quantidade" });
            Relatorios.Add("Cidades com maior arrecadacao", new string[] { "vw_cidades_maior_arrecadacao", "Quantidade" });
            Relatorios.Add("Endereco dos segurados", new string[] { "vw_Endereco_segurados", "Nome" });
            Relatorios.Add("Logradouros por pessoa", new string[] { "vw_Logradouros_por_pessoa", "qntEndereco" });
            Relatorios.Add("Segurados não finaliazdos", new string[] { "vw_segurados_nao_finalizados", "cpf" });
            Relatorios.Add("Seguros mais procurados", new string[] { "vw_seguros_mais_procurados", "Quantidade" });
            Relatorios.Add("Sinistro por estado", new string[] { "vw_Sinistro_por_estado", "QuantidadeSinistros" });
            Relatorios.Add("Sinistro por segurado", new string[] { "vw_Sinistro_por_segurado", "QntSinistros" });
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var Relatorio = cobRelatorios.Text;
            GerarRelatorio(Relatorio);
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            //t1 = new Thread(AbrirFormAnterior);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }

        private void AbrirFormAnterior(object obj)
        {
            Application.Run(new FrmTelaFunc());
        }
        private async Task GerarRelatorio(string Relatorio) {
            lblFeedbackBD.Text = "Gerando relatório, aguarde...";
            lblFeedbackBD.ForeColor = Color.Red;
            lblFeedbackBD.Visible = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblFeedbackBD.ForeColor = Color.Green;
            dgvRelatorio.DataSource = DataBaseCon.ResgatarRelatorio(Relatorios[Relatorio][0], Relatorios[Relatorio][1]);
            lblFeedbackBD.Text = "Relatório gerado com sucesso!";
        }
    }
}
