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
    class DBContext : DbContext
    {

        public DBContext()
        {
                
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
       


        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("Server=DESKTOP-GK4F9OM\\SQLEXPRESS ;Database=test2DB; Trusted_Connection=True");
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
