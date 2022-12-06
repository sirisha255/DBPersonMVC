

using System.ComponentModel.DataAnnotations;

namespace DBPersonMVC.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public List<City>? Cities { get; set; }
        [Required]
        public string? CountryName { get; set; }
   
        public List<Person>? People { get; set; } = new List<Person>();
    
    
    }
}
