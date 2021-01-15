using Microsoft.EntityFrameworkCore;

namespace REST_ASP.NET5_Udemy.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() 
        {
        
        }
        public MySQLContext(DbContextOptions<MySQLContext> opcoes) : base(opcoes) { }

        public DbSet<Person> Pessoas { get; set; }
    }
}
