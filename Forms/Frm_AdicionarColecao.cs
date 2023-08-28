using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Personalizacao;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_AdicionarColecao : Form
    {
        public Frm_AdicionarColecao()
        {
            InitializeComponent();
        }

        private void Frm_AdicionarColecao_Load(object sender, EventArgs e)
        {

        }

        private void panel_AdicionarColecao_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_AdicionarColecao, gb_ColecaoInformacaoNomeLocalizacao);
        }

        private void btn_ColecaoCadastro_Click(object sender, EventArgs e)
        {
            string nomeColecao = txt_ColecaoNome.Text;
            string localizacaoColecao = txt_ColecaoLocalizacao.Text;
            int quantidadeCampoTexto = int.Parse(txt_ColecaoQuantidadeStrings.Text);
            int quantidadeImagens = int.Parse(txt_ColecaoQuantidadeDeImagens.Text);


            // Limpar os campos após a inserção
            txt_ColecaoNome.Text = string.Empty;
            txt_ColecaoLocalizacao.Text = string.Empty;
            txt_ColecaoQuantidadeStrings.Text = string.Empty;
            txt_ColecaoQuantidadeDeImagens.Text = string.Empty;
        }
    }
}
