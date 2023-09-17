using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorDeAcervos.Data.Models
{
    public class Objeto
    {
        public int ObjetoId { get; set; }
        public string Nome { get; set; }

        public int ColecaoId { get; set; }

        [ForeignKey("ColecaoId")]
        public Colecao Colecao { get; set; }

        public Objeto()
        {
            Colecao = new();
        }
    }
}
