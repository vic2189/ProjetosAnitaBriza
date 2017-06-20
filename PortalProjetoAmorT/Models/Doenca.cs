using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Doenca
    {
        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        public int TipoDoenca { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string Observacao { get; set; }
    }
}