namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_Opcoes
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
            panel_Opcoes = new Panel();
            gb_Opcoes = new GroupBox();
            gb_OpçoesMaster = new GroupBox();
            btn_Usuarios = new Button();
            btn_Colecoes = new Button();
            btn_Setores = new Button();
            panel_Opcoes.SuspendLayout();
            gb_Opcoes.SuspendLayout();
            gb_OpçoesMaster.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Opcoes
            // 
            panel_Opcoes.Controls.Add(gb_Opcoes);
            panel_Opcoes.Dock = DockStyle.Fill;
            panel_Opcoes.Location = new Point(0, 0);
            panel_Opcoes.Name = "panel_Opcoes";
            panel_Opcoes.Size = new Size(615, 355);
            panel_Opcoes.TabIndex = 0;
            panel_Opcoes.Resize += panel_Opcoes_Resize;
            // 
            // gb_Opcoes
            // 
            gb_Opcoes.Controls.Add(gb_OpçoesMaster);
            gb_Opcoes.Dock = DockStyle.Fill;
            gb_Opcoes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gb_Opcoes.Location = new Point(0, 0);
            gb_Opcoes.Name = "gb_Opcoes";
            gb_Opcoes.Size = new Size(615, 355);
            gb_Opcoes.TabIndex = 0;
            gb_Opcoes.TabStop = false;
            gb_Opcoes.Text = "Opções disponiveis";
            // 
            // gb_OpçoesMaster
            // 
            gb_OpçoesMaster.Controls.Add(btn_Usuarios);
            gb_OpçoesMaster.Controls.Add(btn_Colecoes);
            gb_OpçoesMaster.Controls.Add(btn_Setores);
            gb_OpçoesMaster.Location = new Point(81, 62);
            gb_OpçoesMaster.Name = "gb_OpçoesMaster";
            gb_OpçoesMaster.Size = new Size(455, 137);
            gb_OpçoesMaster.TabIndex = 0;
            gb_OpçoesMaster.TabStop = false;
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Location = new Point(121, 76);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(201, 36);
            btn_Usuarios.TabIndex = 3;
            btn_Usuarios.Text = "Usuarios";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // btn_Colecoes
            // 
            btn_Colecoes.Location = new Point(233, 34);
            btn_Colecoes.Name = "btn_Colecoes";
            btn_Colecoes.Size = new Size(201, 36);
            btn_Colecoes.TabIndex = 1;
            btn_Colecoes.Text = "Coleções";
            btn_Colecoes.UseVisualStyleBackColor = true;
            // 
            // btn_Setores
            // 
            btn_Setores.Location = new Point(17, 34);
            btn_Setores.Name = "btn_Setores";
            btn_Setores.Size = new Size(201, 36);
            btn_Setores.TabIndex = 0;
            btn_Setores.Text = "Setores";
            btn_Setores.UseVisualStyleBackColor = true;
            // 
            // Frm_Opcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 355);
            Controls.Add(panel_Opcoes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Opcoes";
            Text = "Frm_Opcoes";
            Load += Frm_Opcoes_Load;
            panel_Opcoes.ResumeLayout(false);
            gb_Opcoes.ResumeLayout(false);
            gb_OpçoesMaster.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gb_OpçoesMaster;
        private Button btn_Usuarios;
        private Button btn_Colecoes;
        private Button btn_Setores;
        public GroupBox gb_Opcoes;
        public Panel panel_Opcoes;
    }
}