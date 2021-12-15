using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImuSeyahat.Models;
namespace ImuSeyahat.DbHelpers
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-CSD22RP; database=Seyahat; uid=sa; pwd=Mssql12345");
        }
        public DbSet<Place> places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.SeedDatabase();
        }
    }
}
