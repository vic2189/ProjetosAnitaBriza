using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Curso
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Assistido")]
        public int IDAssistido { get; set; }
        [Required]
        public string NomeCurso { get; set; }

        public DateTime DataInicio { get; set; }

        public bool EstaCursando { get; set; }

        public bool FinalizouCurso { get; set; }

        public string Observacao { get; set; }
    }
}