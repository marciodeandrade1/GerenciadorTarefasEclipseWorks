using GerenciadorTarefasEclipseWorks.Application.Commands;
using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;
using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Handlers
{
    public class CriarTaretaCommandHandler : IRequestHandler<CriarTarefaCommand, int>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public CriarTaretaCommandHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<int> Handle(CriarTarefaCommand request, CancellationToken cancellationToken)
        {
            var tarefa = new Tarefa
            {
                Titulo = request.Titulo,
                Descricao = request.Descricao,
                Prioridade = request.Prioridade,
                ProjetoId = request.ProjetcId
            };

            await _tarefaRepository.AddTarefaAsync(tarefa);
            return tarefa.Id;
        }
    }

}
