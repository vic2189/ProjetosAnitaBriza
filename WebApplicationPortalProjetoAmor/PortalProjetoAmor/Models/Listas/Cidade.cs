using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models.Listas
{
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCidade { get; set; }

        public string NomeCidade { get; set; }

        public int IDEstado { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
