using Microsoft.EntityFrameworkCore;

namespace Tarea4_ProyectoBlazor_ProgramacionWeb.Modelos
{
    public class SerieContext : DbContext
    {
        public DbSet<SeriePeliculaLibro> SeriePeliculaLibros { get; set; } = null!;

        public DbSet<Personaje> Personajes { get; set; } = null!;
        public SerieContext(DbContextOptions<SerieContext> options) : base(options)
        {

        }
    }
}
