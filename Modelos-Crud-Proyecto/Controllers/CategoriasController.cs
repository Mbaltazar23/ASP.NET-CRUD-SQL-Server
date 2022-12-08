using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelos_Crud_Proyecto.Data;
using Modelos_Crud_Proyecto.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos_Crud_Proyecto.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly Modelos_Crud_ProyectoContext _context;

        public CategoriasController(Modelos_Crud_ProyectoContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index(string ordenar, string filtrar, string buscarTexto, int? pag)
        {
            ViewData["NombreSortParam"] = String.IsNullOrEmpty(ordenar) ? "nombre_desc" : "";
            ViewData["DescripcionSortParam"] = ordenar == "descripcion_asc" ? "descripcion_desc" : "descripcion_asc";
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

            var categorias = from s in _context.Categoria select s;

            if (!String.IsNullOrEmpty(buscarTexto))
            {
                categorias = categorias.Where(s => s.Nombre.Contains(buscarTexto) || s.Descripcion.Contains(buscarTexto));
            }

            switch (ordenar)
            {
                case "nombre_desc":
                    categorias = categorias.OrderByDescending(s => s.Nombre);
                    break;
                case "descripcion_desc":
                    categorias = categorias.OrderByDescending(s => s.Descripcion);
                    break;
                case "descripcion_asc":
                    categorias = categorias.OrderBy(s => s.Descripcion);
                    break;
                default:
                    categorias = categorias.OrderBy(s => s.Nombre);
                    break;
            }
            //return View(await categorias.AsNoTracking().ToListAsync());
            //return View(await _context.Categoria.ToListAsync());
            int tamanioPag = 3;
            return View(await Paginacion<Categoria>.CrearAsync(categorias.AsNoTracking(), pag ?? 1, tamanioPag));
        }


        [HttpGet]
        public IActionResult Create()
        {
            Categoria cat = new Categoria();
            return PartialView("_NuevaCategoria", cat);
        }

        [HttpPost]
        public IActionResult Create(Categoria cat)
        {
            if (ModelState.IsValid)
            {
                _context.Categoria.Add(cat);
                _context.SaveChanges();
            }
            return PartialView("_NuevaCategoria", cat);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categorias = _context.Categoria.Where(c => c.CategoriaID == id).FirstOrDefault();
            return PartialView("_EditarCategoria", categorias);
        }

        [HttpPost]
        public IActionResult Edit(Categoria cat)
        {
            if (ModelState.IsValid)
            {
                _context.Categoria.Update(cat);
                _context.SaveChanges();
            }
            return PartialView("_EditarCategoria", cat);
        }

        public IActionResult Details(int id)
        {
            var categorias = _context.Categoria.Where(c => c.CategoriaID == id).FirstOrDefault();
            return PartialView("_VerCategoria", categorias);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categorias = _context.Categoria.Where(c => c.CategoriaID == id).FirstOrDefault();
            return PartialView("_EliminarCategoria", categorias);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cat = _context.Categoria.Find(id);
            _context.Categoria.Remove(cat);
            _context.SaveChanges();
            return PartialView("_EliminarCategoria", cat);
        }


        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.CategoriaID == id);
        }
    }
}
