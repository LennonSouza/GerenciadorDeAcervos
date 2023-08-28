namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_PesquisarColecao
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
            panelColecaoPesquisar = new Panel();
            gb_ColecaoPesquisar = new GroupBox();
            panelColecaoPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // panelColecaoPesquisar
            // 
            panelColecaoPesquisar.Controls.Add(gb_ColecaoPesquisar);
            panelColecaoPesquisar.Dock = DockStyle.Fill;
            panelColecaoPesquisar.Location = new Point(0, 0);
            panelColecaoPesquisar.Name = "panelColecaoPesquisar";
            panelColecaoPesquisar.Size = new Size(615, 355);
            panelColecaoPesquisar.TabIndex = 0;
            // 
            // gb_ColecaoPesquisar
            // 
            gb_ColecaoPesquisar.Dock = DockStyle.Fill;
            gb_ColecaoPesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_ColecaoPesquisar.Location = new Point(0, 0);
            gb_ColecaoPesquisar.Name = "gb_ColecaoPesquisar";
            gb_ColecaoPesquisar.Size = new Size(615, 355);
            gb_ColecaoPesquisar.TabIndex = 0;
            gb_ColecaoPesquisar.TabStop = false;
            gb_ColecaoPesquisar.Text = "Pesquisar Coleção";
            // 
            // Frm_PesquisarColecao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 355);
            Controls.Add(panelColecaoPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_PesquisarColecao";
            Text = "Frm_PesquisarColecao";
            Load += Frm_PesquisarColecao_Load;
            panelColecaoPesquisar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelColecaoPesquisar;
        private GroupBox gb_ColecaoPesquisar;
    }
}