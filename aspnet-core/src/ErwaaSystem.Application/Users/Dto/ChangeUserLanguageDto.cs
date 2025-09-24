using System.ComponentModel.DataAnnotations;

namespace ErwaaSystem.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}