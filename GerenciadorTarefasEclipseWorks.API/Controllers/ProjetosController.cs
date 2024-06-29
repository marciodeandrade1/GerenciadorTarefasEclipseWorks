using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using GerenciadorTarefasEclipseWorks.Application.Commands;
using GerenciadorTarefasEclipseWorks.Application.Queries;


namespace GerenciadorTarefasEclipseWorks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjetosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjetos()
        {
            var projetos = await _mediator.Send(new GetAllProjetosQuery());
            return Ok(projetos);
        }

        [HttpPost]
        public async Task<IActionResult> CriarProjeto([FromBody] CriarProjetoCommand command)
        {
            var projetoId = await _mediator.Send(command);
            return Ok(projetoId);
        }
    }
}
