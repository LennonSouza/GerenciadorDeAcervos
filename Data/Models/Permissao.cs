using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeAcervos.Data.Models
{
    public class Permissao
    {
        public int PermissaoId { get; set; }
        public int NivelPermissao { get; set; }
    }
}
