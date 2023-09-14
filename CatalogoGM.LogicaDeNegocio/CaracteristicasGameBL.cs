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
    public class CaracteristicasGameBL
    {
        public async Task<int> CrearAsync(CaracteristicasGame pCaracteristicasGame)
        {
            return await CaracterisricasGameDAL.CrearAsync(pCaracteristicasGame);
        }

        public async Task<int> ModificarAsync(CaracteristicasGame pCaracteristicasGame)
        {
            return await CaracterisricasGameDAL.ModificarAsync(pCaracteristicasGame);
        }

        public async Task<int> EliminarAsync(CaracteristicasGame pCaracteristicasGame)
        {
            return await CaracterisricasGameDAL.EliminarAsync(pCaracteristicasGame);
        }

        public async Task<CaracteristicasGame> ObtenerPorIdAsync(CaracteristicasGame pCaracteristicasGame)
        {
            return await CaracterisricasGameDAL.ObtenerPorIdAsync(pCaracteristicasGame);
        }

        public async Task<List<CaracteristicasGame>> ObtenerTodosAsync()
        {
            return await CaracterisricasGameDAL.ObtenerTodosAsync();
        }

        public async Task<List<CaracteristicasGame>> BuscarAsync(CaracteristicasGame pCaracteristicasGame)
        {
            return await CaracterisricasGameDAL.BuscarAsync(pCaracteristicasGame);
        }
    }
}
