using Forms.API.Enums;

namespace Forms.API.Services.Interfaces
{
    public interface ICurrentUserService
    {
        int GetCurrentUserId();
        PerfilUsuario GetCurrentUserPerfil();
    }
}