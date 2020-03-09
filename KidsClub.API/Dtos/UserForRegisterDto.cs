using System.ComponentModel.DataAnnotations;

namespace KidsClub.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Le mot de passe doit contenir entre 4 et 8 caractères!")]
        public string Password { get; set; }
    }
}