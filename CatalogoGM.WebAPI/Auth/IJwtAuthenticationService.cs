using CatalogoGM.EntidadesDeNegocio;

namespace CatalogoGM.WebAPI.Auth
{
    public interface IJwtAuthenticationService
    {
            string Authenticate(Usuario pUsuario);
    }
}
