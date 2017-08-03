using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PortalProjetoAmor.Models.Listas;

namespace PortalProjetoAmor.Models
{
    public class Doenca
    {
        [Key]
        public int IDDoenca { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string Observacao { get; set; }

        public int IDAssistido { get; set; }

        public virtual  Assistido Assistido { get; set; }

        public int IDTipoDoenca { get; set; }

        public virtual TipoDoenca TipoDoenca { get; set; }
    }
}