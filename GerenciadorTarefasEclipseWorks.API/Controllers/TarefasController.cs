using GerenciadorTarefasEclipseWorks.Application.Commands;
using GerenciadorTarefasEclipseWorks.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefasEclipseWorks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TarefasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{projetoId}")]
        public async Task<IActionResult> GetTarefaByProjetoId(int projetoId)
        {
            var tarefas = await _mediator.Send(new GetTarefasByProjetoIdQuery(projetoId));
            return Ok(tarefas);
        }

        [HttpPost]
        public async Task<IActionResult> CriarTarefa([FromBody] CriarTarefaCommand command)
        {
            var tarefaId = await _mediator.Send(command);
            return Ok(tarefaId);
        }
    }
}
