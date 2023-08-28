﻿using GerenciadorDeAcervos.Data;
using GerenciadorDeAcervos.Data.Functions.UsuarioData;
using GerenciadorDeAcervos.Data.Models;
using GerenciadorDeAcervos.Personalizacao;
using static GerenciadorDeAcervos.Frm_Principal;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_CadastroUsuario : Form
    {
        private readonly AcervoDbContext _context;
        private string filePath;
        private Guid guid = Guid.Empty;

        public Frm_CadastroUsuario()
        {
            InitializeComponent();
            _context = new AcervoDbContext();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // Carregar dados de usuário no DataGridView
            List<Usuario> usuarios = _context.Usuarios.ToList();
            dataGridView_Usuarios.DataSource = usuarios;

            // Configurar coluna de imagem
            DataGridViewImageColumn colunaImagem = new DataGridViewImageColumn();
            colunaImagem.HeaderText = "Imagem";
            colunaImagem.DataPropertyName = "Imagem"; // Nome da propriedade na classe de dados
            colunaImagem.ImageLayout = DataGridViewImageCellLayout.Zoom; // Escolha o layout da imagem (Zoom, Normal, etc.)
            dataGridView_Usuarios.Columns.Add(colunaImagem);

            // Adicionar coluna de botão de exclusão
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Excluir";
            column.HeaderText = "";
            column.Text = "Excluir";
            column.UseColumnTextForButtonValue = true;
            dataGridView_Usuarios.Columns.Add(column);

            // Ocultar a quarta coluna (índice 3) - ajuste se necessário
            dataGridView_Usuarios.Columns[4].Visible = false;

            // Definir valores iniciais com base em Frm_Principal
            Frm_Principal._principal.Invoke((MethodInvoker)delegate
            {
                txt_CadastroUsuario.Text = Frm_Principal._principal.lbl_ExibicaoUsuario.Text;
                cmb_CadastroPermissao.SelectedItem = Frm_Principal._principal.lbl_ExibicaoPermissao.Text;
            });

            // Centralizar grupo em painel
            Personalisar.CenterGroupBoxInPanel(panel_CadastroTop, gb_Cadastro);

            // Obter o ID do usuário com base no nome do usuário
            Usuario? user = _context.Usuarios.FirstOrDefault(u => u.UsuarioNome == txt_CadastroUsuario.Text);
            if (user != null)
            {
                guid = user.UsuarioId;
            }
        }

        private void panel_Cadastro_Resize(object sender, EventArgs e)
        {
            Personalisar.CenterGroupBoxInPanel(panel_CadastroTop, gb_Cadastro);
        }

        private void btn_CadastroSalvar_Click(object sender, EventArgs e)
        {
            byte[] imagem = new byte[0];
            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("A imagem é obrigatoria.", "Adicionar imagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ShowNewForm(new Frm_CadastroUsuario());
                return;
            }
            else imagem = GetImagem(filePath);

            Usuario? user = _context.Usuarios.FirstOrDefault(u => u.UsuarioNome == txt_CadastroUsuario.Text);
            if (user != null)
            {
                if (user.NivelPermissao != cmb_CadastroPermissao.SelectedIndex)
                {
                    MessageBox.Show($"Você não pode alterar seu nivel de permissão.");
                }
                else
                {
                    if (guid == user.UsuarioId)
                    {
                        Frm_Principal._principal.Invoke((MethodInvoker)delegate
                        {
                            if (!string.IsNullOrEmpty(txt_CadastroUsuario.Text) &&
                            !string.IsNullOrEmpty(txt_CadastroSenha.Text) &&
                            !string.IsNullOrEmpty(cmb_CadastroPermissao.Text) &&
                            pictureBox_Cadastro.Image != null)
                            {
                                Frm_Principal._principal.lbl_ExibicaoUsuario.Text = txt_CadastroUsuario.Text;
                                Frm_Principal._principal.lbl_ExibicaoPermissao.Text = cmb_CadastroPermissao.SelectedItem.ToString();
                                Frm_Principal._principal.pictureBox_Usuario.Image = pictureBox_Cadastro.Image;
                            }
                        });
                    }

                    user.UsuarioNome = txt_CadastroUsuario.Text;
                    user.Senha = txt_CadastroSenha.Text;
                    user.Imagem = imagem;
                    user.NivelPermissao = cmb_CadastroPermissao.SelectedIndex;

                    UserData userData = new UserData(user, _context);
                    userData.UpdateUser();
                }
            }
            else
            {
                Usuario usuario = new Usuario
                {
                    UsuarioNome = txt_CadastroUsuario.Text,
                    Senha = txt_CadastroSenha.Text,
                    Imagem = imagem,
                    NivelPermissao = cmb_CadastroPermissao.SelectedIndex
                };

                UserData userData = new UserData(usuario, _context);
                userData.SaveUser();
            }
            ShowNewForm(new Frm_CadastroUsuario());
        }

        private byte[] GetImagem(string caminho)
        {
            byte[] imagem;
            using (FileStream stream = new(caminho, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new(stream))
                {
                    imagem = reader.ReadBytes((int)stream.Length);
                }
            }
            return imagem;
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

        private void ShowNewForm(object form)
        {
            if (this.panel_Cadastro.Controls.Count > 0) this.panel_Cadastro.Controls.RemoveAt(0);

            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.panel_Cadastro.Controls.Add(newForm);
            this.panel_Cadastro.Tag = newForm;
            newForm.Show();
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
                Permissao permissao = (Permissao)selectedRow.Cells["NivelPermissao"].Value;

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
                    Usuario? usuarioParaExcluir = _context.Usuarios.FirstOrDefault(u => u.UsuarioNome == value);
                    List<Usuario> usuariosMaster = _context.Usuarios.Where(u => u.NivelPermissao == 0).ToList();
                    if (usuarioParaExcluir != null)
                    {
                        if (usuarioParaExcluir.NivelPermissao != 0 || usuariosMaster.Count > 1)
                        {
                            UserData userData = new UserData(usuarioParaExcluir, _context);
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

        private void btn_CadastroUsuarioVoltar_Click(object sender, EventArgs e)
        {
            ShowNewForm(new Frm_Opcoes());
        }
    }
}