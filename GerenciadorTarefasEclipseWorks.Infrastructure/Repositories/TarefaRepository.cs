using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;
using GerenciadorTarefasEclipseWorks.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefasEclipseWorks.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly GerenciadorTarefasDbContext _context;

        public TarefaRepository(GerenciadorTarefasDbContext context)
        {
            _context = context;
        }

        public async Task AddTarefaAsync(Tarefa tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Tarefas
                .Include(t => t.Comentario)
                .Include(t => t.AtualizaHistoricos)
                .FirstOrDefaultAsync(t => t.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<List<Tarefa>> GetTarefasByProjetoIdAsync(int projetoId)
        {
            return await _context.Tarefas
                .Where(t => t.ProjetoId == projetoId)
                .ToListAsync();
        }

        public async Task RemoveTarefaAsync(int id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTarefaAsync(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }
    }
}
