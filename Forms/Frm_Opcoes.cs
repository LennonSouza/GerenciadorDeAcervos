using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_Opcoes : Form
    {
        public Frm_Opcoes() { InitializeComponent(); }

        private void Frm_Opcoes_Load(object sender, EventArgs e) { }

        private void panel_Opcoes_Resize(object sender, EventArgs e) { Personalisar.CenterGroupBoxInPanel(panel_Opcoes, gb_OpçoesMaster); }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Frm_Principal._principal.Size = new Size(665, 394);
            GlobalConfiguration.ShowNewForm(new Frm_CadastroUsuario(), panel_Opcoes);
        }
    }
}
