namespace GerenciadorDeAcervos
{
    partial class Frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            panel_BarraTitulo = new Panel();
            lbl_BarraTitulo = new Label();
            btn_MinimizarAplicacao = new Button();
            btn_MaximizarAplicacao = new Button();
            btn_FecharAplicacao = new Button();
            panel_InformacoesInstituicao = new Panel();
            gb_InformacoesIntituicao = new GroupBox();
            pictureBox_Usuario = new PictureBox();
            lbl_ExibicaoUsuarioFix = new Label();
            lbl_ExibicaoPermissao = new Label();
            lbl_ExibicaoPermissaoFix = new Label();
            lbl_ExibicaoUsuario = new Label();
            panel_Central = new Panel();
            gb_PrincipalLogin = new GroupBox();
            lbl_ErrorLoginMsg = new Label();
            btn_Login = new Button();
            txtSenha = new TextBox();
            txtNomeUsuario = new TextBox();
            lbl_Password = new Label();
            lbl_Login = new Label();
            panel_BarraTitulo.SuspendLayout();
            panel_InformacoesInstituicao.SuspendLayout();
            gb_InformacoesIntituicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Usuario).BeginInit();
            panel_Central.SuspendLayout();
            gb_PrincipalLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel_BarraTitulo
            // 
            panel_BarraTitulo.Controls.Add(lbl_BarraTitulo);
            panel_BarraTitulo.Controls.Add(btn_MinimizarAplicacao);
            panel_BarraTitulo.Controls.Add(btn_MaximizarAplicacao);
            panel_BarraTitulo.Controls.Add(btn_FecharAplicacao);
            panel_BarraTitulo.Dock = DockStyle.Top;
            panel_BarraTitulo.Location = new Point(0, 0);
            panel_BarraTitulo.Name = "panel_BarraTitulo";
            panel_BarraTitulo.Size = new Size(464, 44);
            panel_BarraTitulo.TabIndex = 1;
            panel_BarraTitulo.MouseDoubleClick += panel_BarraTitulo_MouseDoubleClick;
            panel_BarraTitulo.MouseDown += panel_BarraTitulo_MouseDown;
            panel_BarraTitulo.Resize += panel_BarraTitulo_Resize;
            // 
            // lbl_BarraTitulo
            // 
            lbl_BarraTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_BarraTitulo.AutoSize = true;
            lbl_BarraTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BarraTitulo.Location = new Point(67, 4);
            lbl_BarraTitulo.Name = "lbl_BarraTitulo";
            lbl_BarraTitulo.Size = new Size(298, 37);
            lbl_BarraTitulo.TabIndex = 5;
            lbl_BarraTitulo.Text = "Gerenciador de Acervos";
            lbl_BarraTitulo.MouseDoubleClick += lbl_BarraTitulo_MouseDoubleClick;
            lbl_BarraTitulo.MouseDown += lbl_BarraTitulo_MouseDown;
            // 
            // btn_MinimizarAplicacao
            // 
            btn_MinimizarAplicacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_MinimizarAplicacao.Cursor = Cursors.Hand;
            btn_MinimizarAplicacao.Image = (Image)resources.GetObject("btn_MinimizarAplicacao.Image");
            btn_MinimizarAplicacao.Location = new Point(386, 11);
            btn_MinimizarAplicacao.Name = "btn_MinimizarAplicacao";
            btn_MinimizarAplicacao.Size = new Size(25, 28);
            btn_MinimizarAplicacao.TabIndex = 4;
            btn_MinimizarAplicacao.UseVisualStyleBackColor = true;
            btn_MinimizarAplicacao.Click += btn_MinimizarAplicacao_Click;
            // 
            // btn_MaximizarAplicacao
            // 
            btn_MaximizarAplicacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_MaximizarAplicacao.Cursor = Cursors.Hand;
            btn_MaximizarAplicacao.Image = (Image)resources.GetObject("btn_MaximizarAplicacao.Image");
            btn_MaximizarAplicacao.Location = new Point(411, 11);
            btn_MaximizarAplicacao.Name = "btn_MaximizarAplicacao";
            btn_MaximizarAplicacao.Size = new Size(25, 28);
            btn_MaximizarAplicacao.TabIndex = 3;
            btn_MaximizarAplicacao.UseVisualStyleBackColor = true;
            btn_MaximizarAplicacao.Click += btn_MaximizarAplicacao_Click;
            // 
            // btn_FecharAplicacao
            // 
            btn_FecharAplicacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_FecharAplicacao.Cursor = Cursors.Hand;
            btn_FecharAplicacao.Image = (Image)resources.GetObject("btn_FecharAplicacao.Image");
            btn_FecharAplicacao.Location = new Point(436, 11);
            btn_FecharAplicacao.Name = "btn_FecharAplicacao";
            btn_FecharAplicacao.Size = new Size(25, 28);
            btn_FecharAplicacao.TabIndex = 2;
            btn_FecharAplicacao.UseVisualStyleBackColor = true;
            btn_FecharAplicacao.Click += btn_FecharAplicacao_Click;
            // 
            // panel_InformacoesInstituicao
            // 
            panel_InformacoesInstituicao.Controls.Add(gb_InformacoesIntituicao);
            panel_InformacoesInstituicao.Dock = DockStyle.Top;
            panel_InformacoesInstituicao.Location = new Point(0, 44);
            panel_InformacoesInstituicao.Name = "panel_InformacoesInstituicao";
            panel_InformacoesInstituicao.Size = new Size(464, 110);
            panel_InformacoesInstituicao.TabIndex = 2;
            panel_InformacoesInstituicao.Resize += panel_InformacoesInstituicao_Resize;
            // 
            // gb_InformacoesIntituicao
            // 
            gb_InformacoesIntituicao.Controls.Add(pictureBox_Usuario);
            gb_InformacoesIntituicao.Controls.Add(lbl_ExibicaoUsuarioFix);
            gb_InformacoesIntituicao.Controls.Add(lbl_ExibicaoPermissao);
            gb_InformacoesIntituicao.Controls.Add(lbl_ExibicaoPermissaoFix);
            gb_InformacoesIntituicao.Controls.Add(lbl_ExibicaoUsuario);
            gb_InformacoesIntituicao.Location = new Point(94, 7);
            gb_InformacoesIntituicao.Name = "gb_InformacoesIntituicao";
            gb_InformacoesIntituicao.Size = new Size(271, 97);
            gb_InformacoesIntituicao.TabIndex = 8;
            gb_InformacoesIntituicao.TabStop = false;
            gb_InformacoesIntituicao.Visible = false;
            // 
            // pictureBox_Usuario
            // 
            pictureBox_Usuario.Image = (Image)resources.GetObject("pictureBox_Usuario.Image");
            pictureBox_Usuario.Location = new Point(6, 13);
            pictureBox_Usuario.Name = "pictureBox_Usuario";
            pictureBox_Usuario.Size = new Size(71, 70);
            pictureBox_Usuario.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Usuario.TabIndex = 3;
            pictureBox_Usuario.TabStop = false;
            // 
            // lbl_ExibicaoUsuarioFix
            // 
            lbl_ExibicaoUsuarioFix.AutoSize = true;
            lbl_ExibicaoUsuarioFix.Location = new Point(83, 33);
            lbl_ExibicaoUsuarioFix.Name = "lbl_ExibicaoUsuarioFix";
            lbl_ExibicaoUsuarioFix.Size = new Size(50, 15);
            lbl_ExibicaoUsuarioFix.TabIndex = 0;
            lbl_ExibicaoUsuarioFix.Text = "Usuario:";
            // 
            // lbl_ExibicaoPermissao
            // 
            lbl_ExibicaoPermissao.AutoSize = true;
            lbl_ExibicaoPermissao.BackColor = SystemColors.Control;
            lbl_ExibicaoPermissao.Location = new Point(146, 60);
            lbl_ExibicaoPermissao.Name = "lbl_ExibicaoPermissao";
            lbl_ExibicaoPermissao.Size = new Size(12, 15);
            lbl_ExibicaoPermissao.TabIndex = 6;
            lbl_ExibicaoPermissao.Text = "-";
            // 
            // lbl_ExibicaoPermissaoFix
            // 
            lbl_ExibicaoPermissaoFix.AutoSize = true;
            lbl_ExibicaoPermissaoFix.Location = new Point(83, 60);
            lbl_ExibicaoPermissaoFix.Name = "lbl_ExibicaoPermissaoFix";
            lbl_ExibicaoPermissaoFix.Size = new Size(64, 15);
            lbl_ExibicaoPermissaoFix.TabIndex = 1;
            lbl_ExibicaoPermissaoFix.Text = "Permissão:";
            // 
            // lbl_ExibicaoUsuario
            // 
            lbl_ExibicaoUsuario.AutoSize = true;
            lbl_ExibicaoUsuario.BackColor = SystemColors.Control;
            lbl_ExibicaoUsuario.Location = new Point(132, 33);
            lbl_ExibicaoUsuario.Name = "lbl_ExibicaoUsuario";
            lbl_ExibicaoUsuario.Size = new Size(12, 15);
            lbl_ExibicaoUsuario.TabIndex = 5;
            lbl_ExibicaoUsuario.Text = "-";
            // 
            // panel_Central
            // 
            panel_Central.Controls.Add(gb_PrincipalLogin);
            panel_Central.Dock = DockStyle.Fill;
            panel_Central.Location = new Point(0, 154);
            panel_Central.Name = "panel_Central";
            panel_Central.Size = new Size(464, 394);
            panel_Central.TabIndex = 3;
            panel_Central.Resize += panel_Central_Resize;
            // 
            // gb_PrincipalLogin
            // 
            gb_PrincipalLogin.Controls.Add(lbl_ErrorLoginMsg);
            gb_PrincipalLogin.Controls.Add(btn_Login);
            gb_PrincipalLogin.Controls.Add(txtSenha);
            gb_PrincipalLogin.Controls.Add(txtNomeUsuario);
            gb_PrincipalLogin.Controls.Add(lbl_Password);
            gb_PrincipalLogin.Controls.Add(lbl_Login);
            gb_PrincipalLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_PrincipalLogin.Location = new Point(94, 126);
            gb_PrincipalLogin.Name = "gb_PrincipalLogin";
            gb_PrincipalLogin.Size = new Size(271, 149);
            gb_PrincipalLogin.TabIndex = 0;
            gb_PrincipalLogin.TabStop = false;
            gb_PrincipalLogin.Text = "Credenciais";
            // 
            // lbl_ErrorLoginMsg
            // 
            lbl_ErrorLoginMsg.AutoSize = true;
            lbl_ErrorLoginMsg.FlatStyle = FlatStyle.Flat;
            lbl_ErrorLoginMsg.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ErrorLoginMsg.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_ErrorLoginMsg.Image = (Image)resources.GetObject("lbl_ErrorLoginMsg.Image");
            lbl_ErrorLoginMsg.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_ErrorLoginMsg.Location = new Point(6, 121);
            lbl_ErrorLoginMsg.Name = "lbl_ErrorLoginMsg";
            lbl_ErrorLoginMsg.Size = new Size(180, 19);
            lbl_ErrorLoginMsg.TabIndex = 4;
            lbl_ErrorLoginMsg.Text = "   Usuario/Senha invalido.";
            lbl_ErrorLoginMsg.TextAlign = ContentAlignment.MiddleRight;
            lbl_ErrorLoginMsg.Visible = false;
            // 
            // btn_Login
            // 
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.Location = new Point(192, 117);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(73, 26);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Entrar";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(102, 75);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(134, 25);
            txtSenha.TabIndex = 3;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(102, 38);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(134, 25);
            txtNomeUsuario.TabIndex = 2;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(37, 78);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(49, 19);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Senha:";
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Location = new Point(37, 41);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(59, 19);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Usuario:";
            // 
            // Frm_Principal
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 548);
            Controls.Add(panel_Central);
            Controls.Add(panel_InformacoesInstituicao);
            Controls.Add(panel_BarraTitulo);
            MinimumSize = new Size(480, 587);
            Name = "Frm_Principal";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_BarraTitulo.ResumeLayout(false);
            panel_BarraTitulo.PerformLayout();
            panel_InformacoesInstituicao.ResumeLayout(false);
            gb_InformacoesIntituicao.ResumeLayout(false);
            gb_InformacoesIntituicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Usuario).EndInit();
            panel_Central.ResumeLayout(false);
            gb_PrincipalLogin.ResumeLayout(false);
            gb_PrincipalLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_BarraTitulo;
        private Button btn_FecharAplicacao;
        private Button btn_MinimizarAplicacao;
        private Button btn_MaximizarAplicacao;
        private Label lbl_BarraTitulo;
        private Panel panel_InformacoesInstituicao;
        private Label lbl_ExibicaoPermissaoFix;
        private Label lbl_ExibicaoUsuarioFix;
        private GroupBox gb_InformacoesIntituicao;
        private Panel panel_Central;
        public Label lbl_ExibicaoUsuario;
        public Label lbl_ExibicaoPermissao;
        public PictureBox pictureBox_Usuario;
        private GroupBox gb_PrincipalLogin;
        private TextBox txtSenha;
        private TextBox txtNomeUsuario;
        private Label lbl_Password;
        private Label lbl_Login;
        private Button btn_Login;
        private Label lbl_ErrorLoginMsg;
    }
}