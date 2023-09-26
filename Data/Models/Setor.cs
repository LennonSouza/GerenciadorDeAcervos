namespace GerenciadorDeAcervos.Data.Models
{
    public class Setor
    {
        public int SetorId { get; set; }
        public string Nome { get; set; }

        public int InstituicaoId { get; set; }
        public Instituicao Insituicao { get; set; }

        public List<Colecao> Colecoes { get; set; }
    }
}
