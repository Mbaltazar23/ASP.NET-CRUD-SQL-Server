using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelos_Crud_Proyecto
{
    public class Paginacion<T> : List<T>
    {
        public int Indice { get; private set; }
        public int TotalP { get; private set; }

        public int TotalR { get; private set; }

        public Paginacion(List<T> items, int cont, int indice, int tamanioPage)
        {
            Indice = indice;
            TotalP = (int)Math.Ceiling(cont / (double)tamanioPage);
            TotalR = cont;
            this.AddRange(items);
        }

        public bool PreviaPag
        {
            get { return Indice > 1; }
        }

        public bool SiguientePag
        {
            get
            {
                return Indice < TotalP;
            }
        }

        public static async Task<Paginacion<T>> CrearAsync(IQueryable<T> recurso, int indice, int tamanioPag)
        {
            var cont = await recurso.CountAsync();
            var items = await recurso.Skip((indice - 1) * tamanioPag).Take(tamanioPag).ToListAsync();
            return new Paginacion<T>(items, cont, indice, tamanioPag);
        }

    }
}
