using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe Exceder mas de 20 o 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? CategoriaID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(512, MinimumLength = 3, ErrorMessage = "La descripción no debe Exceder mas de 200 o 512 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? Creditos { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? Horas { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int? Costo { get; set; }

        public Boolean Estado { get; set; }


        public Curso()
        {

        }
        public Curso(string nombre, int categoriaID, string descripcion, int creditos, int horas, int costo, bool estado, Categoria categoria)
        {
            Nombre = nombre;
            CategoriaID = categoriaID;
            Descripcion = descripcion;
            Creditos = creditos;
            Horas = horas;
            Costo = costo;
            Estado = estado;
            this.categoria = categoria;
        }

        public virtual Categoria categoria { get; set; }

        public virtual ICollection<Asignacion> asignaciones { get; set; }
        public virtual ICollection<Inscripcion> inscripciones { get; set; }
    }
}
