using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAcervos.Data.Models
{
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }

        public string UsuarioNome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public int NivelPermissao { get; set; }
        public byte[] Imagem { get; set; } = new byte[0];
    }
}
