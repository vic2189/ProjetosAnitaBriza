using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models
{
    public class ObjetivoAtendimento
    {
        [Key]
        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        public string Objetivo { get; set; }
    }
}