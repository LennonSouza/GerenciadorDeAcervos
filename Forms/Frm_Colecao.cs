namespace GerenciadorDeAcervos.Forms
{
    public partial class Frm_Colecao : Form
    {
        public Frm_Colecao()
        {
            InitializeComponent();
        }

        private void Frm_Colecao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ColecaoAdicionar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new();
            toolTip.SetToolTip(btn_ColecaoAdicionar, "Adicionar nova Coleção.");
        }

        private void btn_ColecaoAdicionar_Click(object sender, EventArgs e)
        {
            ShowNewForm(new Frm_AdicionarColecao(), this.panel_ColecaoInsercaoInformacao);
        }

        private void ShowNewForm(object form, Panel panel)
        {
            if (panel.Controls.Count > 0) panel.Controls.RemoveAt(0);

            Form newForm = form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panel.Controls.Add(newForm);
            panel.Tag = newForm;
            newForm.Show();
        }

        private void btn_ColecaoPesquisar_Click(object sender, EventArgs e)
        {
            ShowNewForm(new Frm_PesquisarColecao(), this.panel_ColecaoInsercaoInformacao);
        }

        private void btn_ColecaoVoltar_Click(object sender, EventArgs e)
        {
            ShowNewForm(new Frm_Opcoes(), this.panel_Colecao);
        }
    }
}
