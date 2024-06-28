using Microsoft.EntityFrameworkCore;
using GerenciadorTarefasEclipseWorks.Domain.Entities;


namespace GerenciadorTarefasEclipseWorks.Infrastructure.Data
{
    public class GerenciadorTarefasDbContext : DbContext
    {
        public GerenciadorTarefasDbContext(DbContextOptions<GerenciadorTarefasDbContext> options) : base(options) { }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TarefaComentario> TarefasComentarios { get; set; }
        public DbSet<TarefaAtualizaHistorico> TarefasAtualizaHistoricos { get; set; }

    }
}

