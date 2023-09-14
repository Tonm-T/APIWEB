using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogoGM.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoGM.EntidadesDeNegocio;
using System.Net.Http.Headers;

namespace CatalogoGM.AccesoADatos.Tests
{
    [TestClass()]
    public class TipoGeneroDALTests
    {
        private static TipoGenero tipogeneroInicial = new TipoGenero { Id = 2 };

        [TestMethod()]
        public async Task T1CrearAsyncTest()
        {
            var tipogenero = new TipoGenero();
            tipogenero.Tipo = "Accion";
            int result = await TipoGeneroDAL.CrearAsync(tipogenero);
            Assert.AreEqual(0, result);
            tipogeneroInicial.Id = tipogenero.Id;
        }

        [TestMethod()]
        public async Task T2ModificarAsyncTest()
        {
            var tipogenero = new TipoGenero();
            tipogenero.Id = tipogeneroInicial.Id;
            tipogenero.Tipo = "Accion";
            int result = await TipoGeneroDAL.ModificarAsync(tipogenero);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public async Task T3ObtenerPorIdAsyncTest()
        {
            var tipogenero = new TipoGenero();
            tipogenero.Id = tipogeneroInicial.Id;
            var resultTipogenero = await TipoGeneroDAL.ObtenerPorIdAsync(tipogenero);
            Assert.AreEqual(tipogenero.Id, resultTipogenero.Id);
        }

        [TestMethod()]
        public async Task T4ObtenerTodosAsyncTest()
        {
            var resultTipogeneros = await TipoGeneroDAL.ObtenerTodosAsync();
            Assert.AreEqual(0,resultTipogeneros.Count);
        }

        [TestMethod()]
        public async Task T5BuscarAsyncTest()
        {
            var tipogenero = new TipoGenero();
            tipogenero.Tipo = "a";
            tipogenero.top_aux = 10;
            var resultTipogenero = await TipoGeneroDAL.BuscarAsync(tipogenero);
            Assert.AreEqual(0, resultTipogenero.Count);
        }

        [TestMethod()]
        public async Task T6EliminarAsyncTest()
        {
            var tipogenero = new TipoGenero();
            tipogenero.Id = tipogeneroInicial.Id;
            int result = await TipoGeneroDAL.EliminarAsync(tipogenero);
            Assert.AreEqual(0, result);
        }
    }
}