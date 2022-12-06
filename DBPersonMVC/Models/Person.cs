using System.ComponentModel.DataAnnotations;

namespace DBPersonMVC.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? PhoneNumber { get; set; }
        public int CityId { get; set; }
        
    }
}
