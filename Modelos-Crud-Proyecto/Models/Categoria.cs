using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public String Nombre { get; set; }
        [StringLength(256, MinimumLength = 3, ErrorMessage = "La descripción no debe exceder los 256 caracteres")]
        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }

        public virtual ICollection<Curso> cursos { get; set; }
    }
}
