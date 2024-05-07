using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
    public class TodoListDbContext : DbContext
    {
        public DbSet<TodoEntry> TodoList { get; set; }

        public TodoListDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TodoListServer;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
