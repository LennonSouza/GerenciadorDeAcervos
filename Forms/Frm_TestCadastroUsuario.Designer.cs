namespace GerenciadorDeAcervos.Forms
{
    partial class Frm_TestCadastroUsuario
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
            panel_test1 = new Panel();
            panel_test3 = new Panel();
            add = new Button();
            Voltar = new Button();
            panel_test2 = new Panel();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_test1.SuspendLayout();
            panel_test3.SuspendLayout();
            panel_test2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_test1
            // 
            panel_test1.Controls.Add(panel_test3);
            panel_test1.Controls.Add(panel_test2);
            panel_test1.Dock = DockStyle.Fill;
            panel_test1.Location = new Point(0, 0);
            panel_test1.Name = "panel_test1";
            panel_test1.Size = new Size(311, 197);
            panel_test1.TabIndex = 0;
            panel_test1.Resize += panel_test1_Resize;
            // 
            // panel_test3
            // 
            panel_test3.Controls.Add(add);
            panel_test3.Controls.Add(Voltar);
            panel_test3.Location = new Point(0, 100);
            panel_test3.Name = "panel_test3";
            panel_test3.Size = new Size(311, 85);
            panel_test3.TabIndex = 1;
            // 
            // add
            // 
            add.Location = new Point(180, 19);
            add.Name = "add";
            add.Size = new Size(88, 56);
            add.TabIndex = 1;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(44, 19);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(90, 56);
            Voltar.TabIndex = 0;
            Voltar.Text = "voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // panel_test2
            // 
            panel_test2.Controls.Add(groupBox1);
            panel_test2.Dock = DockStyle.Top;
            panel_test2.Location = new Point(0, 0);
            panel_test2.Name = "panel_test2";
            panel_test2.Size = new Size(311, 100);
            panel_test2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 73);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 45);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Frm_TestCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 197);
            Controls.Add(panel_test1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_TestCadastroUsuario";
            Text = "Frm_TestCadastroUsuario";
            Load += Frm_TestCadastroUsuario_Load;
            panel_test1.ResumeLayout(false);
            panel_test3.ResumeLayout(false);
            panel_test2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_test1;
        private Panel panel_test3;
        private Panel panel_test2;
        private GroupBox groupBox1;
        private Button add;
        private Button Voltar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}