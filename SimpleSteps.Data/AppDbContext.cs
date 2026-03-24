using Microsoft.EntityFrameworkCore;
using SimpleSteps.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSteps.Data
{
    public class AppDbContext: DbContext
    {

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {


        }


  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Nur dann notwendig wenn Tabellenname nicht Klassennamen entspricht
            modelBuilder.Entity<AppUser>().ToTable("AppUser");
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<Room>().ToTable("Room");
        }


    }
}
