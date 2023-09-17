using GerenciadorDeAcervos.Data.Models;
using GerenciadorDeAcervos.Forms;
using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;
using System.Runtime.InteropServices;
using static GerenciadorDeAcervos.Funcoes.GlobalConfiguration;

namespace GerenciadorDeAcervos
{
    public partial class Frm_Principal : Form
    {
        public static Frm_Principal _principal;

        public Frm_Principal()
        {
            _principal = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            lbl_ErrorLoginMsg.Visible = false;

            Personalisar.CenterLabelInPanel(panel_BarraTitulo, lbl_BarraTitulo);
            Personalisar.CenterGroupBoxInPanel(panel_InformacoesInstituicao, gb_InformacoesIntituicao);
        }

        #region Botões Minimizar/Maximizar/Fechar
        private void btn_FecharAplicacao_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_MaximizarAplicacao_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void btn_MinimizarAplicacao_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Manuseio do form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            if (e.Button == MouseButtons.Left && e.Clicks == 2 && e.Y <= SystemInformation.CaptionHeight)
            {
                if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
                else WindowState = FormWindowState.Maximized;
            }
        }

        private void lbl_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            if (e.Button == MouseButtons.Left && e.Clicks == 2 && e.Y <= SystemInformation.CaptionHeight)
            {
                if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
                else WindowState = FormWindowState.Maximized;
            }
        }

        private void panel_BarraTitulo_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterLabelInPanel(panel_BarraTitulo, lbl_BarraTitulo);
        }

        private void panel_BarraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void lbl_BarraTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void panel_InformacoesInstituicao_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_InformacoesInstituicao, gb_InformacoesIntituicao);
        }

        private void panel_Central_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_Central, gb_PrincipalLogin);
        }
        #endregion

        // Botão de Login
        private void btn_Login_Click(object sender, EventArgs e)
        {
            btn_Login.Enabled = false;

            string nomeUsuario = txtNomeUsuario.Text.ToLower();
            string senha = txtSenha.Text;

            GlobalConfiguration verificationCredentials = new GlobalConfiguration(nomeUsuario, senha);
            Usuario user = verificationCredentials.ConnectionUser();
            if (user != null)
            {
                _principal.gb_InformacoesIntituicao.Visible = true;

                enumPermissao permissao = (enumPermissao)user.NivelPermissao;

                _principal.lbl_ExibicaoUsuario.Text = user.UsuarioNome;
                _principal.lbl_ExibicaoPermissao.Text = permissao.ToString();
                _principal.pictureBox_Usuario.Image = verificationCredentials.ConverterParaImagem(user.Imagem);

                if (user.NivelPermissao == 0)
                {
                    ShowNewForm(new Frm_Opcoes(), _principal.panel_Central);
                }
                else if (user.NivelPermissao == 1)
                {

                }
                else
                {

                }
            }
            else
            {
                _principal.lbl_ErrorLoginMsg.Text = "   Usuario/Senha invalido.";
                _principal.lbl_ErrorLoginMsg.Visible = true;
            }

            btn_Login.Enabled = true;
        }
    }
}