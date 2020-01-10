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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=moji;Integrated Security=True;");
        }

        public Personnage FindById(int Id)
        {
            var ctx = new MojiDbContext();
            return ctx.Personnages.Find(Id);
        }
    }
}
