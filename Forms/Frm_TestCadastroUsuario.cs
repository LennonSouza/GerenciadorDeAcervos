using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_TestCadastroUsuario : Form
    {
        public static Frm_TestCadastroUsuario _test;
        public Frm_TestCadastroUsuario()
        {
            _test = this;
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            panel_test2.Visible = false;
            GlobalConfiguration.ShowNewForm(typeof(Frm_Opcoes), panel_test1);
        }

        private void add_Click(object sender, EventArgs e)
        {
            panel_test2.Visible = true;
            GlobalConfiguration.ShowNewForm(typeof(Frm_TestCadastroUsuario), panel_test2);
        }

        private void panel_test1_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_test1, groupBox1);
        }

        private void Frm_TestCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
