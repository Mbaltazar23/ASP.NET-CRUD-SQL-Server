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
    public class InscripcionesController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public InscripcionesController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Inscripciones
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["GradoInscripcion"] = String.IsNullOrEmpty(ordenar) ? "gradoIns_desc" : "";
            ViewData["CursoNombre"] = ordenar == "nombreCurso_asc" ? "nombreCurso_desc" : "nombreCurso_asc"; ;
            ViewData["EstudianteInscrito"] = ordenar == "estudianteIns_asc" ? "estudianteIns_desc" : "estudianteIns_asc";

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

            var inscripciones = from s in _context.Inscripcion.Include(i => i.curso).Include(i => i.estudiante) select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                inscripciones = inscripciones.Where(s => s.curso.Nombre.Contains(buscarTexto) || s.estudiante.Codigo.Contains(buscarTexto) || s.Pago.ToString().Contains(buscarTexto));
            }

            switch (ordenar)
            {
                case "gradoIns_desc":
                    inscripciones = inscripciones.OrderByDescending(s => s.Grado);
                    break;
                case "nombreCurso_desc":
                    inscripciones = inscripciones.OrderByDescending(s => s.curso.Nombre);
                    break;
                case "nombreCurso_asc":
                    inscripciones = inscripciones.OrderBy(s => s.curso.Nombre);
                    break;
                case "estudianteIns_desc":
                    inscripciones = inscripciones.OrderByDescending(s => s.estudiante.Codigo);
                    break;
                case "estudianteIns_asc":
                    inscripciones = inscripciones.OrderBy(s => s.estudiante.Codigo);
                    break;
                default:
                    inscripciones = inscripciones.OrderBy(s => s.Grado);
                    break;
            }
            //var modelos_Crud_ProyectoContext = _context.Inscripcion.Include(i => i.curso).Include(i => i.estudiante);
            //return View(await modelos_Crud_ProyectoContext.ToListAsync());
            int tamanioPage = 3;
            return View(await Paginacion<Inscripcion>.CrearAsync(inscripciones.AsNoTracking(), pag ?? 1, tamanioPage));
        }


        public IActionResult Create()
        {
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre");
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo");
            Inscripcion inscripcion = new Inscripcion();
            return PartialView("nuevaInscripcion", inscripcion);
        }

        [HttpPost]

        public IActionResult Create(Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Inscripcion.Add(inscripcion);
                _context.SaveChanges();
            }
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre", inscripcion.CursoID);
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo", inscripcion.EstudianteID);
            return PartialView("nuevaInscripcion", inscripcion);
        }

        // GET: Inscripciones/Edit/5
        public IActionResult Edit(int id)
        {
            var inscripcion = _context.Inscripcion.Where(i => i.InscripcionID == id).Include(i => i.estudiante).Include(i => i.curso).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre", inscripcion.CursoID);
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo", inscripcion.EstudianteID);
            return PartialView("editarInscripcion", inscripcion);
        }

        [HttpPost]

        public IActionResult Edit(Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Inscripcion.Update(inscripcion);
                _context.SaveChanges();
            }
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre", inscripcion.CursoID);
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo", inscripcion.EstudianteID);
            return PartialView("editarInscripcion", inscripcion);
        }


        public IActionResult Details(int id)
        {
            var inscripcion = _context.Inscripcion.Where(i => i.InscripcionID == id).Include(i => i.estudiante.persona).Include(i => i.curso).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre", inscripcion.CursoID);
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo", inscripcion.EstudianteID);
            return PartialView("verInscripcion", inscripcion);
        }
        public IActionResult Delete(int id)
        {
            var inscripcion = _context.Inscripcion.Where(i => i.InscripcionID == id).Include(i => i.estudiante.persona).Include(i => i.curso).FirstOrDefault();
            ViewData["CursoID"] = new SelectList(_context.Set<Curso>(), "CursoID", "Nombre", inscripcion.CursoID);
            ViewData["EstudianteID"] = new SelectList(_context.Set<Estudiante>(), "ID", "Codigo", inscripcion.EstudianteID);
            return PartialView("quitarInscripcion", inscripcion);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var inscripcion = _context.Inscripcion.Find(id);
            _context.Inscripcion.Remove(inscripcion);
            _context.SaveChanges();
            return PartialView("quitarInscripcion", inscripcion);
        }

        private bool InscripcionExists(int id)
        {
            return _context.Inscripcion.Any(e => e.InscripcionID == id);
        }
    }
}
