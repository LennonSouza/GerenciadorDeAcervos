namespace GerenciadorDeAcervos.Data.Models
{
    public class Colecao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Outros atributos específicos de Colecao, se necessário

        public int SetorId { get; set; }
        public Setor Setor { get; set; }
        public List<Objeto> Objetos { get; set; }
    }
}
