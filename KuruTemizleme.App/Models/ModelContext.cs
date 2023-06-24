using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuruTemizleme.App.Models
{
    public class ModelContext:DbContext
    {
     
        public DbSet<Users> User { get; set; }
        public DbSet<LogTable> Log { get; set; }
        
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<Ucretler> Ucret { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = KuruTemizlemedb; Integrated Security = true; TrustServerCertificate=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Randevu>().ToTable("Randevu");
            
            modelBuilder.Entity<LogTable>().ToTable("LogKayit");
            modelBuilder.Entity<Ucretler>().ToTable("Ucretler");

            modelBuilder.Entity<Users>().HasIndex(u => u.id).IsUnique();          
           
            modelBuilder.Entity<Randevu>().HasIndex(i => i.id).IsUnique();
            modelBuilder.Entity<LogTable>().HasIndex(i => i.id).IsUnique();
            modelBuilder.Entity<Ucretler>().HasIndex(i => i.id).IsUnique();
        }

    }
}
