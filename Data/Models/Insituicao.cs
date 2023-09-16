namespace GerenciadorDeAcervos.Data.Models
{
    public class Insituicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros atributos específicos de Geral, se necessário

        public List<Setor> Setores { get; set; }
    }
}
