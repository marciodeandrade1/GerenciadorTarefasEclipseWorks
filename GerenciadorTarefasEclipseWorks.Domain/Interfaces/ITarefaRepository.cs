﻿using GerenciadorTarefasEclipseWorks.Domain.Entities;

namespace GerenciadorTarefasEclipseWorks.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasByProjetoIdAsync(int projetoId);
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task AddTarefaAsync(Tarefa tarefa);
        Task UpdateTarefaAsync(Tarefa tarefa);
        Task RemoveTarefaAsync(int id);
    }
}
