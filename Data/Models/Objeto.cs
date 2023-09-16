namespace GerenciadorDeAcervos.Data.Models
{
    public class Objeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros atributos específicos de Objeto, se necessário

        public int ColecaoId { get; set; }
        public Colecao Colecao { get; set; }
    }
}
