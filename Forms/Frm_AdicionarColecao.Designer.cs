namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_AdicionarColecao
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
            gb_AdicionarColecao = new GroupBox();
            panel_AdicionarColecao = new Panel();
            gb_ColecaoInformacaoNomeLocalizacao = new GroupBox();
            btn_ColecaoCadastro = new Button();
            txt_ColecaoQuantidadeDeImagens = new TextBox();
            lbl_ColecaoQuantidadeDeImagens = new Label();
            txt_ColecaoQuantidadeStrings = new TextBox();
            lbl_ColecaoQuantidadeStrings = new Label();
            lbl_ColecaoAdicionarNome = new Label();
            txt_ColecaoLocalizacao = new TextBox();
            txt_ColecaoNome = new TextBox();
            lbl_ColecaoLocalizacao = new Label();
            gb_AdicionarColecao.SuspendLayout();
            panel_AdicionarColecao.SuspendLayout();
            gb_ColecaoInformacaoNomeLocalizacao.SuspendLayout();
            SuspendLayout();
            // 
            // gb_AdicionarColecao
            // 
            gb_AdicionarColecao.Controls.Add(panel_AdicionarColecao);
            gb_AdicionarColecao.Dock = DockStyle.Fill;
            gb_AdicionarColecao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_AdicionarColecao.Location = new Point(0, 0);
            gb_AdicionarColecao.Name = "gb_AdicionarColecao";
            gb_AdicionarColecao.Size = new Size(631, 394);
            gb_AdicionarColecao.TabIndex = 0;
            gb_AdicionarColecao.TabStop = false;
            gb_AdicionarColecao.Text = "Adicionar Coleção";
            // 
            // panel_AdicionarColecao
            // 
            panel_AdicionarColecao.Controls.Add(gb_ColecaoInformacaoNomeLocalizacao);
            panel_AdicionarColecao.Dock = DockStyle.Fill;
            panel_AdicionarColecao.Location = new Point(3, 21);
            panel_AdicionarColecao.Name = "panel_AdicionarColecao";
            panel_AdicionarColecao.Size = new Size(625, 370);
            panel_AdicionarColecao.TabIndex = 0;
            panel_AdicionarColecao.Resize += panel_AdicionarColecao_Resize;
            // 
            // gb_ColecaoInformacaoNomeLocalizacao
            // 
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(btn_ColecaoCadastro);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(txt_ColecaoQuantidadeDeImagens);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(lbl_ColecaoQuantidadeDeImagens);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(txt_ColecaoQuantidadeStrings);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(lbl_ColecaoQuantidadeStrings);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(lbl_ColecaoAdicionarNome);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(txt_ColecaoLocalizacao);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(txt_ColecaoNome);
            gb_ColecaoInformacaoNomeLocalizacao.Controls.Add(lbl_ColecaoLocalizacao);
            gb_ColecaoInformacaoNomeLocalizacao.Location = new Point(145, 140);
            gb_ColecaoInformacaoNomeLocalizacao.Name = "gb_ColecaoInformacaoNomeLocalizacao";
            gb_ColecaoInformacaoNomeLocalizacao.Size = new Size(334, 172);
            gb_ColecaoInformacaoNomeLocalizacao.TabIndex = 5;
            gb_ColecaoInformacaoNomeLocalizacao.TabStop = false;
            // 
            // btn_ColecaoCadastro
            // 
            btn_ColecaoCadastro.Cursor = Cursors.Hand;
            btn_ColecaoCadastro.Location = new Point(245, 136);
            btn_ColecaoCadastro.Name = "btn_ColecaoCadastro";
            btn_ColecaoCadastro.Size = new Size(83, 30);
            btn_ColecaoCadastro.TabIndex = 5;
            btn_ColecaoCadastro.Text = "Cadastrar";
            btn_ColecaoCadastro.UseVisualStyleBackColor = true;
            btn_ColecaoCadastro.Click += btn_ColecaoCadastro_Click;
            // 
            // txt_ColecaoQuantidadeDeImagens
            // 
            txt_ColecaoQuantidadeDeImagens.Location = new Point(245, 105);
            txt_ColecaoQuantidadeDeImagens.Name = "txt_ColecaoQuantidadeDeImagens";
            txt_ColecaoQuantidadeDeImagens.Size = new Size(79, 25);
            txt_ColecaoQuantidadeDeImagens.TabIndex = 4;
            // 
            // lbl_ColecaoQuantidadeDeImagens
            // 
            lbl_ColecaoQuantidadeDeImagens.AutoSize = true;
            lbl_ColecaoQuantidadeDeImagens.Location = new Point(13, 108);
            lbl_ColecaoQuantidadeDeImagens.Name = "lbl_ColecaoQuantidadeDeImagens";
            lbl_ColecaoQuantidadeDeImagens.Size = new Size(159, 19);
            lbl_ColecaoQuantidadeDeImagens.TabIndex = 6;
            lbl_ColecaoQuantidadeDeImagens.Text = "Quantidade de Imagens:";
            // 
            // txt_ColecaoQuantidadeStrings
            // 
            txt_ColecaoQuantidadeStrings.Location = new Point(245, 78);
            txt_ColecaoQuantidadeStrings.Name = "txt_ColecaoQuantidadeStrings";
            txt_ColecaoQuantidadeStrings.Size = new Size(79, 25);
            txt_ColecaoQuantidadeStrings.TabIndex = 3;
            // 
            // lbl_ColecaoQuantidadeStrings
            // 
            lbl_ColecaoQuantidadeStrings.AutoSize = true;
            lbl_ColecaoQuantidadeStrings.Location = new Point(13, 81);
            lbl_ColecaoQuantidadeStrings.Name = "lbl_ColecaoQuantidadeStrings";
            lbl_ColecaoQuantidadeStrings.Size = new Size(192, 19);
            lbl_ColecaoQuantidadeStrings.TabIndex = 4;
            lbl_ColecaoQuantidadeStrings.Text = "Quantidade Campos de texto:";
            // 
            // lbl_ColecaoAdicionarNome
            // 
            lbl_ColecaoAdicionarNome.AutoSize = true;
            lbl_ColecaoAdicionarNome.Location = new Point(13, 27);
            lbl_ColecaoAdicionarNome.Name = "lbl_ColecaoAdicionarNome";
            lbl_ColecaoAdicionarNome.Size = new Size(49, 19);
            lbl_ColecaoAdicionarNome.TabIndex = 0;
            lbl_ColecaoAdicionarNome.Text = "Nome:";
            // 
            // txt_ColecaoLocalizacao
            // 
            txt_ColecaoLocalizacao.Location = new Point(126, 51);
            txt_ColecaoLocalizacao.Name = "txt_ColecaoLocalizacao";
            txt_ColecaoLocalizacao.Size = new Size(198, 25);
            txt_ColecaoLocalizacao.TabIndex = 2;
            // 
            // txt_ColecaoNome
            // 
            txt_ColecaoNome.Location = new Point(126, 24);
            txt_ColecaoNome.Name = "txt_ColecaoNome";
            txt_ColecaoNome.Size = new Size(198, 25);
            txt_ColecaoNome.TabIndex = 1;
            // 
            // lbl_ColecaoLocalizacao
            // 
            lbl_ColecaoLocalizacao.AutoSize = true;
            lbl_ColecaoLocalizacao.Location = new Point(13, 54);
            lbl_ColecaoLocalizacao.Name = "lbl_ColecaoLocalizacao";
            lbl_ColecaoLocalizacao.Size = new Size(80, 19);
            lbl_ColecaoLocalizacao.TabIndex = 2;
            lbl_ColecaoLocalizacao.Text = "Localização:";
            // 
            // Frm_AdicionarColecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 394);
            Controls.Add(gb_AdicionarColecao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_AdicionarColecao";
            Text = "Frm_AdicionarColecao";
            Load += Frm_AdicionarColecao_Load;
            gb_AdicionarColecao.ResumeLayout(false);
            panel_AdicionarColecao.ResumeLayout(false);
            gb_ColecaoInformacaoNomeLocalizacao.ResumeLayout(false);
            gb_ColecaoInformacaoNomeLocalizacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_AdicionarColecao;
        private Panel panel_AdicionarColecao;
        private GroupBox gb_ColecaoInformacaoNomeLocalizacao;
        private Label lbl_ColecaoAdicionarNome;
        private TextBox txt_ColecaoLocalizacao;
        private TextBox txt_ColecaoNome;
        private Label lbl_ColecaoLocalizacao;
        private Label lbl_ColecaoQuantidadeDeImagens;
        private TextBox txt_ColecaoQuantidadeStrings;
        private Label lbl_ColecaoQuantidadeStrings;
        private TextBox txt_ColecaoQuantidadeDeImagens;
        private Button btn_ColecaoCadastro;
    }
}