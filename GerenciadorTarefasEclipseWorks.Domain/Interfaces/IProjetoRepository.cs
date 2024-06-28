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
