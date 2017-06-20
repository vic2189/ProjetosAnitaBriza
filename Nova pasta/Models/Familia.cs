using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Familia
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDFamilia { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Parentesco")]
        public Parentesco IDParentesco { get; set; }

        public bool ContatoComParente { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Endereco")]
        public Endereco EnderecoParente { get; set; }

        public string Observacao { get; set; }

        public int IDEndereco { get; set; }

    }
}