using System.ComponentModel.DataAnnotations;

namespace UserSign_Up.Models
{
    public class UserRegisterRequest
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio"), 
            EmailAddress(ErrorMessage = "El {0} ingresado no es valido")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo {0} es obligatorio"), 
            MinLength(6,ErrorMessage = "El {0} debe tener como minimo {1} caracteres")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo {0} es obligatorio"), 
            Compare("Password",ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
