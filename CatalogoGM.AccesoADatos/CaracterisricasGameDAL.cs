using CatalogoGM.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.AccesoADatos
{
    public class CaracterisricasGameDAL
    {
        public static async Task<int> CrearAsync(CaracteristicasGame pCaracteristicasGame)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                dbcontext.Add<CaracteristicasGame>(pCaracteristicasGame);
                result = await dbcontext.SaveChangesAsync();
            }
            return result;
        }

        // metodo asincrono para modificar datos
        public static async Task<int> ModificarAsync(CaracteristicasGame pCaracteristicasGame)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                var caracteristicagame = await dbcontext.CaracteristicasGames.FirstOrDefaultAsync(s => s.Id == pCaracteristicasGame.Id);
                caracteristicagame.TipoGenerosId = pCaracteristicasGame.TipoGenerosId;
                caracteristicagame.Titulo = pCaracteristicasGame.Titulo;
                caracteristicagame.Nombre = pCaracteristicasGame.Nombre;
                caracteristicagame.Img = pCaracteristicasGame.Img;
                caracteristicagame.Plataforma = pCaracteristicasGame.Plataforma;
                caracteristicagame.Genero = pCaracteristicasGame.Genero;
                caracteristicagame.Formato = pCaracteristicasGame.Formato;
                caracteristicagame.size = pCaracteristicasGame.size;
                caracteristicagame.Fecha = pCaracteristicasGame.Fecha;
                caracteristicagame.Version = pCaracteristicasGame.Version;
                caracteristicagame.TipoGenero = pCaracteristicasGame.TipoGenero;
                dbcontext.Update(caracteristicagame);
                result = await dbcontext.SaveChangesAsync();
            }
            return result;
        }
        // metodo asincrono para eliminar datos
        public static async Task<int> EliminarAsync(CaracteristicasGame pCaracteristicasGame)
        {
            int result = 0;
            using (var dbcontext = new ComunDB())
            {
                var caracteristicasGame = await dbcontext.CaracteristicasGames.FirstOrDefaultAsync(s => s.Id == pCaracteristicasGame.Id);
                dbcontext.CaracteristicasGames.Remove(caracteristicasGame);
                result = await dbcontext.SaveChangesAsync();
            }
            return result;
        }

        // metodo asincrono para obtener por id
        public static async Task<CaracteristicasGame> ObtenerPorIdAsync(CaracteristicasGame pCaracteristicasGame)
        {
            var caracteristicaGame = new CaracteristicasGame();
            using (var dbcontext = new ComunDB())
            {
                caracteristicaGame = await dbcontext.CaracteristicasGames.FirstOrDefaultAsync(s => s.Id.Equals(pCaracteristicasGame.Id));
            }
            return caracteristicaGame;
        }

        // metodo para obtener todo los datos de la tabla
        public static async Task<List<CaracteristicasGame>> ObtenerTodosAsync()
        {
            var caracteristicas = new List<CaracteristicasGame>();
            using (var dbcontext = new ComunDB())
            {
                caracteristicas = await dbcontext.CaracteristicasGames.ToListAsync();
            }
            return caracteristicas;
        }

        // Metodo para hacer busqueda segun los campos de la tabla
        internal static IQueryable<CaracteristicasGame> QuerySelect(IQueryable<CaracteristicasGame> pQuery, CaracteristicasGame pCaracteristicasGame)
        {
            if (pCaracteristicasGame.Id > 0)
                pQuery = pQuery.Where(s => s.Id == pCaracteristicasGame.Id);

            if (pCaracteristicasGame.TipoGenerosId > 0)
                pQuery = pQuery.Where(s => s.TipoGenerosId == pCaracteristicasGame.TipoGenerosId);

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Titulo))
                pQuery = pQuery.Where(s => s.Titulo.Contains(pCaracteristicasGame.Titulo));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Img))
                pQuery = pQuery.Where(s => s.Img.Contains(pCaracteristicasGame.Img));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Nombre))
                pQuery = pQuery.Where(s => s.Nombre.Contains(pCaracteristicasGame.Nombre));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Nombre))
                pQuery = pQuery.Where(s => s.Nombre.Contains(pCaracteristicasGame.Nombre));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Plataforma))
                pQuery = pQuery.Where(s => s.Plataforma.Contains(pCaracteristicasGame.Plataforma));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Genero))
                pQuery = pQuery.Where(s => s.Genero.Contains(pCaracteristicasGame.Genero));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Formato))
                pQuery = pQuery.Where(s => s.Formato.Contains(pCaracteristicasGame.Formato));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.size))
                pQuery = pQuery.Where(s => s.size.Contains(pCaracteristicasGame.size));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Fecha))
                pQuery = pQuery.Where(s => s.Fecha.Contains(pCaracteristicasGame.Fecha));

            if (!string.IsNullOrWhiteSpace(pCaracteristicasGame.Version))
                pQuery = pQuery.Where(s => s.Version.Contains(pCaracteristicasGame.Version));

            pQuery = pQuery.OrderByDescending(s => s.Id).AsQueryable();

            if (pCaracteristicasGame.Top_Aux > 0)
                pQuery = pQuery.Take(pCaracteristicasGame.Top_Aux).AsQueryable();

            return pQuery;
        }

        // metodo asincrono para traer por lista
        public static async Task<List<CaracteristicasGame>> BuscarAsync(CaracteristicasGame pCaracteristicaGame)
        {
            var caracteristicaGame = new List<CaracteristicasGame>();
            using (var bdContexto = new ComunDB())
            {
                var select = bdContexto.CaracteristicasGames.AsQueryable();
                select = QuerySelect(select, pCaracteristicaGame);
                caracteristicaGame = await select.ToListAsync();
            }
            return caracteristicaGame;
        }
    }
}