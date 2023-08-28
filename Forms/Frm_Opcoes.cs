using GerenciadorDeAcervos.Personalizacao;

namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_Opcoes : Form
    {
        public Frm_Opcoes() { InitializeComponent(); }

        private void Frm_Opcoes_Load(object sender, EventArgs e) { }

        private void ShowNewForm(object form)
        {
            if (this.panel_Opcoes.Controls.Count > 0) this.panel_Opcoes.Controls.RemoveAt(0);

            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.panel_Opcoes.Controls.Add(newForm);
            this.panel_Opcoes.Tag = newForm;
            newForm.Show();
        }

        private void panel_Opcoes_Resize(object sender, EventArgs e) { Personalisar.CenterGroupBoxInPanel(panel_Opcoes, gb_OpçoesMaster); }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Frm_Principal._principal.Size = new Size(665, 394);
            ShowNewForm(new Frm_CadastroUsuario());
        }
    }
}
