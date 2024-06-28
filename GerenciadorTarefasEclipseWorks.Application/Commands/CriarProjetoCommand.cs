using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Commands
{
    public record CriarProjetoCommand(string Nome) : IRequest<int>;
}
