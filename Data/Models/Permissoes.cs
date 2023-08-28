namespace GerenciadorDeAcervos.Data.Models
{
    public class Permissoes
    {
        public int PermissaoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int NivelPermissao { get; set; }
        public int SetorId { get; set; }
        public int ColecaoId { get; set; }
        public int ObjetoId { get; set; }
    }
}
