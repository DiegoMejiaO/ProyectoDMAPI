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

        public DbSet<ProyectoDMAPI.Data.Models.Client> Client { get; set; } = default!;
    }
}
