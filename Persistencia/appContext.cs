using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class appContext: DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Sourse =USUARIO-PC\\SQLSERVER; Initial Catalog= ControlVeterinariaMU");
            }

        }
    }
}