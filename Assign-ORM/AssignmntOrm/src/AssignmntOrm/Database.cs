using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmntOrm
{
    public class Database : DbContext

    {
        public DbSet<UpdateModels> UpdateModels { get; set; }
        public DbSet<ProductModels> ProductModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=(localDb)\mssqllocaldb;Database=EfGetstarted.MyDatabase;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

    }
}
