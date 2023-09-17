using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAcervos.Data.Models
{
    public class Usuario : Permissao
    {
        public Guid UsuarioId { get; set; }

        public string UsuarioNome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public byte[] Imagem { get; set; } = new byte[0];

        // Adicione uma propriedade de navegação para Permissao
        public Permissao Permissao { get; set; }

        public Usuario()
        {
            Permissao = new();
        }
    }
}
