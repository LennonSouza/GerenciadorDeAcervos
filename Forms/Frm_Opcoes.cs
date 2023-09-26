using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;
using System.Reflection.Emit;
using System.Security.Principal;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_Opcoes : Form
    {
        public static Frm_Opcoes _opcoes;
        public Frm_Opcoes()
        {
            _opcoes = this;
            InitializeComponent();
        }

        private void Frm_Opcoes_Load(object sender, EventArgs e)
        {

        }

        private void panel_Opcoes_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_Opcoes, gb_OpçoesMaster);
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            //Frm_Principal._principal.Size = new Size(327, 236);
            GlobalConfiguration.ShowNewForm(typeof(Frm_CadastroUsuario), panel_Opcoes);
            //GlobalConfiguration.ShowNewForm(typeof(Frm_TestCadastroUsuario), panel_Opcoes);
        }
    }
}
