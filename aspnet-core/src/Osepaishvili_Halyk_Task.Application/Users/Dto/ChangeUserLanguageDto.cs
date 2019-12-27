using System.ComponentModel.DataAnnotations;

namespace Osepaishvili_Halyk_Task.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}