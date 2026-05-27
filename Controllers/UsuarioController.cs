using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoForms.DTOs;
using ProjetoForms.Models;
using ProjetoForms.Services.Interfaces;

namespace ProjetoForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _UsuarioService;
        public UsuarioController(IUsuarioService usuarioService) 
        { 
            _UsuarioService = usuarioService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUsuario([FromBody] UsuarioDTO Usuario)
        {
            ResponseDTO response = await _UsuarioService.AddUsuario(Usuario);

            if (response.Status)
                return Ok(response);
            else
                return BadRequest(response);
        }

        [Authorize(Policy = "UserOnly")]
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            UsuarioModel user = await _UsuarioService.GetUsuarioById(id);

            return Ok(user);
        }

        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        public async Task<IActionResult> GetAllUsuarios()
        {
            IEnumerable<UsuarioModel> users = await _UsuarioService.GetAllUsuarios();

            return Ok(users);
        }

        [Authorize(Policy = "AdminOnly")]
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            ResponseDTO response = await _UsuarioService.DeleteUsuario(id);
           
            return Ok(response.Message);
        }

        [Authorize(Policy = "UserOnly")]
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUsuario([FromBody] UsuarioDTO Usuario, int id)
        {
            ResponseDTO response = await _UsuarioService.UpdateUsuario(Usuario, id);

            return Ok(response);
            
        }
    }
}
