using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PortalProjetoAmor.Models
{
    public class Assistido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAssistido { get; private set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        public string EstadoCivil { get; set; }

        public bool TemFilhos { get; set; }

        public bool ConviveComFilhos { get; set; }

        public bool TemFamiliaEmSP { get; set; }

        public ICollection<Familia> InformacoesFamiliares { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public virtual ICollection<Documento> Documentos { get; set; }

        public virtual Endereco Endereco { get; set; }

        public string Escolaridade { get; set; }

        public bool TemCurso { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }

        public virtual ICollection<TratamentoMedico> TratamentosMedicos { get; set; }

        public virtual ICollection<Doenca> Doencas { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}",ApplyFormatInEditMode = true)]
        public DateTime UltimaVisitaMedico { get; set; }

        public virtual ICollection<ObjetivoAtendimento> Objetivos { get; set; }

        public virtual ICollection<Atendimento> Atendimentos { get; set; }

        public int SaldoBonus { get; set; }


    }
}