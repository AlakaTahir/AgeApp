using AgeApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeApp.Migrations
{
    public class AgeAppDatabaseContext: DbContext
    {
        public AgeAppDatabaseContext()
        {
        }

        public AgeAppDatabaseContext(DbContextOptions<AgeAppDatabaseContext> options)
             : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;Database=AgeAppDb;user=root;password=alaka1983");
        }

        public  DbSet<DateCollectorModel> DateHistory { get; set; }
        
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
