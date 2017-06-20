using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models
{
    public class Doenca
    {
        [Key]
        public int IDDoenca { get; set; }

        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        [ForeignKey("TipoDoenca")]
        public int IDTipoDoenca { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string Observacao { get; set; }
    }
}