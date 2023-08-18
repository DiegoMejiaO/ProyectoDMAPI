using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Data
{
    public class ProyectoDMAPIDbContext : DbContext
    {
        public ProyectoDMAPIDbContext (DbContextOptions<ProyectoDMAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Medicine> Medicines { get; set; } = default;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable(nameof(Client));
            modelBuilder.Entity<UserRole>().ToTable(nameof(UserRole));
            modelBuilder.Entity<User>().ToTable(nameof(User));
            modelBuilder.Entity<Medicine>().ToTable(nameof(Medicine));

            base.OnModelCreating(modelBuilder);
        }
    }
}
