// add data class with entity framework to connect to database

using Microsoft.EntityFrameworkCore;

namespace YourNamespace
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=35.223.117.169;Database=my_db;Uid=test;Pwd=123456;TrustServerCertificate=Yes");
    }
}