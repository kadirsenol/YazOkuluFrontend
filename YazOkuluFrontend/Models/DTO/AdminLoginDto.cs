using System.ComponentModel.DataAnnotations;

namespace YazOkuluFrontend.Models.DTO
{
    public class AdminLoginDto
    {
        [Required(ErrorMessage = "Kullanıcı adı boş olamaz.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şifre boş olamaz.")]
        public string Password { get; set; } = string.Empty;
    }
}
