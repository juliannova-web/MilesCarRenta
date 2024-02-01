using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCarRenta.Shared.Entities
{
    public class Client
    {
        public Guid Id { get; set; }

        [Display(Name = "Nombres")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Surname { get; set; } = null!;

        [Display(Name = "Tipo de Identificacón")]
        public string TypeIdetification { get; set; } = null!;

        [Display(Name = "Número Identificación")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string NumberIdentification { get; set; }

        [Display(Name = "Celular")]
        [MaxLength(15, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Phone { get; set; } = null!;

        [Display(Name = "Correo electronico")]
        [MaxLength(255, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Email { get; set; } = null!;
    }
}
