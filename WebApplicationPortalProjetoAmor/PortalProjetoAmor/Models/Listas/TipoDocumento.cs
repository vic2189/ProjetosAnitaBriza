using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models.Listas
{
    public class TipoDocumento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTipoDocumento { get; set; }

        public string NomeTipoDocumento { get; set; }
    }
}
