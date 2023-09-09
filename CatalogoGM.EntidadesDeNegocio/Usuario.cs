using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.EntidadesDeNegocio
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es Obligatorio")]
        [Display(Name = "Rol")]
        public int RolId {  get; set; }

        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Login es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password es Obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Estatus es Obligatorio")]
        public byte Estatus {  get; set; }

        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        public Rol Rol { get; set; }

        [NotMapped]
        public int Top_Aux {  get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirmar el Password")]
        [StringLength(30, ErrorMessage = "Caracteres entre 5 a 30", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password deben ser iguales")]
        [Display(Name = "Confirmar Password")]
        public string ConfirmPassword_aux {  get; set; }
    }

    public enum Estatus_Usuario
    {
        ACTIVO = 1,
        INACTIVO = 2,
    }
}
