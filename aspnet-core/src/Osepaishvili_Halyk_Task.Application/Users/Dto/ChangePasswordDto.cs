using System.ComponentModel.DataAnnotations;

namespace Osepaishvili_Halyk_Task.Users.Dto
{
    public class ChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
