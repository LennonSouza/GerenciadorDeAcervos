namespace GerenciadorDeAcervos.Models.Colecoes
{
    public class ObjetoColecao
    {
        public string Nome { get; }
        public string Localizacao { get; }
        public int CamposTexto { get; }
        public int QuantidadeImagens { get; }

        public ObjetoColecao(string nome, string localizacao, int camposTexto, int quantidadeImagens)
        {
            Nome = nome;
            Localizacao = localizacao;
            CamposTexto = camposTexto;
            QuantidadeImagens = quantidadeImagens;
        }
    }
}
