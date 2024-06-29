using GerenciadorTarefasEclipseWorks.Application.Queries;
using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;
using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Handlers
{
    public class GetTarefasByProjetoIdQueryHandler : IRequestHandler<GetTarefasByProjetoIdQuery, List<Tarefa>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public GetTarefasByProjetoIdQueryHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<List<Tarefa>> Handle(GetTarefasByProjetoIdQuery request, CancellationToken cancellationToken)
        {
            return await _tarefaRepository.GetTarefasByProjetoIdAsync(request.ProjetoId);
        }
    }
}
