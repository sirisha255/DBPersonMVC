using System.ComponentModel.DataAnnotations;

namespace DBPersonMVC.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string? CityName { get; set; }
       
        public List<Person>? People { get; set; }
        public int? CountryId { get; set; } 
        public Country? Country { get; set; }
         
       // public List<Person> persons { get; set; } = new List<Person>(); 

    }
}
