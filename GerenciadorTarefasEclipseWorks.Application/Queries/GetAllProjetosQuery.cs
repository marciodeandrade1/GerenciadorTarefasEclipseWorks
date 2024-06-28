using GerenciadorTarefasEclipseWorks.Domain.Entities;
using MediatR;

namespace GerenciadorTarefasEclipseWorks.Application.Queries
{
    public class GetAllProjetosQuery : IRequest<List<Projeto>>
    {
    }
}
