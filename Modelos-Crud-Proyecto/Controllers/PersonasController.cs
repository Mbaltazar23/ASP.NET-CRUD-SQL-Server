using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelos_Crud_Proyecto.Data;
using Modelos_Crud_Proyecto.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos_Crud_Proyecto.Controllers
{
    public class PersonasController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public PersonasController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Personas
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["ApellidosParam"] = String.IsNullOrEmpty(ordenar) ? "apellido_desc" : "";
            ViewData["NombresParam"] = ordenar == "nombre_asc" ? "nombre_desc" : "nombre_asc"; ;
            ViewData["EmailParam"] = ordenar == "email_asc" ? "email_desc" : "email_asc";
            ViewData["DireccionParam"] = ordenar == "direccion_asc" ? "direccion_desc" : "direccion_asc";
            ViewData["DocumentoParam"] = ordenar == "documento_asc" ? "documento_desc" : "documento_asc";

            if (buscarTexto != null)
            {
                pag = 1;
            }
            else
            {
                buscarTexto = filtrar;
            }
            ViewData["Filtro"] = buscarTexto;
            ViewData["ordenarFiltro"] = ordenar;

            var personas = from s in _context.Persona select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                personas = personas.Where(s => s.Nombres.Contains(buscarTexto) || s.Apellidos.Contains(buscarTexto) || s.Email.Contains(buscarTexto) || s.DireccionPersona.Contains(buscarTexto));
            }

            switch (ordenar)
            {
                case "apellido_desc":
                    personas = personas.OrderByDescending(s => s.Apellidos);
                    break;
                case "nombre_desc":
                    personas = personas.OrderByDescending(s => s.Nombres);
                    break;
                case "nombre_asc":
                    personas = personas.OrderBy(s => s.Nombres);
                    break;
                case "email_desc":
                    personas = personas.OrderByDescending(s => s.Email);
                    break;
                case "email_asc":
                    personas = personas.OrderBy(s => s.Email);
                    break;
                case "direccion_desc":
                    personas = personas.OrderByDescending(s => s.DireccionPersona);
                    break;
                case "direccion_asc":
                    personas = personas.OrderBy(s => s.DireccionPersona);
                    break;
                case "documento_desc":
                    personas = personas.OrderByDescending(s => s.Documento);
                    break;
                case "documento_asc":
                    personas = personas.OrderBy(s => s.Documento);
                    break;
                default:
                    personas = personas.OrderBy(s => s.Apellidos);
                    break;
            }
            int tamanioPage = 3;
            return View(await Paginacion<Persona>.CrearAsync(personas.AsNoTracking(), pag ?? 1, tamanioPage));
        }

        [HttpGet]
        public IActionResult Create()
        {
            Persona per = new Persona();
            return PartialView("_NuevaPersona", per);
        }

        [HttpPost]
        public IActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Add(persona);
                _context.SaveChanges();
            }
            return PartialView("_NuevaPersona", persona);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var personas = _context.Persona.Where(p => p.ID == id).FirstOrDefault();
            return PartialView("_EditarPersona", personas);
        }

        [HttpPost]
        public IActionResult Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Update(persona);
                _context.SaveChanges();
            }
            return PartialView("_EditarPersona", persona);
        }
        public IActionResult Details(int id)
        {
            var persona = _context.Persona.Where(p => p.ID == id).FirstOrDefault();
            return PartialView("_VerPersona", persona);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var persona = _context.Persona.Where(p => p.ID == id).FirstOrDefault();
            return PartialView("_QuitarPersona", persona);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var persona = _context.Persona.Find(id);
            _context.Persona.Remove(persona);
            _context.SaveChanges();
            return PartialView("_QuitarPersona", persona);
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.ID == id);
        }
    }
}
