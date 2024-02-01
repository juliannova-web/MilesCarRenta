using Microsoft.AspNetCore.Identity;
using MilesCarRenta.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace MilesCarRenta.Shared.Entities
{
    public class User : IdentityUser
    {

        [Display(Name = "Tipo de Identificacón")]
        public string Tipo_Identificacion { get; set; } = null!;

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Numero_Documento { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Apellidos { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(200, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Direccion { get; set; }


        [Display(Name = "Telefono")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Telefono { get; set; }


        [Display(Name = "Tipo de usuario")]
        public TipoUsuario Tipo_Usuario { get; set; }

        [Display(Name = "Usuario")]
        public string FullName => $"{Nombres} {Apellidos}";

    }
}
