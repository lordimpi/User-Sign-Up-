using System.ComponentModel.DataAnnotations;

namespace UserSign_Up.Models
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio"),
            EmailAddress(ErrorMessage = "El {0} ingresado no es valido")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Password { get; set; } = string.Empty;
    }
}
