using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Estudiante
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El codigo no debe ser mayor a 20 caracteres")]
        public String Codigo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Persona")]
        public int? PersonaID { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(string codigo, int personaID)
        {
            Codigo = codigo;
            PersonaID = personaID;
        }

        public virtual Persona persona { get; set; }
        public virtual ICollection<Inscripcion> inscripciones { get; set; }
    }
}
