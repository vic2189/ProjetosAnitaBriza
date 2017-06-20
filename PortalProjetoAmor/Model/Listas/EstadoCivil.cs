using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalProjetoAmor.Model.Listas
{
    public class EstadoCivil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDEstatoCivil { get; set; }

        public string NomeEstadoCivil { get; set; }
    }
}
