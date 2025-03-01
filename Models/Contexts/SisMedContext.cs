using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisMed.Models.Entities;
using SisMed.Models.EntityConfiguration;

namespace SisMed.Models.Contexts
{
    
    public class SisMedContext : DbContext
    {
        private readonly IConfiguration _configurarion;

        public SisMedContext(IConfiguration configurarion)
        {
            _configurarion = configurarion;
        }

        public DbSet <Medico> Medicos => Set<Medico>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configurarion.GetConnectionString("SisMed"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
        }
    }
}