using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoForms.Models;

namespace ProjetoForms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateFormulario([FromBody] FormularioModel formulario)
        {
            throw new NotImplementedException();
        }
    }
}
