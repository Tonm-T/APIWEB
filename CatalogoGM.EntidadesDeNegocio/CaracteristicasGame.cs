using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.EntidadesDeNegocio
{
    public class CaracteristicasGame
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TipoGenerosId")]
        [Required(ErrorMessage = "Genero es Obligatorio")]
        [Display(Name = "TipoGenero")]

        public int TipoGenerosId {  get; set; }

        [Required(ErrorMessage = "Titulo es Obligatorio")]
        [StringLength(50, ErrorMessage = "Maximo 50 Caracteres")]

        public string Titulo { get; set; }

        [Required(ErrorMessage = "Img es Obligatoria")]
        [StringLength(350, ErrorMessage = "350 img por Titulo")]

        public string Img { get; set; }

        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "Plataforma es Obligatoria")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Plataforma { get; set;}

        [Required(ErrorMessage = "Genero es Obligatoria")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Genero { get; set; }

        [Required(ErrorMessage = "Formato es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Formato { get; set;}

        [Required(ErrorMessage = "size es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo  30 Caracteres")]

        public string size {  get; set; }

        [Required(ErrorMessage = "Fecha es Obligatoria")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Fecha { get; set;}

        [Required(ErrorMessage = "Version es Obligatoria")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]

        public string Version { get; set;}

        [NotMapped]
        public int Top_Aux { get; set;}
        [ValidateNever]
        public List<TipoGenero> TipoGenero { get; set; }
    }
}
