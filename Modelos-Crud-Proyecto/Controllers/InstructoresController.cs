using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelos_Crud_Proyecto.Data;
using Modelos_Crud_Proyecto.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos_Crud_Proyecto.Controllers
{
    public class InstructoresController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public InstructoresController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Instructores
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["EspecialidadParam"] = String.IsNullOrEmpty(ordenar) ? "especialidad_desc" : "";
            ViewData["NombreInstructorParam"] = ordenar == "nombreIns_asc" ? "nombreIns_desc" : "nombreIns_asc";
            ViewData["ApellidoInstructorParam"] = ordenar == "apellidoIns_asc" ? "apellidoIns_desc" : "apellidoIns_asc";

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

            var instructores = from s in _context.Instructor.Include(i => i.persona) select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                instructores = instructores.Where(s => s.Especialidad.Contains(buscarTexto) || s.persona.Nombres.Contains(buscarTexto) || s.persona.Apellidos.Contains(buscarTexto));
            }

            switch (ordenar)
            {
                case "especialidad_desc":
                    instructores = instructores.OrderByDescending(s => s.Especialidad);
                    break;
                case "nombreIns_desc":
                    instructores = instructores.OrderByDescending(s => s.persona.Nombres);
                    break;
                case "nombreIns_asc":
                    instructores = instructores.OrderBy(s => s.persona.Nombres);
                    break;
                case "apellidoIns_desc":
                    instructores = instructores.OrderByDescending(s => s.persona.Nombres);
                    break;
                case "apellidoIns_asc":
                    instructores = instructores.OrderBy(s => s.persona.Nombres);
                    break;
                default:
                    instructores = instructores.OrderBy(s => s.Especialidad);
                    break;
            }
            //var proyecto_ModelosCRUDContext = _context.Instructor.Include(i => i.persona);
            //return View(await proyecto_ModelosCRUDContext.ToListAsync());

            int tamanioPag = 3;
            return View(await Paginacion<Instructor>.CrearAsync(instructores.AsNoTracking(), pag ?? 1, tamanioPag));
        }

        // GET: Instructores/Create
        public IActionResult Create()
        {
            ViewData["PersonaID"] = new SelectList(_context.Persona, "ID", "Nombres");
            Instructor instructor = new Instructor();
            return PartialView("NuevoInstructor", instructor);
        }

        [HttpPost]
        public IActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Instructor.Add(instructor);
                _context.SaveChanges();
            }
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", instructor.PersonaID);
            return PartialView("NuevoInstructor", instructor);
        }

        // GET: Instructores/Edit/5
        public IActionResult Edit(int id)
        {
            var instructor = _context.Instructor.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", instructor.PersonaID);
            return PartialView("EditarInstructor", instructor);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Instructor.Update(instructor);
                _context.SaveChanges();
            }
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", instructor.PersonaID);
            return PartialView("EditarInstructor", instructor);
        }


        public IActionResult Details(int id)
        {
            var instructor = _context.Instructor.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", instructor.PersonaID);
            return PartialView("VerInstructor", instructor);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var instructor = _context.Instructor.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", instructor.PersonaID);
            return PartialView("QuitarInstructor", instructor);
        }

    
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var instructor = _context.Instructor.Find(id);
            _context.Instructor.Remove(instructor);
            _context.SaveChanges();
            return PartialView("QuitarInstructor", instructor);
        }

        private bool InstructorExists(int id)
        {
            return _context.Instructor.Any(e => e.ID == id);
        }
    }
}
