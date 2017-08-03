using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Models.Listas
{
    public class Estado
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDEstado { get; set; }

        public string NomeEstado { get; set; }

        public int IDPais { get; set; }

        public virtual Pais Pais { get; set; }

    }
}
