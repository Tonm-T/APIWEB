﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------
using CatalogoGM.AccesoADatos;
using CatalogoGM.EntidadesDeNegocio;

namespace CatalogoGM.LogicaDeNegocio
{
    public class UsuarioBL
    {

        public async Task<int> CrearAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.CrearAsync(pUsuario);
        }

        public async Task<int> ModificarAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.ModificarAsync(pUsuario);
        }

        public async Task<int> EliminarAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.EliminarAsync(pUsuario);
        }

        public async Task<Usuario> ObtenerPorIdAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.ObtenerPorIdAsync(pUsuario);
        }

        public async Task<Usuario> LoginAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.LoginAsync(pUsuario);
        }

        public async Task<List<Usuario>> ObtenerTodosAsync()
        {
            return await UsuarioDAL.ObtenerTodosAsync();
        }

        public async Task<List<Usuario>> BuscarIncluirRolesAsync(Usuario pUsuario)
        {
            return await UsuarioDAL.BuscarIncluirRolesAsync(pUsuario);
        }

        public async Task<int> CambiarPasswordAsync(Usuario pUsuario, string pClaveAnterior)
        {
            return await UsuarioDAL.CambiarPasswordAsync(pUsuario, pClaveAnterior);
        }
    }
}
