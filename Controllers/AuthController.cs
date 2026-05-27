using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoForms.DTOs;
using ProjetoForms.Services.Interfaces;

namespace ProjetoForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            ResponseDTO response = await _authService.Login(loginDTO);

            if (response.Status == false)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
