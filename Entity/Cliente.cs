using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;

namespace Evaluacion_Practica.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "La longitud es muy larga")]
        public string Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Ingrese un numero de teléfono valido")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="El campo debe ser un email valido")]
        public string Email { get; set; }
    }
}
