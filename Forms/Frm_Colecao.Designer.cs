namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_Colecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Colecao));
            panel_Colecao = new Panel();
            gb_Colecao = new GroupBox();
            panel_ColecaoInsercaoInformacao = new Panel();
            panel_ColecaoBotoes = new Panel();
            btn_ColecaoVoltar = new Button();
            btn_ColecaoPesquisar = new Button();
            btn_ColecaoAdicionar = new Button();
            panel_Colecao.SuspendLayout();
            gb_Colecao.SuspendLayout();
            panel_ColecaoBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Colecao
            // 
            panel_Colecao.Controls.Add(gb_Colecao);
            panel_Colecao.Dock = DockStyle.Fill;
            panel_Colecao.Location = new Point(0, 0);
            panel_Colecao.Name = "panel_Colecao";
            panel_Colecao.Size = new Size(631, 394);
            panel_Colecao.TabIndex = 0;
            // 
            // gb_Colecao
            // 
            gb_Colecao.Controls.Add(panel_ColecaoInsercaoInformacao);
            gb_Colecao.Controls.Add(panel_ColecaoBotoes);
            gb_Colecao.Dock = DockStyle.Fill;
            gb_Colecao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Colecao.Location = new Point(0, 0);
            gb_Colecao.Name = "gb_Colecao";
            gb_Colecao.Size = new Size(631, 394);
            gb_Colecao.TabIndex = 0;
            gb_Colecao.TabStop = false;
            gb_Colecao.Text = "Coleção";
            // 
            // panel_ColecaoInsercaoInformacao
            // 
            panel_ColecaoInsercaoInformacao.Dock = DockStyle.Fill;
            panel_ColecaoInsercaoInformacao.Location = new Point(85, 21);
            panel_ColecaoInsercaoInformacao.Name = "panel_ColecaoInsercaoInformacao";
            panel_ColecaoInsercaoInformacao.Size = new Size(543, 370);
            panel_ColecaoInsercaoInformacao.TabIndex = 3;
            // 
            // panel_ColecaoBotoes
            // 
            panel_ColecaoBotoes.Controls.Add(btn_ColecaoVoltar);
            panel_ColecaoBotoes.Controls.Add(btn_ColecaoPesquisar);
            panel_ColecaoBotoes.Controls.Add(btn_ColecaoAdicionar);
            panel_ColecaoBotoes.Dock = DockStyle.Left;
            panel_ColecaoBotoes.Location = new Point(3, 21);
            panel_ColecaoBotoes.Name = "panel_ColecaoBotoes";
            panel_ColecaoBotoes.Size = new Size(82, 370);
            panel_ColecaoBotoes.TabIndex = 2;
            // 
            // btn_ColecaoVoltar
            // 
            btn_ColecaoVoltar.Cursor = Cursors.Hand;
            btn_ColecaoVoltar.Dock = DockStyle.Bottom;
            btn_ColecaoVoltar.Image = (Image)resources.GetObject("btn_ColecaoVoltar.Image");
            btn_ColecaoVoltar.Location = new Point(0, 335);
            btn_ColecaoVoltar.Name = "btn_ColecaoVoltar";
            btn_ColecaoVoltar.Size = new Size(82, 35);
            btn_ColecaoVoltar.TabIndex = 3;
            btn_ColecaoVoltar.UseVisualStyleBackColor = true;
            btn_ColecaoVoltar.Click += btn_ColecaoVoltar_Click;
            // 
            // btn_ColecaoPesquisar
            // 
            btn_ColecaoPesquisar.Cursor = Cursors.Hand;
            btn_ColecaoPesquisar.Image = (Image)resources.GetObject("btn_ColecaoPesquisar.Image");
            btn_ColecaoPesquisar.Location = new Point(3, 82);
            btn_ColecaoPesquisar.Name = "btn_ColecaoPesquisar";
            btn_ColecaoPesquisar.Size = new Size(74, 73);
            btn_ColecaoPesquisar.TabIndex = 2;
            btn_ColecaoPesquisar.Tag = "Pesquisar Coleção";
            btn_ColecaoPesquisar.UseVisualStyleBackColor = true;
            btn_ColecaoPesquisar.Click += btn_ColecaoPesquisar_Click;
            // 
            // btn_ColecaoAdicionar
            // 
            btn_ColecaoAdicionar.Cursor = Cursors.Hand;
            btn_ColecaoAdicionar.Image = (Image)resources.GetObject("btn_ColecaoAdicionar.Image");
            btn_ColecaoAdicionar.Location = new Point(3, 3);
            btn_ColecaoAdicionar.Name = "btn_ColecaoAdicionar";
            btn_ColecaoAdicionar.Size = new Size(74, 73);
            btn_ColecaoAdicionar.TabIndex = 1;
            btn_ColecaoAdicionar.Tag = "Adicionar Coleção";
            btn_ColecaoAdicionar.UseVisualStyleBackColor = true;
            btn_ColecaoAdicionar.Click += btn_ColecaoAdicionar_Click;
            btn_ColecaoAdicionar.MouseHover += btn_ColecaoAdicionar_MouseHover;
            // 
            // Frm_Colecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 394);
            Controls.Add(panel_Colecao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Colecao";
            Text = "Colecao";
            Load += Frm_Colecao_Load;
            panel_Colecao.ResumeLayout(false);
            gb_Colecao.ResumeLayout(false);
            panel_ColecaoBotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Colecao;
        private GroupBox gb_Colecao;
        private Button btn_ColecaoAdicionar;
        private Panel panel_ColecaoBotoes;
        private Panel panel_ColecaoInsercaoInformacao;
        private Button btn_ColecaoPesquisar;
        private Button btn_ColecaoVoltar;
    }
}