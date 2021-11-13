using Level.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level.DbContexts
{
    public class MSSQLContext :DbContext
    {
        public MSSQLContext(DbContextOptions<MSSQLContext> opt):base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin { ID=1, NameSurname="Bunyamin", Password= "202cb962ac59075b964b07152d234b70", UserName="sasatower"});

            modelBuilder.Entity<Tour>().HasOne(ho => ho.Country).WithMany(wm => wm.Tours).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<News>().HasOne(ho => ho.Category).WithMany(wm => wm.News).OnDelete(DeleteBehavior.SetNull);
        }
        public DbSet<Tour> Tour { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
