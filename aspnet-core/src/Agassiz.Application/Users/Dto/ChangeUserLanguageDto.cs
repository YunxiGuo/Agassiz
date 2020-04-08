using System.ComponentModel.DataAnnotations;

namespace Agassiz.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}