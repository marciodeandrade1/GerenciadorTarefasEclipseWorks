using GerenciadorTarefasEclipseWorks.Application.Queries;
using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;
using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Handlers
{
    public class GetAllProjetosQueryHandler : IRequestHandler<GetAllProjetosQuery, List<Projeto>>
    {
        private readonly IProjetoRepository _projetoRepository;

        public GetAllProjetosQueryHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public async Task<List<Projeto>> Handle(GetAllProjetosQuery request, CancellationToken cancellationToken)
        {
            return await _projetoRepository.GetAllProjetosAsync();
        }
    }
}
