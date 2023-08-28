using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Forms;
using GerenciadorDeAcervos.Personalizacao;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

            Personalisar.CenterLabelInPanel(panel_BarraTitulo, lbl_BarraTitulo);
            Personalisar.CenterGroupBoxInPanel(panel_InformacoesInstituicao, gb_InformacoesIntituicao);
        }

        #region Trio Botões
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
        #endregion

        #region BarraTitulo
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
        #endregion

        private void panel_InformacoesInstituicao_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_InformacoesInstituicao, gb_InformacoesIntituicao);
        }

        private void btn_CadastroInstituicao_Click(object sender, EventArgs e)
        {
            ShowNewForm(new Frm_CadastroUsuario());
        }

        private void ShowNewForm(object form)
        {
            if (this.panel_Central.Controls.Count > 0) this.panel_Central.Controls.RemoveAt(0);

            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.panel_Central.Controls.Add(newForm);
            this.panel_Central.Tag = newForm;
            newForm.Show();
        }

        private void panel_Central_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_Central, gb_PrincipalLogin);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lbl_ErrorLoginMsg.Visible = false;
            string nomeUsuario = txtNomeUsuario.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(nomeUsuario))
            {
                string senha = txtSenha.Text;
                if (!string.IsNullOrWhiteSpace(senha))
                {
                    bool connection = CheckConnection.Connection();
                    if (connection)
                    {
                        using (AcervoDbContext context = new())
                        {
                            // Consulta o banco de dados para verificar se o usuário e senha correspondem.
                            var user = context.Usuarios.FirstOrDefault(u => u.UsuarioNome == nomeUsuario && u.Senha == senha);
                            if (user != null)
                            {
                                gb_InformacoesIntituicao.Visible = true;

                                Permissao permissao = (Permissao)user.NivelPermissao;

                                lbl_ExibicaoUsuario.Text = user.UsuarioNome;
                                lbl_ExibicaoPermissao.Text = permissao.ToString();
                                pictureBox_Usuario.Image = ConverterParaImagem(user.Imagem);

                                if (user.NivelPermissao == 0) ShowNewForm(new Frm_Opcoes());
                                else if (user.NivelPermissao == 1)
                                {

                                }
                                else
                                {

                                }
                            }
                            else lbl_ErrorLoginMsg.Visible = true;
                        }
                    }
                }
            }
        }

        public enum Permissao
        {
            Master = 0,
            Administrador = 1,
            Usuario = 2,
        }

        public static Image ConverterParaImagem(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image imagem = null;
                if (byteArray.Length > 0) return Image.FromStream(ms);
                else return imagem;
            }
        }
    }
}