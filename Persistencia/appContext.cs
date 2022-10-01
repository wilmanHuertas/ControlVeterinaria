using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class appContext: DbContext
    {
        public appContext(DbContextOptions<appContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<AsistenteVeterinaria> Asistentes {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<AgendaCitas> Citas {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Persona
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().HasData(
                new Persona {Id = 1, documento = 1, nombreCompleto = "Veterinaria Mundo Animal", telefono = 3194482143, contraseña = "callefalsa123", perfil = "admin", correo = "vet.mundoanimal@gmail.com"});
            modelBuilder.Entity<Persona>().HasData(
                new Persona {Id = 2, documento = 4651289, nombreCompleto = "Jorge Hernandez Cruz", telefono = 3102568465, contraseña = "1234", perfil = "vet", correo = "jorge_36@gmail.com"});
            modelBuilder.Entity<Persona>().HasData(
                new Persona {Id = 3, documento = 1016526325, nombreCompleto = "Juliana Torres Arango", telefono = 3205641523, contraseña = "1234", perfil = "client", correo = "julianat@gmail.com"});
            //Asistente Veterinaria
            modelBuilder.Entity<AsistenteVeterinaria>().HasData(new AsistenteVeterinaria
            {
                Id = 1,
                docVeterinaria = 1,
                docResponsable = 1001256489,
                nombreResponsable = "Karen Daniela Ochoa Vasquez",
                telefono = 3164586231
            });
            //Veterinario
            modelBuilder.Entity<Veterinario>().HasData(new Veterinario
            {
                Id = 1,
                docVeterinario = 4651289,
                numMatriProfesional = 1001256    
            });
            //Mascota
            modelBuilder.Entity<Mascota>().HasData(new Mascota
            {
                Id = 1,
                docDueño = 1016526325,
                nombreMascota = "verano",
                edadMascota = 8,
                tipoMascota = "Perro",
                raza = "Labrador"
            });
            //Agendar cita
            modelBuilder.Entity<AgendaCitas>().HasData(new AgendaCitas
            {
                idAgendaCita = 1,
                idMascota = 1,
                idVeterinario = 1,
                fechaHora = new DateTime(2022, 10, 02)
            });
        }
    }
}