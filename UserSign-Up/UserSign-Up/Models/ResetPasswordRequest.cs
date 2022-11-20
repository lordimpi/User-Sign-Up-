using System.ComponentModel.DataAnnotations;

namespace UserSign_Up.Models
{
    public class ResetPasswordRequest
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Token { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo {0} es obligatorio"),
            MinLength(6, ErrorMessage = "El {0} debe tener como minimo {1} caracteres")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo {0} es obligatorio"),
            Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
