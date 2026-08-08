using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoForms.DTOs;
using ProjetoForms.Models;
using ProjetoForms.Services.Interfaces;

namespace ProjetoForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        private readonly IFormularioService _FormularioService;

        public FormularioController(IFormularioService formularioService)
        {
            _FormularioService = formularioService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateFormulario([FromBody] FormularioDTO formulario)
        {
            await _FormularioService.AddFormulario(formulario);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetFormulario(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IEnumerable<UsuarioModel>> GetAllFormularios()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteFormulario(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateFormulario([FromBody] FormularioModel formulario)
        {
            throw new NotImplementedException();
        }
    }
}
