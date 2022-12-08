using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelos_Crud_Proyecto.Data;
using Modelos_Crud_Proyecto.Models;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos_Crud_Proyecto.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public EstudiantesController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Estudiantes
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["CodigoParam"] = String.IsNullOrEmpty(ordenar) ? "codigo_desc" : "";
            ViewData["NombreEstudianteParam"] = ordenar == "nombreEst_asc" ? "nombreEst_desc" : "nombreEst_asc";
            ViewData["ApellidoEstudianteParam"] = ordenar == "apellidoEst_asc" ? "apellidoEst_desc" : "apellidoEst_asc";

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

            var estudiantes = from s in _context.Estudiante.Include(e => e.persona) select s;
            if (!String.IsNullOrEmpty(buscarTexto))
            {
                estudiantes = estudiantes.Where(s => s.Codigo.Contains(buscarTexto) || s.persona.Nombres.Contains(buscarTexto));
            }
            switch (ordenar)
            {
                case "codigo_desc":
                    estudiantes = estudiantes.OrderByDescending(s => s.Codigo);
                    break;
                case "nombreEst_desc":
                    estudiantes = estudiantes.OrderByDescending(s => s.persona.Nombres);
                    break;
                case "nombreEst_asc":
                    estudiantes = estudiantes.OrderBy(s => s.persona.Nombres);
                    break;
                case "apellidoEst_desc":
                    estudiantes = estudiantes.OrderByDescending(s => s.persona.Apellidos);
                    break;
                case "apellidoEst_asc":
                    estudiantes = estudiantes.OrderBy(s => s.persona.Apellidos);
                    break;
                default:
                    estudiantes = estudiantes.OrderBy(s => s.Codigo);
                    break;
            }

            //var proyecto_ModelosCRUDContext = _context.Estudiante.Include(e => e.persona);

            //return View(await proyecto_ModelosCRUDContext.ToListAsync());
            int tamanioPag = 3;
            return View(await Paginacion<Estudiante>.CrearAsync(estudiantes.AsNoTracking(), pag ?? 1, tamanioPag));
        }

        // GET: Estudiantes/Create
        public IActionResult Create()
        {
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres");
            Estudiante estu = new Estudiante();
            return PartialView("NuevoEstudiante", estu);
        }

        [HttpPost]
        public IActionResult Create(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Estudiante.Add(estudiante);
                _context.SaveChanges();
            }
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", estudiante.PersonaID);
            return PartialView("NuevoEstudiante", estudiante);
        }

        // GET: Estudiantes/Edit/5
        public IActionResult Edit(int id)
        {
            var estudiantes = _context.Estudiante.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", estudiantes.PersonaID);
            return PartialView("EditarEstudiante", estudiantes);
        }


        [HttpPost]
        public IActionResult Edit(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Estudiante.Update(estudiante);
                _context.SaveChanges();
            }
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", estudiante.PersonaID);
            return PartialView("EditarEstudiante", estudiante);
        }

        public IActionResult Details(int id)
        {
            var estudiantes = _context.Estudiante.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", estudiantes.PersonaID);
            return PartialView("VerEstudiante", estudiantes);
        }
        // GET: Estudiantes/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var estudiantes = _context.Estudiante.Where(e => e.ID == id).Include(e => e.persona).FirstOrDefault();
            ViewData["PersonaID"] = new SelectList(_context.Set<Persona>(), "ID", "Nombres", estudiantes.PersonaID);
            return PartialView("QuitarEstudiante", estudiantes);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var estudiante = _context.Estudiante.Find(id);
            _context.Estudiante.Remove(estudiante);
            _context.SaveChanges();
            return PartialView("QuitarEstudiante", estudiante);
        }
        private bool EstudianteExists(int id)
        {
            return _context.Estudiante.Any(e => e.ID == id);
        }
    }
}
