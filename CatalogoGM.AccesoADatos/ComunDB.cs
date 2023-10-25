using CatalogoGM.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoGM.AccesoADatos
{
    public class ComunDB : DbContext
    {
        public DbSet<Rol> Rol { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<TipoGenero> TipoGeneros { get; set; }

        public DbSet<CaracteristicasGame> CaracteristicasGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IRGNSJ4\SQLEXPRESS;Initial Catalog=ApiGame;Integrated Security=True; encrypt = false; trustServerCertificate = false");
        }
    }
}
