using GerenciadorDeAcervos.Data.Functions.UsuarioData;
using GerenciadorDeAcervos.Data.Models;
using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;
using static GerenciadorDeAcervos.Frm_Principal;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_CadastroUsuario : Form
    {
        public static Frm_CadastroUsuario _cadastroUsuario;
        private string filePath = string.Empty;

        public Frm_CadastroUsuario()
        {
            _cadastroUsuario = this;
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e) { }

        #region Botões Form
        private void btn_CadastroSalvar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txt_CadastroUsuario.Text.ToLower();
            string senha = txt_CadastroSenha.Text;

            GlobalConfiguration verificationCredentials = new(nomeUsuario, senha);

            byte[] imagem = verificationCredentials.GetImagem(filePath);

            SearchUsuarios searchUsuarios = new();
            Usuario userName = searchUsuarios.GetUsuario(nomeUsuario);
            if (userName == null)
                CriarNovoUsuario(nomeUsuario, senha, imagem);
            else
                AtualizarUsuarioExistente(nomeUsuario, senha, imagem, userName);

            GlobalConfiguration.ShowNewForm(typeof(Frm_CadastroUsuario), panel_CadastroUsuarioForm);
        }

        private void btn_CadastroCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Todos os Arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    pb_CadastroUsuarioImagem.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_CadastroUsuarioImagem.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }
        #endregion

        #region Metodos CadastrarSalvar
        private void CriarNovoUsuario(string nomeUsuario, string senha, byte[] imagem)
        {
            Usuario usuario = new Usuario
            {
                UsuarioNome = nomeUsuario,
                Senha = senha,
                Imagem = imagem,
                NivelPermissao = cmb_CadastroPermissao.SelectedIndex
            };

            UserData userData = new UserData(usuario);
            userData.SaveUser();
        }

        private void AtualizarUsuarioExistente(string nomeUsuario, string senha, byte[] imagem, Usuario userName)
        {
            Usuario user = GlobalConfiguration.GetUserID(userName.UsuarioId);

            if (user.NivelPermissao == cmb_CadastroPermissao.SelectedIndex)
            {
                _principal.Invoke((MethodInvoker)delegate
                {
                    _principal.lbl_ExibicaoUsuario.Text = txt_CadastroUsuario.Text;
                    _principal.lbl_ExibicaoPermissao.Text = cmb_CadastroPermissao.SelectedItem.ToString();
                    _principal.pictureBox_Usuario.Image = pb_CadastroUsuarioImagem.Image;
                });

                user.UsuarioNome = nomeUsuario;
                user.Senha = senha;
                user.Imagem = imagem;
                user.NivelPermissao = cmb_CadastroPermissao.SelectedIndex;

                UserData userData = new UserData(user);
                userData.UpdateUser();
            }
            else
            {
                MessageBox.Show("Você não pode alterar o nível de permissão.");
            }
        }
        #endregion

        #region Resize
        private void panel_Cadastro_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_Cadastro, gb_Cadastro);
        }
        #endregion

        private void btn_CadastroUsuarioInserir_Click(object sender, EventArgs e)
        {
            panel_CadastroUsuarioForm.Visible = true;
            GlobalConfiguration.ShowNewForm(typeof(Frm_CadastroUsuario), panel_CadastroUsuarioForm);
        }

        private void btn_CadastroUsuarioVoltar_Click(object sender, EventArgs e)
        {
            panel_CadastroUsuarioForm.Visible = false;
            GlobalConfiguration.ShowNewForm(typeof(Frm_Opcoes), panel_Cadastro);
        }
    }
}