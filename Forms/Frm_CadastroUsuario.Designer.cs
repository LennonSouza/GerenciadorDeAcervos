namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_CadastroPanel = new GroupBox();
            panel_DataGridViewUsuarios = new Panel();
            dataGridView_Usuarios = new DataGridView();
            panel_CadastroTop = new Panel();
            gb_Cadastro = new GroupBox();
            btn_CadastroUsuarioVoltar = new Button();
            pictureBox_Cadastro = new PictureBox();
            cmb_CadastroPermissao = new ComboBox();
            lbl_CadastroNivelPermissao = new Label();
            txt_CadastroSenha = new TextBox();
            txt_CadastroUsuario = new TextBox();
            lbl_CadastroSenha = new Label();
            lbl_CadastroLogin = new Label();
            btn_CadastroSalvar = new Button();
            btn_CadastroCarregarImagem = new Button();
            panel_Cadastro = new Panel();
            gb_CadastroPanel.SuspendLayout();
            panel_DataGridViewUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).BeginInit();
            panel_CadastroTop.SuspendLayout();
            gb_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cadastro).BeginInit();
            panel_Cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // gb_CadastroPanel
            // 
            gb_CadastroPanel.Controls.Add(panel_DataGridViewUsuarios);
            gb_CadastroPanel.Controls.Add(panel_CadastroTop);
            gb_CadastroPanel.Dock = DockStyle.Fill;
            gb_CadastroPanel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_CadastroPanel.Location = new Point(0, 0);
            gb_CadastroPanel.Name = "gb_CadastroPanel";
            gb_CadastroPanel.Size = new Size(655, 394);
            gb_CadastroPanel.TabIndex = 0;
            gb_CadastroPanel.TabStop = false;
            gb_CadastroPanel.Text = "Cadastro Usuario";
            // 
            // panel_DataGridViewUsuarios
            // 
            panel_DataGridViewUsuarios.Controls.Add(dataGridView_Usuarios);
            panel_DataGridViewUsuarios.Dock = DockStyle.Fill;
            panel_DataGridViewUsuarios.Location = new Point(3, 176);
            panel_DataGridViewUsuarios.Name = "panel_DataGridViewUsuarios";
            panel_DataGridViewUsuarios.Size = new Size(649, 215);
            panel_DataGridViewUsuarios.TabIndex = 14;
            // 
            // dataGridView_Usuarios
            // 
            dataGridView_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Usuarios.Cursor = Cursors.Hand;
            dataGridView_Usuarios.Dock = DockStyle.Fill;
            dataGridView_Usuarios.Location = new Point(0, 0);
            dataGridView_Usuarios.Name = "dataGridView_Usuarios";
            dataGridView_Usuarios.ReadOnly = true;
            dataGridView_Usuarios.RowTemplate.Height = 25;
            dataGridView_Usuarios.Size = new Size(649, 215);
            dataGridView_Usuarios.TabIndex = 11;
            dataGridView_Usuarios.CellContentClick += dataGridView_Usuarios_CellContentClick;
            dataGridView_Usuarios.SelectionChanged += dataGridView_Usuarios_SelectionChanged;
            // 
            // panel_CadastroTop
            // 
            panel_CadastroTop.Controls.Add(gb_Cadastro);
            panel_CadastroTop.Dock = DockStyle.Top;
            panel_CadastroTop.Location = new Point(3, 21);
            panel_CadastroTop.Name = "panel_CadastroTop";
            panel_CadastroTop.Size = new Size(649, 155);
            panel_CadastroTop.TabIndex = 13;
            // 
            // gb_Cadastro
            // 
            gb_Cadastro.Controls.Add(btn_CadastroUsuarioVoltar);
            gb_Cadastro.Controls.Add(pictureBox_Cadastro);
            gb_Cadastro.Controls.Add(cmb_CadastroPermissao);
            gb_Cadastro.Controls.Add(lbl_CadastroNivelPermissao);
            gb_Cadastro.Controls.Add(txt_CadastroSenha);
            gb_Cadastro.Controls.Add(txt_CadastroUsuario);
            gb_Cadastro.Controls.Add(lbl_CadastroSenha);
            gb_Cadastro.Controls.Add(lbl_CadastroLogin);
            gb_Cadastro.Controls.Add(btn_CadastroSalvar);
            gb_Cadastro.Controls.Add(btn_CadastroCarregarImagem);
            gb_Cadastro.Location = new Point(122, 3);
            gb_Cadastro.Name = "gb_Cadastro";
            gb_Cadastro.Size = new Size(335, 152);
            gb_Cadastro.TabIndex = 10;
            gb_Cadastro.TabStop = false;
            // 
            // btn_CadastroUsuarioVoltar
            // 
            btn_CadastroUsuarioVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_CadastroUsuarioVoltar.Cursor = Cursors.Hand;
            btn_CadastroUsuarioVoltar.Location = new Point(268, 113);
            btn_CadastroUsuarioVoltar.Name = "btn_CadastroUsuarioVoltar";
            btn_CadastroUsuarioVoltar.Size = new Size(55, 30);
            btn_CadastroUsuarioVoltar.TabIndex = 19;
            btn_CadastroUsuarioVoltar.Text = "Voltar";
            btn_CadastroUsuarioVoltar.UseVisualStyleBackColor = true;
            btn_CadastroUsuarioVoltar.Click += btn_CadastroUsuarioVoltar_Click;
            // 
            // pictureBox_Cadastro
            // 
            pictureBox_Cadastro.Location = new Point(21, 27);
            pictureBox_Cadastro.Name = "pictureBox_Cadastro";
            pictureBox_Cadastro.Size = new Size(100, 80);
            pictureBox_Cadastro.TabIndex = 11;
            pictureBox_Cadastro.TabStop = false;
            // 
            // cmb_CadastroPermissao
            // 
            cmb_CadastroPermissao.FormattingEnabled = true;
            cmb_CadastroPermissao.Items.AddRange(new object[] { "Master", "Administrador", "Usuario" });
            cmb_CadastroPermissao.Location = new Point(206, 82);
            cmb_CadastroPermissao.Name = "cmb_CadastroPermissao";
            cmb_CadastroPermissao.Size = new Size(118, 25);
            cmb_CadastroPermissao.TabIndex = 18;
            // 
            // lbl_CadastroNivelPermissao
            // 
            lbl_CadastroNivelPermissao.AutoSize = true;
            lbl_CadastroNivelPermissao.Location = new Point(127, 85);
            lbl_CadastroNivelPermissao.Name = "lbl_CadastroNivelPermissao";
            lbl_CadastroNivelPermissao.Size = new Size(73, 19);
            lbl_CadastroNivelPermissao.TabIndex = 17;
            lbl_CadastroNivelPermissao.Text = "Permissão:";
            // 
            // txt_CadastroSenha
            // 
            txt_CadastroSenha.Location = new Point(206, 52);
            txt_CadastroSenha.Name = "txt_CadastroSenha";
            txt_CadastroSenha.PasswordChar = '*';
            txt_CadastroSenha.Size = new Size(118, 25);
            txt_CadastroSenha.TabIndex = 16;
            // 
            // txt_CadastroUsuario
            // 
            txt_CadastroUsuario.Location = new Point(206, 24);
            txt_CadastroUsuario.Name = "txt_CadastroUsuario";
            txt_CadastroUsuario.Size = new Size(118, 25);
            txt_CadastroUsuario.TabIndex = 15;
            // 
            // lbl_CadastroSenha
            // 
            lbl_CadastroSenha.AutoSize = true;
            lbl_CadastroSenha.Location = new Point(127, 56);
            lbl_CadastroSenha.Name = "lbl_CadastroSenha";
            lbl_CadastroSenha.Size = new Size(49, 19);
            lbl_CadastroSenha.TabIndex = 14;
            lbl_CadastroSenha.Text = "Senha:";
            // 
            // lbl_CadastroLogin
            // 
            lbl_CadastroLogin.AutoSize = true;
            lbl_CadastroLogin.Location = new Point(127, 27);
            lbl_CadastroLogin.Name = "lbl_CadastroLogin";
            lbl_CadastroLogin.Size = new Size(59, 19);
            lbl_CadastroLogin.TabIndex = 13;
            lbl_CadastroLogin.Text = "Usuario:";
            // 
            // btn_CadastroSalvar
            // 
            btn_CadastroSalvar.Cursor = Cursors.Hand;
            btn_CadastroSalvar.Location = new Point(206, 114);
            btn_CadastroSalvar.Name = "btn_CadastroSalvar";
            btn_CadastroSalvar.Size = new Size(56, 29);
            btn_CadastroSalvar.TabIndex = 11;
            btn_CadastroSalvar.Text = "Salvar";
            btn_CadastroSalvar.UseVisualStyleBackColor = true;
            btn_CadastroSalvar.Click += btn_CadastroSalvar_Click;
            // 
            // btn_CadastroCarregarImagem
            // 
            btn_CadastroCarregarImagem.Cursor = Cursors.Hand;
            btn_CadastroCarregarImagem.Location = new Point(21, 114);
            btn_CadastroCarregarImagem.Name = "btn_CadastroCarregarImagem";
            btn_CadastroCarregarImagem.Size = new Size(179, 29);
            btn_CadastroCarregarImagem.TabIndex = 9;
            btn_CadastroCarregarImagem.Text = "Carregar Imagem";
            btn_CadastroCarregarImagem.UseVisualStyleBackColor = true;
            btn_CadastroCarregarImagem.Click += btn_CadastroCarregarImagem_Click;
            // 
            // panel_Cadastro
            // 
            panel_Cadastro.Controls.Add(gb_CadastroPanel);
            panel_Cadastro.Dock = DockStyle.Fill;
            panel_Cadastro.Location = new Point(0, 0);
            panel_Cadastro.Name = "panel_Cadastro";
            panel_Cadastro.Size = new Size(655, 394);
            panel_Cadastro.TabIndex = 1;
            panel_Cadastro.Resize += panel_Cadastro_Resize;
            // 
            // Frm_CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 394);
            Controls.Add(panel_Cadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_CadastroUsuario";
            Text = "Cadastro";
            Load += Cadastro_Load;
            gb_CadastroPanel.ResumeLayout(false);
            panel_DataGridViewUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Usuarios).EndInit();
            panel_CadastroTop.ResumeLayout(false);
            gb_Cadastro.ResumeLayout(false);
            gb_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Cadastro).EndInit();
            panel_Cadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_CadastroPanel;
        private Button btn_CadastroCarregarImagem;
        private GroupBox gb_Cadastro;
        private Panel panel_Cadastro;
        private Button btn_CadastroSalvar;
        private TextBox txt_CadastroUsuario;
        private Label lbl_CadastroSenha;
        private Label lbl_CadastroLogin;
        private ComboBox cmb_CadastroPermissao;
        private Label lbl_CadastroNivelPermissao;
        private TextBox txt_CadastroSenha;
        private Panel panel_CadastroTop;
        private Panel panel_DataGridViewUsuarios;
        private DataGridView dataGridView_Usuarios;
        public PictureBox pictureBox_Cadastro;
        public Button btn_CadastroUsuarioVoltar;
    }
}