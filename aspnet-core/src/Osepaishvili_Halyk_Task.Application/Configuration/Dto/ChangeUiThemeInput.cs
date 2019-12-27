using System.ComponentModel.DataAnnotations;

namespace Osepaishvili_Halyk_Task.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
