using System.ComponentModel.DataAnnotations;

namespace Assessment.GlobalKinetic.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}