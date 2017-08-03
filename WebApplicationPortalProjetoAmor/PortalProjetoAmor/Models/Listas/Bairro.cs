using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models.Listas
{
    public class Bairro
    {        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDBairro { get; set; }

        public string NomeBairro { get; set; }

        public int IDCidade { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
