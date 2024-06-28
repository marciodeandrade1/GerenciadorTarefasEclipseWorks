using Microsoft.EntityFrameworkCore;
using GerenciadorTarefasEclipseWorks.Domain.Entities;
using GerenciadorTarefasEclipseWorks.Domain.Interfaces;

namespace GerenciadorTarefasEclipseWorks.Infrastructure.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly GerenciadorTarefasDbContext _context;
        public ProjetoRepository(GerenciadorTarefasDbContext context)
        {
            _context = context;
        }

        public async Task AddProjetoAsync(Projeto projeto)
        {
            await _context.Projetos.AddAsync(projeto);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Projeto>> GetAllProjetosAsync()
        {
            return await _context.Projetos.ToListAsync();
        }

        public async Task<Projeto> GetProjetoByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Projetos
                                 .Include(p => p.Tarefas)
                                 .FirstOrDefaultAsync(p => p.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task RemoveProjetoAsync(int id)
        {
            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto != null)
            {
                _context.Projetos.Remove(projeto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
