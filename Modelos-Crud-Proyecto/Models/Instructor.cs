using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "La especialidad no debe ser mayor a 3 o 30 caracteres")]
        public String Especialidad { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Persona")]
        public int? PersonaID { get; set; }

        public Instructor()
        {
        }
        public Instructor(string especialidad, int personaID)
        {
            Especialidad = especialidad;
            PersonaID = personaID;
        }
        public virtual Persona persona { get; set; }
        public virtual ICollection<Asignacion> asignaciones { get; set; }
    }
}
