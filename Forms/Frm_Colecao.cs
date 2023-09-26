using GerenciadorDeAcervos.Funcoes;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_Colecao : Form
    {
        public Frm_Colecao()
        {
            InitializeComponent();
        }

        private void Frm_Colecao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ColecaoAdicionar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new();
            toolTip.SetToolTip(btn_ColecaoAdicionar, "Adicionar nova Coleção.");
        }

        private void btn_ColecaoAdicionar_Click(object sender, EventArgs e)
        {
            GlobalConfiguration.ShowNewForm(typeof(Frm_AdicionarColecao), panel_ColecaoInsercaoInformacao);
        }

        private void btn_ColecaoPesquisar_Click(object sender, EventArgs e)
        {
            GlobalConfiguration.ShowNewForm(typeof(Frm_PesquisarColecao), panel_ColecaoInsercaoInformacao);
        }

        private void btn_ColecaoVoltar_Click(object sender, EventArgs e)
        {
            GlobalConfiguration.ShowNewForm(typeof(Frm_Opcoes), panel_Colecao);
        }
    }
}
