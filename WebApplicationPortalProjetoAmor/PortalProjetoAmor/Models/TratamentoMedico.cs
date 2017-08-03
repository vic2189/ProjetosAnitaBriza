using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class TratamentoMedico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TratamentoMedicoID { get; set; }

        public string DescricraoTratamento { get; set; }
                
        public int AssistidoID { get; set; }

        public virtual Assistido Assistido { get; set; }
    }
}