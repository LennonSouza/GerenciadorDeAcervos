using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Data.Functions.UsuarioData;
using GerenciadorDeAcervos.Data.Models;
using GerenciadorDeAcervos.Funcoes;
using GerenciadorDeAcervos.Personalizacao;
using static GerenciadorDeAcervos.Frm_Principal;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_CadastroUsuario : Form
    {
        SearchUsuarios searchUsuarios = new();
        private string filePath = string.Empty;
        private static Guid guid = Guid.Empty;

        public Frm_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // Carregar dados de usuário no DataGridView
            dataGridView_Usuarios.DataSource = searchUsuarios.UsuarioToList();

            // Configurar coluna de imagem
            DataGridViewImageColumn colunaImagem = new();
            colunaImagem.HeaderText = "Imagem";
            colunaImagem.DataPropertyName = "Imagem"; // Nome da propriedade na classe de dados
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom; // Escolha o layout da imagem
            dataGridView_Usuarios.Columns.Add(colunaImagem);

            // Adicionar coluna de botão de exclusão
            DataGridViewButtonColumn column = new();
            column.Name = "Excluir";
            column.HeaderText = "";
            column.Text = "Excluir";
            column.UseColumnTextForButtonValue = true;
            dataGridView_Usuarios.Columns.Add(column);

            // Ocultar a quarta coluna (índice 3) - ajuste se necessário
            dataGridView_Usuarios.Columns[4].Visible = false;

            // Definir valores iniciais com base em Frm_Principal
            _principal.Invoke((MethodInvoker)delegate
            {
                txt_CadastroUsuario.Text = _principal.lbl_ExibicaoUsuario.Text;
                cmb_CadastroPermissao.SelectedItem = _principal.lbl_ExibicaoPermissao.Text;
            });

            // Centralizar grupo em painel
            Personalisar.CenterGroupBoxInPanel(panel_CadastroTop, gb_Cadastro);

            string usuarioName = txt_CadastroUsuario.Text;

            // Obter o ID do usuário com base no nome do usuário
            Usuario? user = searchUsuarios.GetUsuario(usuarioName);
            if (user != null)
                guid = user.UsuarioId;
        }

        #region Botões Form
        private void btn_CadastroSalvar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txt_CadastroUsuario.Text.ToLower();
            string senha = txt_CadastroSenha.Text;

            GlobalConfiguration verificationCredentials = new(nomeUsuario, senha);

            byte[] imagem = verificationCredentials.GetImagem(filePath);

            Usuario userName = searchUsuarios.GetUsuario(nomeUsuario);
            if (userName == null)
                CriarNovoUsuario(nomeUsuario, senha, imagem);
            else
                AtualizarUsuarioExistente(nomeUsuario, senha, imagem, userName);

            GlobalConfiguration.ShowNewForm(new Frm_CadastroUsuario(), panel_Cadastro);
        }

        private void btn_CadastroCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Todos os Arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    pictureBox_Cadastro.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox_Cadastro.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void btn_CadastroUsuarioVoltar_Click(object sender, EventArgs e)
        {
            GlobalConfiguration.ShowNewForm(new Frm_Opcoes(), panel_Cadastro);
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
                if (guid == user.UsuarioId)
                {
                    _principal.Invoke((MethodInvoker)delegate
                    {
                        _principal.lbl_ExibicaoUsuario.Text = txt_CadastroUsuario.Text;
                        _principal.lbl_ExibicaoPermissao.Text = cmb_CadastroPermissao.SelectedItem.ToString();
                        _principal.pictureBox_Usuario.Image = pictureBox_Cadastro.Image;
                    });
                }

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
            Personalisar.CenterGroupBoxInPanel(panel_CadastroTop, gb_Cadastro);
        }

        //Seleciona a linha do DGV e disponibiliza nos txtbox
        private void dataGridView_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Usuarios.SelectedRows.Count > 0)
            {
                // Obtenha a linha selecionada
                DataGridViewRow selectedRow = dataGridView_Usuarios.SelectedRows[0];

                // Obtenha os valores das colunas da linha selecionada
                string? nome = selectedRow.Cells["UsuarioNome"].Value.ToString();
                string? senha = selectedRow.Cells["Senha"].Value.ToString();
                GlobalConfiguration.enumPermissao permissao = (GlobalConfiguration.enumPermissao)selectedRow.Cells["NivelPermissao"].Value;

                // Exiba os valores nos TextBoxes
                txt_CadastroUsuario.Text = nome;
                txt_CadastroSenha.Text = senha;
                cmb_CadastroPermissao.SelectedItem = permissao.ToString();
            }
        }

        private void dataGridView_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o botão de exclusão foi clicado
            if (e.ColumnIndex == dataGridView_Usuarios.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                // Obtém o valor da célula correspondente à linha selecionada
                string? value = dataGridView_Usuarios.Rows[e.RowIndex].Cells["UsuarioNome"].Value.ToString();

                // Pergunta ao usuário se deseja excluir a linha
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o item \"" + value + "\"?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Usuario? usuarioParaExcluir = searchUsuarios.GetUsuario(value);
                    List<Usuario> usuariosMaster = searchUsuarios.GetUsuarioPermission();
                    if (usuarioParaExcluir != null)
                    {
                        if (usuarioParaExcluir.NivelPermissao != 0 || usuariosMaster.Count > 1)
                        {
                            UserData userData = new UserData(usuarioParaExcluir);
                            userData.DeleteUser();

                            // Exclui a linha correspondente ao botão de exclusão clicado
                            using (AcervoDbContext context = new())
                            {
                                // Consulte novamente os dados que deseja exibir no DataGridView
                                List<Usuario> usuarios = context.Usuarios.ToList();

                                // Associe a lista de usuários ao DataGridView
                                dataGridView_Usuarios.DataSource = usuarios;
                            }
                        }
                        else if (usuariosMaster.Count == 1) MessageBox.Show("Você não pode apagar o unico 'MASTER'.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show("Usuario não encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion
    }
}
