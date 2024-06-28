using MediatR;
using GerenciadorTarefasEclipseWorks.Domain.Entities;

namespace GerenciadorTarefasEclipseWorks.Application.Commands
{
    public class CriarProjetoCommand : IRequest<int>
    {
        public string Nome { get; set; }
    }

    public class CriarTarefaCommand : IRequest<int>
    {
        public string Titulo { get; set; }
        public string Descricao {  get; set; }
        public string Prioridade {  get; set; }
    }
}
