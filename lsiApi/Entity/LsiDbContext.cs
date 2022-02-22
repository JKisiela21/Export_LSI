using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lsiApi.Entity
{
    public class LsiDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb; Database=lsiDb; Trusted_Connection=True;";

        public DbSet<Export> Exports { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Export>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
