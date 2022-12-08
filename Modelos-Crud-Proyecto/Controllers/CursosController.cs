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
    public class CursosController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public CursosController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Cursos
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["NombreCurso"] = String.IsNullOrEmpty(ordenar) ? "nombreCurso_desc" : "";
            ViewData["DescripcionCurso"] = ordenar == "descripcionCurso_asc" ? "descripcionCurso_desc" : "descripcionCurso_asc";
            ViewData["NombreCategoria"] = ordenar == "nombreCat_asc" ? "nombreCat_desc" : "nombreCat_asc";
            ViewData["HorasCurso"] = ordenar == "horas_asc" ? "horas_desc" : "horas_asc";
            ViewData["CreditoCurso"] = ordenar == "credito_asc" ? "credito_desc" : "credito_asc";

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

            var cursos = from s in _context.Curso.Include(c => c.categoria) select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                cursos = cursos.Where(s => s.Nombre.Contains(buscarTexto) || s.Descripcion.Contains(buscarTexto) || s.categoria.Nombre.Contains(buscarTexto));
            }

            switch (ordenar)
            {
                case "nombreCurso_desc":
                    cursos = cursos.OrderByDescending(s => s.Nombre);
                    break;
                case "descripcionCurso_desc":
                    cursos = cursos.OrderByDescending(s => s.Descripcion);
                    break;
                case "descripcionCurso_asc":
                    cursos = cursos.OrderBy(s => s.Descripcion);
                    break;
                case "nombreCat_desc":
                    cursos = cursos.OrderByDescending(s => s.categoria.Nombre);
                    break;
                case "nombreCat_asc":
                    cursos = cursos.OrderBy(s => s.categoria.Nombre);
                    break;
                case "horas_desc":
                    cursos = cursos.OrderByDescending(s => s.Horas);
                    break;
                case "horas_asc":
                    cursos = cursos.OrderBy(s => s.Horas);
                    break;
                case "credito_desc":
                    cursos = cursos.OrderByDescending(s => s.Creditos);
                    break;
                case "credito_asc":
                    cursos = cursos.OrderBy(s => s.Creditos);
                    break;
                default:
                    cursos = cursos.OrderBy(s => s.Nombre);
                    break;
            }
            //var proyecto_ModelosCRUDContext = _context.Curso.Include(c => c.categoria);
            //return View(await proyecto_ModelosCRUDContext.ToListAsync());
            int tamanioPag = 3;
            return View(await Paginacion<Curso>.CrearAsync(cursos.AsNoTracking(), pag ?? 1, tamanioPag));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre");
            return PartialView("nuevoCurso");
        }
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _context.Curso.Add(curso);
                _context.SaveChanges();
            }
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre", curso.CategoriaID);
            return PartialView("nuevoCurso", curso);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var curso = _context.Curso.Where(c => c.CursoID == id).Include(c => c.categoria).FirstOrDefault();
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre", curso.CategoriaID);
            return PartialView("EditarCurso", curso);
        }


        [HttpPost]
        public IActionResult Edit(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _context.Curso.Update(curso);
                _context.SaveChanges();
            }
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre", curso.CategoriaID);
            return PartialView("EditarCurso", curso);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var curso = _context.Curso.Where(c => c.CursoID == id).Include(c => c.categoria).FirstOrDefault();
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre", curso.CategoriaID);
            return PartialView("verCurso", curso);
        }

        // GET: Cursos/Delete/5
        public IActionResult Delete(int id)
        {
            var curso = _context.Curso.Where(c => c.CursoID == id).Include(c => c.categoria).FirstOrDefault();
            ViewData["CategoriaID"] = new SelectList(_context.Set<Categoria>(), "CategoriaID", "Nombre", curso.CategoriaID);
            return PartialView("QuitarCurso", curso);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var curso = _context.Curso.Find(id);
            _context.Remove(curso);
            _context.SaveChanges();
            return PartialView("QuitarCurso", curso);
        }

        private bool CursoExists(int id)
        {
            return _context.Curso.Any(e => e.CursoID == id);
        }
    }
}
