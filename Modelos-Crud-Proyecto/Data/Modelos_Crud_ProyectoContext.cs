using Microsoft.EntityFrameworkCore;

namespace Modelos_Crud_Proyecto.Data
{
    public class Modelos_Crud_ProyectoContext : DbContext
    {
        public Modelos_Crud_ProyectoContext(DbContextOptions<Modelos_Crud_ProyectoContext> options)
            : base(options)
        {
        }

        public DbSet<Modelos_Crud_Proyecto.Models.Persona> Persona { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Instructor> Instructor { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Inscripcion> Inscripcion { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Estudiante> Estudiante { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Curso> Curso { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Categoria> Categoria { get; set; }

        public DbSet<Modelos_Crud_Proyecto.Models.Asignacion> Asignacion { get; set; }
    }
}
