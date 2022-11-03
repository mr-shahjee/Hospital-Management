
using Microsoft.EntityFrameworkCore;

namespace PracticeCrud.Models
{
    public class UserContext : DbContext
    {
        
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {
         
        }




        public DbSet<User> users {get; set; }
        public DbSet<Products> products {get; set;}
        public DbSet<Schema> schemas {get; set;}
        public DbSet<Gad7> gad7s {get; set;}


// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             var configuration = new ConfigurationBuilder()
//                 .SetBasePath(Directory.GetCurrentDirectory())
//                 .AddJsonFile("appsettings.json")
//                 .Build();

//             var connectionString = configuration.GetConnectionString("DefaultConnection");
//             optionsBuilder.UseSqlServer(connectionString);
//         }


 

    }
}