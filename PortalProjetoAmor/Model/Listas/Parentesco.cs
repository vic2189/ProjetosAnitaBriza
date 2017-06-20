using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Model.Listas
{
    public class Parentesco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDParentesco { get; set; }

        public string TipoDeParentesco { get; set; }

    }
}