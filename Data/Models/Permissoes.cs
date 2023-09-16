namespace GerenciadorDeAcervos.Data.Models
{
    public class Permissoes
    {
        public int PermissaoId { get; set; }
        public string Nome { get; set; }
        public int NivelPermissao { get; set; }

        public int SetorId { get; set; }
        public Setor Setor { get; set; }

        public int ColecaoId { get; set; }
        public Colecao Colecao { get; set; }

        public int ObjetoId { get; set; }
        public Objeto Objeto { get; set; }
    }
}
