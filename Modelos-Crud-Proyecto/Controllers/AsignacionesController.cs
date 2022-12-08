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
    public class AsignacionesController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public AsignacionesController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Asignaciones
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["NombreCurso"] = String.IsNullOrEmpty(ordenar) ? "nombreCurso_desc" : "";
            ViewData["InstructorEspecial"] = ordenar == "instructor_asc" ? "instructor_desc" : "instructor_asc";
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

            var asignaciones = from s in _context.Asignacion.Include(a => a.curso).Include(a => a.instructor) select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                asignaciones = asignaciones.Where(s => s.curso.Nombre.Contains(buscarTexto) || s.instructor.Especialidad.Contains(buscarTexto));
            }
            switch (ordenar)
            {
                case "nombreCurso_desc":
                    asignaciones = asignaciones.OrderByDescending(s => s.curso.Nombre);
                    break;
                case "instructor_desc":
                    asignaciones = asignaciones.OrderByDescending(s => s.instructor.Especialidad);
                    break;
                case "instructor_asc":
                    asignaciones = asignaciones.OrderBy(s => s.instructor.Especialidad);
                    break;
                default:
                    asignaciones = asignaciones.OrderBy(s => s.curso.Nombre);
                    break;
            }
            //var proyecto_ModelosCRUDContext = _context.Asignacion.Include(a => a.curso).Include(a => a.instructor);
            //return View(await proyecto_ModelosCRUDContext.ToListAsync());
            int tamanioPag = 3;
            return View(await Paginacion<Asignacion>.CrearAsync(asignaciones.AsNoTracking(), pag ?? 1, tamanioPag));
        }


        // GET: Asignaciones/Create
        public IActionResult Create()
        {
            Asignacion asignacion = new Asignacion();
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Nombre");
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad");
            return PartialView("nuevaAsignacion", asignacion);
        }


        [HttpPost]
        public IActionResult Create(Asignacion asignacion)
        {
            if (ModelState.IsValid)
            {
                _context.Asignacion.Add(asignacion);
                _context.SaveChanges();
            }
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Nombre", asignacion.CursoID);
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad", asignacion.InstructorID);
            return PartialView("nuevaAsignacion", asignacion);
        }

        // GET: Asignaciones/Edit/5
        public IActionResult Edit(int id)
        {
            var asignacion = _context.Asignacion.Where(a => a.AsignacionID == id).Include(a => a.curso).Include(a => a.instructor).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Descripcion", asignacion.CursoID);
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad", asignacion.InstructorID);
            return PartialView("EditarAsignacion", asignacion);
        }


        [HttpPost]
        public IActionResult Edit(Asignacion asignacion)
        {
            if (ModelState.IsValid)
            {
                _context.Asignacion.Update(asignacion);
                _context.SaveChanges();
            }
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Descripcion", asignacion.CursoID);
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad", asignacion.InstructorID);
            return PartialView("EditarAsignacion", asignacion);
        }
        // GET: Asignaciones/Details/5
        public IActionResult Details(int id)
        {
            var asignacion = _context.Asignacion.Where(a => a.AsignacionID == id).Include(a => a.curso).Include(a => a.instructor.persona).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Descripcion", asignacion.CursoID);
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad", asignacion.InstructorID);
            return PartialView("verAsignacion", asignacion);
        }
        public IActionResult Delete(int id)
        {
            var asignacion = _context.Asignacion.Where(a => a.AsignacionID == id).Include(a => a.curso).Include(a => a.instructor.persona).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Curso, "CursoID", "Descripcion", asignacion.CursoID);
            ViewData["InstructorID"] = new SelectList(_context.Instructor, "ID", "Especialidad", asignacion.InstructorID);
            return PartialView("quitarAsignacion", asignacion);
        }

        // POST: Asignaciones/Delete/5
        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int id)
        {
            var asignacion = _context.Asignacion.Find(id);
            _context.Asignacion.Remove(asignacion);
            _context.SaveChanges();
            return PartialView("quitarAsignacion", asignacion);
        }

        private bool AsignacionExists(int id)
        {
            return _context.Asignacion.Any(e => e.AsignacionID == id);
        }
    }
}
