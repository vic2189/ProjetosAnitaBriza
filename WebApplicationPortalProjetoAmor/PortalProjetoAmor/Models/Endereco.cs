using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDEndereco { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }

        public virtual Assistido  Assistido{ get; set; }

    }
}