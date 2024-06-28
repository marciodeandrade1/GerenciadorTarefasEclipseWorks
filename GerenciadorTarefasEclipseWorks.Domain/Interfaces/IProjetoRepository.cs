using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorTarefasEclipseWorks.Domain.Entities;

namespace GerenciadorTarefasEclipseWorks.Domain.Interfaces
{
    public interface IProjetoRepository
    {
        Task<List<Projeto>> GetAllProjetosAsync();
        Task<Projeto> GetProjetoByIdAsync(int id);
        Task AddProjetoAsync(Projeto projeto);
        Task RemoveProjetoAsync(int id);
    }
}
