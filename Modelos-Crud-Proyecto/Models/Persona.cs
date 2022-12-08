using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos_Crud_Proyecto.Models
{
    public class Persona
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Los apellidos no deben ser mayor a 3 o 30 caracteres")]
        public String Apellidos { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Los nombres no deben ser mayor a 3 o 20 caracteres")]
        public String Nombres { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name ="Fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El documento no debe ser mayor a 3 a 15 caracteres")]
        public String Documento { get; set; }
        [Required(ErrorMessage = "Debe ingresar un correo")]
        [EmailAddress(ErrorMessage = "El correo Ingresado no es Valido")]
        public String Email { get; set; }
        [StringLength(10, MinimumLength = 9, ErrorMessage = "El Telefono ingresado no es Valido")]
        public String Telefono { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "La direccion no debe exceder mas de 3 a 100 caracteres")]
        [Display(Name = "Dirección")]
        public String DireccionPersona { get; set; }
        [Display(Name = "Estado")]
        public Boolean EstadoPersona { get; set; }

        public Persona()
        {
        }

        public Persona(string apellidos, string nombres, DateTime fechaNacimiento, string documento, string email, string telefono, string direccionPersona, bool estadoPersona)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            FechaNacimiento = fechaNacimiento;
            Documento = documento;
            Email = email;
            Telefono = telefono;
            DireccionPersona = direccionPersona;
            EstadoPersona = estadoPersona;
        }
    }
}
