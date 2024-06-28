using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Commands
{
    public record CriarTarefaCommand(string Titulo, string Descricao, string Prioridade, int ProjetcId) : IRequest<int>;
}
