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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5RNF8P0;Database=imuSeyahat;User ID=DESKTOP-5RNF8P0\\abdulbari; Initial Catalog=imuSeyahat;Integrated Security=true");
        }
        public DbSet<Place> places { get; set; }
    }
}
