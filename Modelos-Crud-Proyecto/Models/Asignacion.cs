using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Asignacion
    {
        public int AsignacionID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? CursoID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? InstructorID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime Fecha { get; set; }

        public Asignacion()
        {
        }

        public Asignacion(int cursoID, int instructorID, DateTime fecha)
        {
            CursoID = cursoID;
            InstructorID = instructorID;
            Fecha = fecha;
        }

        public virtual Curso curso { get; set; }
        public virtual Instructor instructor { get; set; }
    }
}
