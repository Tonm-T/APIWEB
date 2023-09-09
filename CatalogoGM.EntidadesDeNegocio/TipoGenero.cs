using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.EntidadesDeNegocio
{
    public class TipoGenero
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tipo es Obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 Caracteres")]
        public string Tipo { get; set; }
        [NotMapped]
        public int top_aux {  get; set; }
        public List<CaracteristicasGame> caracteristicas { get; set;}
    }
}
