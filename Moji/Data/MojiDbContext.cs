using Microsoft.EntityFrameworkCore;
using Moji.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Data
{
    public class MojiDbContext : DbContext
    {
        public DbSet<Personnage> Personnages { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Race> Races { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Classe>().ToTable("Classe");
            modelBuilder.Entity<Race>().ToTable("Race");
        }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=moji;Integrated Security=True;");
        }
    }
}
