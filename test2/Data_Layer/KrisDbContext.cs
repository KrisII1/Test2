using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class KrisDbContext : DbContext
    {

        public KrisDbContext()
        {
                
        }
        public KrisDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlServer("Server=DESKTOP-IU1LH1E;Database=test2DB;Trusted_Connection=True");
            }
            base.OnConfiguring(OptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
