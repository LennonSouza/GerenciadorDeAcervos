using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Data.Models;
using System.Drawing.Imaging;
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

        // Efetua a verificação das credenciais no aplicativo
        internal Usuario ConnectionUser()
        {
            bool login = CredentialNotIsBlank();
            if (login)
            {
                bool connection = ConnectionIsTrue();
                if (connection)
                {
                    return GetUser();
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
            return null;
        }

        // Busca o Usuario 
        private static Usuario GetUser()
        {
            using (AcervoDbContext context = new())
            {
                // Consulta o banco de dados para verificar se o usuário e senha correspondem.
                return context.Usuarios.FirstOrDefault(u => u.UsuarioNome == _login && u.Senha == _password);
            }
        }

        // Busca pelo Guid ID
        public static Usuario GetUserID(Guid id)
        {
            using (AcervoDbContext context = new())
            {
                // Consulta o banco de dados para verificar se o usuário e senha correspondem.
                return context.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
            }
        }

        // Verifica se os campos login e senha não estão em branco
        internal static bool CredentialNotIsBlank()
        {
            return !string.IsNullOrWhiteSpace(_login) && !string.IsNullOrWhiteSpace(_password) ? true : false;
        }

        // Verifica se há uma conexão com a internet
        private static bool ConnectionIsTrue()
        {
            return NetworkInterface.GetIsNetworkAvailable() ? true : false;
        }

        // Remove o Form atual do Panel, e adiciona um novo
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

        public enum Permissao
        {
            Master = 0,
            Administrador = 1,
            Usuario = 2,
        }

        #region Tratamento de Imagem
        // Converte a de byte[] para imagem
        public Image ConverterParaImagem(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                if (byteArray.Length > 0)
                    return Image.FromStream(ms);
                else
                    return ImagemVazia();
            }
        }

        // Convert a Imagem para byte[]
        public byte[] GetImagem(string caminho)
        {
            byte[] imagem;
            if (string.IsNullOrWhiteSpace(caminho))
            {
                // Primeiro, crie uma imagem vazia
                Image imagemVazia = ImagemVazia();

                // Em seguida, converta a imagem em um formato de byte array
                using (MemoryStream stream = new MemoryStream())
                {
                    imagemVazia.Save(stream, ImageFormat.Png); // Você pode escolher um formato adequado aqui
                    imagem = stream.ToArray();
                }
            }
            else
            {
                using (FileStream stream = new(caminho, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new(stream))
                    {
                        imagem = reader.ReadBytes((int)stream.Length);
                    }
                }
            }

            return imagem;
        }

        // Retorna uma imagem em branco
        public static Image ImagemVazia()
        {
            int largura = 100; // Largura da imagem em pixels
            int altura = 100;  // Altura da imagem em pixels

            Bitmap imagemVazia = new Bitmap(largura, altura);

            using (Graphics g = Graphics.FromImage(imagemVazia))
            {
                // Preencha a imagem com uma cor branca
                g.FillRectangle(Brushes.White, 0, 0, largura, altura);
            }

            return imagemVazia;
        }
        #endregion
    }
}
