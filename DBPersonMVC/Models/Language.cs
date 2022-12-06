using System.ComponentModel.DataAnnotations;

namespace DBPersonMVC.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string? LanguageName { get; set; }
        public List<Person>? People { get; set; }
    }
}
