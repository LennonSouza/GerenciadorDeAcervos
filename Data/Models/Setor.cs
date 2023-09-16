namespace GerenciadorDeAcervos.Data.Models
{
    public class Setor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros atributos específicos de Setor, se necessário

        public int InsituicaoId { get; set; }
        public Insituicao Insituicao { get; set; }
        public List<Colecao> Colecoes { get; set; }
    }
}
