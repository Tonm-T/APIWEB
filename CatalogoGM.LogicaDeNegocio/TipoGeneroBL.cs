using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------
using CatalogoGM.AccesoADatos;
using CatalogoGM.EntidadesDeNegocio;

namespace CatalogoGM.LogicaDeNegocio
{
    public class TipoGeneroBL
    {
        public async Task<int> CrearAsync(TipoGenero pTipoGenero)
        {
            return await TipoGeneroDAL.CrearAsync(pTipoGenero);
        }

        public async Task<int> ModificarAsync(TipoGenero pTipoGenero)
        {
            return await TipoGeneroDAL.ModificarAsync(pTipoGenero);
        }

        public async Task<int> EliminarAsync(TipoGenero pTipoGenero)
        {
            return await TipoGeneroDAL.EliminarAsync(pTipoGenero);
        }

        public async Task<TipoGenero> ObtenerPorIdAsync(TipoGenero pTipoGenero)
        {
            return await TipoGeneroDAL.ObtenerPorIdAsync(pTipoGenero);
        }

        public async Task<List<TipoGenero>> ObtenerTodosAsync()
        {
            return await TipoGeneroDAL.ObtenerTodosAsync();
        }

        public async Task<List<TipoGenero>> BuscarAsync(TipoGenero pTipoGenero)
        {
            return await TipoGeneroDAL.BuscarAsync(pTipoGenero);
        }
    }
}
