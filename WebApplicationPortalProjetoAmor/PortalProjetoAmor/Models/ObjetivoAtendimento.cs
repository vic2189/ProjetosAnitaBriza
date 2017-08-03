using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models
{
    public class ObjetivoAtendimento
    {   
        [Key]
        public int IDObjetivoAtendimento { get; set; }

        public int IDAssistido { get; set; }

        public virtual Assistido Assistido { get; set; }

        public string Objetivo { get; set; }
    }
}