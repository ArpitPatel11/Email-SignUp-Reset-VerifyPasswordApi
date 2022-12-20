using System.ComponentModel.DataAnnotations;

namespace TokenAPI.Models
{
    public class ResetPassWordRequest
    {
        [Required]
        public string passwordResetToken { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters, dude!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
