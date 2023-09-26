namespace GerenciadorDeAcervos.Data.Models
{
    public class Usuario : Permissao
    {
        public Guid UsuarioId { get; set; }

        public string UsuarioNome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public byte[] Imagem { get; set; } = new byte[0];

        public Permissao Permissao { get; set; }
    }
}
