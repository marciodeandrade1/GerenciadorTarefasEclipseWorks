using GerenciadorTarefasEclipseWorks.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorTarefasEclipseWorks.Application.Queries
{
    public class GetTarefasByProjetoIdQuery : IRequest<List<Tarefa>>
    {
        public int ProjetoId {  get; set; }
        public GetTarefasByProjetoIdQuery(int projetoId)
        {
            ProjetoId = projetoId;
        }
    }
    
}
