using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Model.Listas
{
    public class Estado
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Pais")]
        public int IDPais { get; set; }
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDEstado { get; set; }

        public string NomeEstado { get; set; }
    }
}
