using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Forms;
using System.Net.NetworkInformation;
using static GerenciadorDeAcervos.Frm_Principal;

namespace GerenciadorDeAcervos.Funcoes
{
    public class GlobalConfiguration
    {
        private static string _login = string.Empty, _password = string.Empty;
        public GlobalConfiguration(string login, string password)
        {
            _login = login;
            _password = password;
        }

        internal void Logged()
        {
            bool login = CredentialNotIsBlank();
            if (login)
            {
                bool connection = ConnectionIsTrue();
                if (connection)
                {
                    using (AcervoDbContext context = new())
                    {
                        // Consulta o banco de dados para verificar se o usuário e senha correspondem.
                        var user = context.Usuarios.FirstOrDefault(u => u.UsuarioNome == _login && u.Senha == _password);
                        if (user != null)
                        {
                            _principal.gb_InformacoesIntituicao.Visible = true;

                            Permissao permissao = (Permissao)user.NivelPermissao;

                            _principal.lbl_ExibicaoUsuario.Text = user.UsuarioNome;
                            _principal.lbl_ExibicaoPermissao.Text = permissao.ToString();
                            _principal.pictureBox_Usuario.Image = ConverterParaImagem(user.Imagem);

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
                    }
                }
                else
                {
                    _principal.lbl_ErrorLoginMsg.Text = "   Internet caiu.";
                    _principal.lbl_ErrorLoginMsg.Visible = true;
                }
            }
            else
            {
                _principal.lbl_ErrorLoginMsg.Text = "   Login em Branco";
                _principal.lbl_ErrorLoginMsg.Visible = true;
            }
        }

        private static bool CredentialNotIsBlank()
        {
            return !string.IsNullOrWhiteSpace(_login) && !string.IsNullOrWhiteSpace(_password) ? true : false;
        }

        private static bool ConnectionIsTrue()
        {
            return NetworkInterface.GetIsNetworkAvailable() ? true : false;
        }

        public static void ShowNewForm(object form, Panel panel)
        {
            if (panel.Controls.Count > 0) 
                panel.Controls.RemoveAt(0);

            Form newForm = (Form)form;

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            panel.Controls.Add(newForm);
            panel.Tag = newForm;

            newForm.Show();
        }
    }
}
