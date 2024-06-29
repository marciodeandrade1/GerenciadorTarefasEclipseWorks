using GerenciadorTarefasEclipseWorks.Application.Commands;
using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;
using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Handlers
{
    public class CriarProjetoCommandHandler : IRequestHandler<CriarProjetoCommand, int>
    {
        private readonly IProjetoRepository _projetoRepository;

        public CriarProjetoCommandHandler(IProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public async Task<int> Handle(CriarProjetoCommand request, CancellationToken cancellationToken)
        {
            var projeto = new Projeto
            {
                Nome = request.Nome
            };

            await _projetoRepository.AddProjetoAsync(projeto);
            return projeto.Id;
        }
    }
}
