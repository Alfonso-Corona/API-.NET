using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Villa de lujo",
                    ImagenUrl = "",
                    Ocupantes = 6,
                    MetrosCuadrados = 200,
                    Tarifa = 1000,
                    Amenidad = "Piscina",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Diferente",
                    Detalle = "Villa en otro lado",
                    ImagenUrl = "",
                    Ocupantes = 2,
                    MetrosCuadrados = 30,
                    Tarifa = 100,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }

            );
        }
    }
}
