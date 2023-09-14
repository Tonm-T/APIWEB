using CatalogoGM.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.AccesoADatos
{
    public class TipoGeneroDAL
    {
        public static async Task<int> CrearAsync(TipoGenero pTipoGenero)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                try
                {
                    dbcontext.TipoGeneros.Add(pTipoGenero);
                    result = await dbcontext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return result;
        }
        public static async Task<int> ModificarAsync(TipoGenero pTipoGenero)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                var tipogenero = await dbcontext.TipoGeneros.FirstOrDefaultAsync(s => s.Id == pTipoGenero.Id);
                tipogenero.Tipo = pTipoGenero.Tipo;
                dbcontext.Update(tipogenero);
                result = await dbcontext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> EliminarAsync(TipoGenero pTipoGenero)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                var tipogenero = await dbcontext.TipoGeneros.FirstOrDefaultAsync(s => s.Id == pTipoGenero.Id);
                dbcontext.TipoGeneros.Remove(pTipoGenero);
                result = await dbcontext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<TipoGenero> ObtenerPorIdAsync(TipoGenero pTipoGenero)
        {
            var tipogenero = new TipoGenero();
            using (var dbcontext = new ComunDB())
            {
                tipogenero = await dbcontext.TipoGeneros.FirstOrDefaultAsync(s => s.Id.Equals(pTipoGenero.Id));
            }
            return tipogenero;
        }
        public static async Task<List<TipoGenero>> ObtenerTodosAsync()
        {
            var tipogeneros = new List<TipoGenero>();
            using (var dbcontext = new ComunDB())
            {
                tipogeneros = await dbcontext.TipoGeneros.ToListAsync();
            }
            return tipogeneros;
        }
        internal static IQueryable<TipoGenero> QuerySelect(IQueryable<TipoGenero> pQuery, TipoGenero pTipoGenero)
        {
            if (pTipoGenero.Id > 0)
                pQuery = pQuery.Where(s => s.Id == pTipoGenero.Id);

            if (!string.IsNullOrWhiteSpace(pTipoGenero.Tipo))
                pQuery = pQuery.Where(s => s.Tipo.Contains(pTipoGenero.Tipo));

            pQuery = pQuery.OrderByDescending(s => s.Id).AsQueryable();

            if (pTipoGenero.top_aux > 0)
                pQuery = pQuery.Take(pTipoGenero.top_aux).AsQueryable();

            return pQuery;
        }
        public static async Task<List<TipoGenero>> BuscarAsync(TipoGenero pTipoGenero)
        {
            var tipogenero = new List<TipoGenero>();
            using (var bdContexto = new ComunDB())
            {
                var select = bdContexto.TipoGeneros.AsQueryable();
                select = QuerySelect(select, pTipoGenero);
                tipogenero = await select.ToListAsync();
            }
            return tipogenero;
        }
    }
}