using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Model.Listas
{
    public class Bairro
    {
        [ForeignKey("Cidade")]
        public int IDCidade { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDBairro { get; set; }

        public string NomeBairro { get; set; }
    }
}
