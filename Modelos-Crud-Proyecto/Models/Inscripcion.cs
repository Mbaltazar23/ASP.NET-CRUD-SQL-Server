using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public GradosInscripcion Grado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Curso")]
        public int? CursoID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Estudiante")]
        public int? EstudianteID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public Double? Pago { get; set; }

        public Inscripcion()
        {
        }

        public Inscripcion(GradosInscripcion grado, int? cursoID, int? estudianteID, DateTime fecha, double? pago)
        {
            Grado = grado;
            CursoID = cursoID;
            EstudianteID = estudianteID;
            Fecha = fecha;
            Pago = pago;
        }

        public virtual Curso curso { get; set; }
        public virtual Estudiante estudiante { get; set; }
    }

    public enum GradosInscripcion
    {
        [Display(Name = "Primaria")]
        Primaria,
        [Display(Name = "Secundaria")]
        Secundaria,
        [Display(Name = "Universidad")]
        Universidad,
    }
}
