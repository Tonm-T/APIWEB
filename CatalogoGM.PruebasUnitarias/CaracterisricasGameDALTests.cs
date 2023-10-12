using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogoGM.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoGM.EntidadesDeNegocio;

namespace CatalogoGM.AccesoADatos.Tests
{
    [TestClass()]
    public class CaracterisricasGameDALTests
    {
        private static CaracteristicasGame caracteristicaInicial = new CaracteristicasGame { Id = 2, TipoGenerosId = 2};

        [TestMethod()]
        public async Task T1CrearAsyncTest()
        {
            var caracteristica = new CaracteristicasGame();
            caracteristicaInicial.TipoGenerosId = caracteristicaInicial.TipoGenerosId;
            caracteristicaInicial.Titulo = "Guerra";
            caracteristicaInicial.Img = "img";
            caracteristicaInicial.Nombre = "Call of Duty";
            caracteristicaInicial.Plataforma = "Utorrent";
            caracteristicaInicial.Genero = "Accion";
            caracteristicaInicial.Formato = "ISO";
            caracteristicaInicial.size = "40";
            caracteristicaInicial.Version = "1.5.01";
            int result = await CaracterisricasGameDAL.CrearAsync(caracteristicaInicial);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public async Task T2ModificarAsyncTest()
        {
            var caracteristica = new CaracteristicasGame();
            caracteristicaInicial.TipoGenerosId = caracteristicaInicial.TipoGenerosId;
            caracteristicaInicial.Titulo = "Guerra";
            caracteristicaInicial.Img = "img";
            caracteristicaInicial.Nombre = "Call of Duty";
            caracteristicaInicial.Plataforma = "Utorrent";
            caracteristicaInicial.Genero = "Accion";
            caracteristicaInicial.Formato = "ISO";
            caracteristicaInicial.size = "40";
            caracteristicaInicial.Version = "1.5.01";
            int result = await CaracterisricasGameDAL.ModificarAsync(caracteristicaInicial);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public async Task T3ObtenerPorIdAsyncTest()
        {
            var caracteristica = new CaracteristicasGame();
            caracteristica.Id = caracteristicaInicial.Id;
            var resultCaracteristica = await CaracterisricasGameDAL.ObtenerPorIdAsync(caracteristica);
            Assert.AreEqual(caracteristica.Id, resultCaracteristica.Id);
        }

        [TestMethod()]
        public async Task T4ObtenerTodosAsyncTest()
        {
            var resultCaracteristicas = await CaracterisricasGameDAL.ObtenerTodosAsync();
            Assert.AreEqual(0, resultCaracteristicas.Count);
        }

        [TestMethod()]
        public async Task T5BuscarAsyncTest()
        {
            var caracteristica = new CaracteristicasGame();
            caracteristicaInicial.Titulo = "Guerra";
            caracteristicaInicial.Img = "img";
            caracteristicaInicial.Nombre = "Call of Duty";
            caracteristicaInicial.Plataforma = "Utorrent";
            caracteristicaInicial.Genero = "Accion";
            caracteristicaInicial.Formato = "ISO";
            caracteristicaInicial.size = "40";
            caracteristicaInicial.Version = "1.5.01";
            var resultCaracteristica = await CaracterisricasGameDAL.BuscarAsync(caracteristicaInicial);
            Assert.AreEqual(0, resultCaracteristica?.Count);
         }

        [TestMethod()]
        public async Task T6EliminarAsyncTest()
        {
            var caracteristica = new CaracteristicasGame();
            caracteristica.Id = caracteristicaInicial.Id;
            int result = await CaracterisricasGameDAL.EliminarAsync(caracteristica);
            Assert.AreEqual(0, result);
        }
    }
}