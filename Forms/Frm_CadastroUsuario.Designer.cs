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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroUsuario));
            panel_CadastroUsuarioForm = new Panel();
            gb_Cadastro = new GroupBox();
            pb_CadastroUsuarioImagem = new PictureBox();
            cmb_CadastroPermissao = new ComboBox();
            lbl_CadastroNivelPermissao = new Label();
            txt_CadastroSenha = new TextBox();
            txt_CadastroUsuario = new TextBox();
            lbl_CadastroSenha = new Label();
            lbl_CadastroLogin = new Label();
            btn_CadastroSalvar = new Button();
            btn_CadastroCarregarImagem = new Button();
            btn_CadastroUsuarioVoltar = new PictureBox();
            btn_CadastroUsuarioPesquisar = new PictureBox();
            btn_CadastroUsuarioInserir = new PictureBox();
            panel_Cadastro = new Panel();
            panel_CadastrousuarioBotoes = new Panel();
            btn_CadastroUsuario = new PictureBox();
            btn_CadastroUsuarioExcluir = new PictureBox();
            panel_CadastroUsuarioForm.SuspendLayout();
            gb_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CadastroUsuarioImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioInserir).BeginInit();
            panel_Cadastro.SuspendLayout();
            panel_CadastrousuarioBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioExcluir).BeginInit();
            SuspendLayout();
            // 
            // panel_CadastroUsuarioForm
            // 
            panel_CadastroUsuarioForm.Controls.Add(gb_Cadastro);
            panel_CadastroUsuarioForm.Dock = DockStyle.Top;
            panel_CadastroUsuarioForm.Location = new Point(0, 0);
            panel_CadastroUsuarioForm.Name = "panel_CadastroUsuarioForm";
            panel_CadastroUsuarioForm.Size = new Size(327, 130);
            panel_CadastroUsuarioForm.TabIndex = 14;
            // 
            // gb_Cadastro
            // 
            gb_Cadastro.Controls.Add(pb_CadastroUsuarioImagem);
            gb_Cadastro.Controls.Add(cmb_CadastroPermissao);
            gb_Cadastro.Controls.Add(lbl_CadastroNivelPermissao);
            gb_Cadastro.Controls.Add(txt_CadastroSenha);
            gb_Cadastro.Controls.Add(txt_CadastroUsuario);
            gb_Cadastro.Controls.Add(lbl_CadastroSenha);
            gb_Cadastro.Controls.Add(lbl_CadastroLogin);
            gb_Cadastro.Controls.Add(btn_CadastroSalvar);
            gb_Cadastro.Controls.Add(btn_CadastroCarregarImagem);
            gb_Cadastro.Location = new Point(3, 3);
            gb_Cadastro.Name = "gb_Cadastro";
            gb_Cadastro.Size = new Size(321, 121);
            gb_Cadastro.TabIndex = 10;
            gb_Cadastro.TabStop = false;
            // 
            // pb_CadastroUsuarioImagem
            // 
            pb_CadastroUsuarioImagem.Location = new Point(6, 1);
            pb_CadastroUsuarioImagem.Name = "pb_CadastroUsuarioImagem";
            pb_CadastroUsuarioImagem.Size = new Size(100, 80);
            pb_CadastroUsuarioImagem.TabIndex = 11;
            pb_CadastroUsuarioImagem.TabStop = false;
            // 
            // cmb_CadastroPermissao
            // 
            cmb_CadastroPermissao.FormattingEnabled = true;
            cmb_CadastroPermissao.Items.AddRange(new object[] { "Master", "Administrador", "Usuario" });
            cmb_CadastroPermissao.Location = new Point(197, 59);
            cmb_CadastroPermissao.Name = "cmb_CadastroPermissao";
            cmb_CadastroPermissao.Size = new Size(118, 23);
            cmb_CadastroPermissao.TabIndex = 18;
            // 
            // lbl_CadastroNivelPermissao
            // 
            lbl_CadastroNivelPermissao.AutoSize = true;
            lbl_CadastroNivelPermissao.Location = new Point(118, 62);
            lbl_CadastroNivelPermissao.Name = "lbl_CadastroNivelPermissao";
            lbl_CadastroNivelPermissao.Size = new Size(64, 15);
            lbl_CadastroNivelPermissao.TabIndex = 17;
            lbl_CadastroNivelPermissao.Text = "Permissão:";
            // 
            // txt_CadastroSenha
            // 
            txt_CadastroSenha.Location = new Point(197, 29);
            txt_CadastroSenha.Name = "txt_CadastroSenha";
            txt_CadastroSenha.PasswordChar = '*';
            txt_CadastroSenha.Size = new Size(118, 23);
            txt_CadastroSenha.TabIndex = 16;
            // 
            // txt_CadastroUsuario
            // 
            txt_CadastroUsuario.Location = new Point(197, 1);
            txt_CadastroUsuario.Name = "txt_CadastroUsuario";
            txt_CadastroUsuario.Size = new Size(118, 23);
            txt_CadastroUsuario.TabIndex = 15;
            // 
            // lbl_CadastroSenha
            // 
            lbl_CadastroSenha.AutoSize = true;
            lbl_CadastroSenha.Location = new Point(118, 33);
            lbl_CadastroSenha.Name = "lbl_CadastroSenha";
            lbl_CadastroSenha.Size = new Size(42, 15);
            lbl_CadastroSenha.TabIndex = 14;
            lbl_CadastroSenha.Text = "Senha:";
            // 
            // lbl_CadastroLogin
            // 
            lbl_CadastroLogin.AutoSize = true;
            lbl_CadastroLogin.Location = new Point(118, 4);
            lbl_CadastroLogin.Name = "lbl_CadastroLogin";
            lbl_CadastroLogin.Size = new Size(50, 15);
            lbl_CadastroLogin.TabIndex = 13;
            lbl_CadastroLogin.Text = "Usuario:";
            // 
            // btn_CadastroSalvar
            // 
            btn_CadastroSalvar.Cursor = Cursors.Hand;
            btn_CadastroSalvar.Location = new Point(261, 88);
            btn_CadastroSalvar.Name = "btn_CadastroSalvar";
            btn_CadastroSalvar.Size = new Size(54, 29);
            btn_CadastroSalvar.TabIndex = 11;
            btn_CadastroSalvar.Text = "Salvar";
            btn_CadastroSalvar.UseVisualStyleBackColor = true;
            btn_CadastroSalvar.Click += btn_CadastroSalvar_Click;
            // 
            // btn_CadastroCarregarImagem
            // 
            btn_CadastroCarregarImagem.Cursor = Cursors.Hand;
            btn_CadastroCarregarImagem.Location = new Point(6, 88);
            btn_CadastroCarregarImagem.Name = "btn_CadastroCarregarImagem";
            btn_CadastroCarregarImagem.Size = new Size(134, 29);
            btn_CadastroCarregarImagem.TabIndex = 9;
            btn_CadastroCarregarImagem.Text = "Carregar Imagem";
            btn_CadastroCarregarImagem.UseVisualStyleBackColor = true;
            btn_CadastroCarregarImagem.Click += btn_CadastroCarregarImagem_Click;
            // 
            // btn_CadastroUsuarioVoltar
            // 
            btn_CadastroUsuarioVoltar.Cursor = Cursors.Hand;
            btn_CadastroUsuarioVoltar.Image = (Image)resources.GetObject("btn_CadastroUsuarioVoltar.Image");
            btn_CadastroUsuarioVoltar.Location = new Point(3, 6);
            btn_CadastroUsuarioVoltar.Name = "btn_CadastroUsuarioVoltar";
            btn_CadastroUsuarioVoltar.Size = new Size(48, 48);
            btn_CadastroUsuarioVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CadastroUsuarioVoltar.TabIndex = 2;
            btn_CadastroUsuarioVoltar.TabStop = false;
            btn_CadastroUsuarioVoltar.Click += btn_CadastroUsuarioVoltar_Click;
            // 
            // btn_CadastroUsuarioPesquisar
            // 
            btn_CadastroUsuarioPesquisar.Cursor = Cursors.Hand;
            btn_CadastroUsuarioPesquisar.Image = (Image)resources.GetObject("btn_CadastroUsuarioPesquisar.Image");
            btn_CadastroUsuarioPesquisar.Location = new Point(168, 6);
            btn_CadastroUsuarioPesquisar.Name = "btn_CadastroUsuarioPesquisar";
            btn_CadastroUsuarioPesquisar.Size = new Size(48, 48);
            btn_CadastroUsuarioPesquisar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CadastroUsuarioPesquisar.TabIndex = 1;
            btn_CadastroUsuarioPesquisar.TabStop = false;
            // 
            // btn_CadastroUsuarioInserir
            // 
            btn_CadastroUsuarioInserir.Cursor = Cursors.Hand;
            btn_CadastroUsuarioInserir.Image = (Image)resources.GetObject("btn_CadastroUsuarioInserir.Image");
            btn_CadastroUsuarioInserir.Location = new Point(114, 6);
            btn_CadastroUsuarioInserir.Name = "btn_CadastroUsuarioInserir";
            btn_CadastroUsuarioInserir.Size = new Size(48, 48);
            btn_CadastroUsuarioInserir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CadastroUsuarioInserir.TabIndex = 0;
            btn_CadastroUsuarioInserir.TabStop = false;
            btn_CadastroUsuarioInserir.Click += btn_CadastroUsuarioInserir_Click;
            // 
            // panel_Cadastro
            // 
            panel_Cadastro.Controls.Add(panel_CadastrousuarioBotoes);
            panel_Cadastro.Controls.Add(panel_CadastroUsuarioForm);
            panel_Cadastro.Dock = DockStyle.Fill;
            panel_Cadastro.Location = new Point(0, 0);
            panel_Cadastro.Name = "panel_Cadastro";
            panel_Cadastro.Size = new Size(327, 236);
            panel_Cadastro.TabIndex = 1;
            panel_Cadastro.Resize += panel_Cadastro_Resize;
            // 
            // panel_CadastrousuarioBotoes
            // 
            panel_CadastrousuarioBotoes.Controls.Add(btn_CadastroUsuario);
            panel_CadastrousuarioBotoes.Controls.Add(btn_CadastroUsuarioExcluir);
            panel_CadastrousuarioBotoes.Controls.Add(btn_CadastroUsuarioInserir);
            panel_CadastrousuarioBotoes.Controls.Add(btn_CadastroUsuarioPesquisar);
            panel_CadastrousuarioBotoes.Controls.Add(btn_CadastroUsuarioVoltar);
            panel_CadastrousuarioBotoes.Location = new Point(0, 130);
            panel_CadastrousuarioBotoes.Name = "panel_CadastrousuarioBotoes";
            panel_CadastrousuarioBotoes.Size = new Size(327, 94);
            panel_CadastrousuarioBotoes.TabIndex = 15;
            // 
            // btn_CadastroUsuario
            // 
            btn_CadastroUsuario.Location = new Point(222, 6);
            btn_CadastroUsuario.Name = "btn_CadastroUsuario";
            btn_CadastroUsuario.Size = new Size(48, 48);
            btn_CadastroUsuario.TabIndex = 4;
            btn_CadastroUsuario.TabStop = false;
            // 
            // btn_CadastroUsuarioExcluir
            // 
            btn_CadastroUsuarioExcluir.Cursor = Cursors.Hand;
            btn_CadastroUsuarioExcluir.Image = (Image)resources.GetObject("btn_CadastroUsuarioExcluir.Image");
            btn_CadastroUsuarioExcluir.Location = new Point(276, 6);
            btn_CadastroUsuarioExcluir.Name = "btn_CadastroUsuarioExcluir";
            btn_CadastroUsuarioExcluir.Size = new Size(48, 48);
            btn_CadastroUsuarioExcluir.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CadastroUsuarioExcluir.TabIndex = 3;
            btn_CadastroUsuarioExcluir.TabStop = false;
            // 
            // Frm_CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 236);
            Controls.Add(panel_Cadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_CadastroUsuario";
            Text = "Cadastro";
            Load += Cadastro_Load;
            panel_CadastroUsuarioForm.ResumeLayout(false);
            gb_Cadastro.ResumeLayout(false);
            gb_Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CadastroUsuarioImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioInserir).EndInit();
            panel_Cadastro.ResumeLayout(false);
            panel_CadastrousuarioBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CadastroUsuarioExcluir).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Cadastro;
        public PictureBox pb_CadastroUsuarioImagem;
        public PictureBox btn_CadastroUsuarioPesquisar;
        public PictureBox btn_CadastroUsuarioInserir;
        public PictureBox btn_CadastroUsuarioVoltar;
        private Panel panel_CadastrousuarioBotoes;
        private PictureBox btn_CadastroUsuario;
        private PictureBox btn_CadastroUsuarioExcluir;
        public GroupBox gb_Cadastro;
        public Panel panel_CadastroUsuarioForm;
        public Button btn_CadastroCarregarImagem;
        public Button btn_CadastroSalvar;
        public TextBox txt_CadastroUsuario;
        public Label lbl_CadastroSenha;
        public Label lbl_CadastroLogin;
        public ComboBox cmb_CadastroPermissao;
        public Label lbl_CadastroNivelPermissao;
        public TextBox txt_CadastroSenha;
    }
}