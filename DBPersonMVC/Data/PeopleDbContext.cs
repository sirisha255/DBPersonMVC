using DBPersonMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DBPersonMVC.Data
{
    public class PeopleDbContext : DbContext
    {

        public PeopleDbContext(DbContextOptions<PeopleDbContext> Options) : base(Options) 
        { }
        public DbSet<Person>? People { get; set; } = default;
        public DbSet<City>? Cities { get; set; } = default;
        public DbSet<Country>? Countries { get; set; } = default;
        public DbSet<Language>? Languages { get; set; } = default;

    }
}
