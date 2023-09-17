using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeAcervos.Data.Models
{
    public class Colecao
    {
        public int ColecaoId { get; set; }
        public string Nome { get; set; }

        public int SetorId { get; set; }

        [ForeignKey("SetorId")]
        public Setor Setor { get; set; }
        public List<Objeto> Objetos { get; set; }
    }
}
