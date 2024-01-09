using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoF_2.Models.Entidades;

namespace ProyectoF_2.Models
{
    public class LibreriaContext : DbContext
    {
        //opciones de get set
        public LibreriaContext()
        {

        }
        //opciones de la base de datos
        public LibreriaContext(DbContextOptions<LibreriaContext> options) : base(options)
        {

        }
        //debset llama alas entidades 
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Eleccion> Elecciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Votacion> Votaciones { get; set; }
        //modelo de creacion 
        //metodo para conectar la base de datos con el visual studio
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
