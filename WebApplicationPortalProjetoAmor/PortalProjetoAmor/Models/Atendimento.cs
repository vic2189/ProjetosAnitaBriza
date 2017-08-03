using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PortalProjetoAmor.Models
{
    public class Atendimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAtendimento { get; private set; }
        
        public DateTime DataAtendimento { get; set; }

        public int QuantidadeCalcas { get; set; }

        public int QuantidadeCamisas { get; set; }

        public int QuantidadeBlusas { get; set; }

        public int QuantidadeShorts { get; set; }

        public int QuantidadeSapatoTenis { get; set; }

        public int QuantidadeChinelo { get; set; }

        public int QuantidadeRoupaIntima { get; set; }

        public int QuantidadeParDeMeias { get; set; }

        public int QuantidadeCinto { get; set; }

        public int QuantidadeBoneChapeu { get; set; }

        public int IDAssistido { get; set; }

        public virtual Assistido Assistido { get; set; }
    }
}