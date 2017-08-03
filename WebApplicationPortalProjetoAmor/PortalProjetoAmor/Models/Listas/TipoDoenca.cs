using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models.Listas
{
    public class TipoDoenca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTipoDoenca { get; set; }

        public string NomeTipoDoenca { get; set; }
    }
}

