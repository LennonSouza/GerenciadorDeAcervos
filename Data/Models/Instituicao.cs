namespace GerenciadorDeAcervos.Data.Models
{
    public class Instituicao
    {
        public int InstituicaoId { get; set; }
        public string Nome { get; set; }
        public List<Setor> Setores { get; set; }

        public Instituicao()
        {
            Setores = new();
        }
    }
}
