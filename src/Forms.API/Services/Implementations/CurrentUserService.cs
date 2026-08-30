using Forms.API.Enums;
using Forms.API.Services.Interfaces;
using System.Security.Claims;

namespace Forms.API.Services.Implementations
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public int GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext?
            .User
            .FindFirst(ClaimTypes.NameIdentifier)?
            .Value;

            if (userId == null)
                throw new UnauthorizedAccessException("Necessário realizar o login para continuar.");
            return int.Parse(userId!);
        }

        public PerfilUsuario GetCurrentUserPerfil()
        {
            var userRole = _httpContextAccessor.HttpContext?
                .User
                .FindFirst(ClaimTypes.Role)?
                .Value;

            if (userRole == null)
                throw new UnauthorizedAccessException("Necessário realizar o login para continuar.");

            return Enum.Parse<PerfilUsuario>(userRole);
        }
    }
}