using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class ObjetivoAtendimento
    {
        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        public string Objetivo { get; set; }
    }
}