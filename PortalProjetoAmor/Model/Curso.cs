using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Curso
    {
        [Key]
        public int IDCurso { get; set; }

        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        [Required]
        public string NomeCurso { get; set; }

        public string Instituicao { get; set; }

        public string MesAnoInicio { get; set; }

        public string MesAnoFim { get; set; }

        public bool EstaCursando { get; set; }

        public bool FinalizouCurso { get; set; }

        public string Observacao { get; set; }
    }
}