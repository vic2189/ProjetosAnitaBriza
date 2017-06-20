using PortalProjetoAmor.Model.Listas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Familia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDFamilia { get; set; }

        [ForeignKey("Assistido")]
        public int IDAssistido { get; set; }

        [ForeignKey("Parentesco")]
        public Parentesco IDParentesco { get; set; }

        public bool ContatoComParente { get; set; }
        [ForeignKey("Endereco")]
        public Endereco EnderecoParente { get; set; }

        public string Observacao { get; set; }

        public int IDEndereco { get; set; }

    }
}