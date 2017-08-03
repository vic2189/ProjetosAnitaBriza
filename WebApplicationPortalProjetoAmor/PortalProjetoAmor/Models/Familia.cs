using PortalProjetoAmor.Models.Listas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Familia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDFamilia { get; set; }
        
        public string Observacao { get; set; }

        public bool ContatoComParente { get; set; }

        public int IDAssistido { get; set; }

        public virtual Assistido Assistido { get; set; }

        public int IDParentesco { get; set; }

        public virtual Parentesco Parentesco { get; set; }

        public int IDEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}