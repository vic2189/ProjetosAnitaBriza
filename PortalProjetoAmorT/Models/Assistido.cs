using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalProjetoAmor.Models
{
    public class Assistido
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAssistido { get; private set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string EstadoCivil { get; set; }

        public bool TemFilhos { get; set; }

        public bool ConviveComFilhos { get; set; }

        public bool TemFamiliaEmSP { get; set; }

        public Familia InformacoesFamiliares { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public List<Documento> Documentos { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Endereco")]
        public Endereco Endereco { get; set; }

        public string Escolaridade { get; set; }

        public bool TemCurso { get; set; }

        public List<Curso> Cursos { get; set; }

        public string TratamentoMedico { get; set; }

        public List<Doenca> Doencas { get; set; }

        public DateTime UltimaVisitaMedico { get; set; }

        public List<ObjetivoAtendimento> Objetivos { get; set; }

        public List<Atendimento> Atendimentos { get; set; }

        public int SaldoBonus { get; set; }


    }
}