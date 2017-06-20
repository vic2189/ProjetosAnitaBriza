using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models
{
    public class Documento
    {
        [Key]
        public int IDDocumento { get; set; }

        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }
        [Required]
        public string TipoDocumento { get; set; }
        [Required]
        public string IdentificacaoDocumento { get; set; }
    }
}