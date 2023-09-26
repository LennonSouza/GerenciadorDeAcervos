namespace GerenciadorDeAcervos.Data.Models
{
    public class Objeto
    {
        public int ObjetoId { get; set; }
        public string Nome { get; set; }

        public int ColecaoId { get; set; }
        public Colecao Colecao { get; set; }
    }
}
