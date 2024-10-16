using Microsoft.EntityFrameworkCore;
using SunAndMoonServer.Models;


namespace SunAndMoonServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Book> Books {  get; set; }
    }
}
