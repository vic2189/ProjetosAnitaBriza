using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Model.Listas
{
    public class Cidade
    {
        [ForeignKey("Estado")]
        public int IDEstado { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCidade { get; set; }

        public string NomeCidade { get; set; }
    }
}
