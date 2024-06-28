namespace GerenciadorTarefasEclipseWorks.Domain.Entities
{
    public class TarefaAtualizaHistorico
    {
        public int Id { get; set; }
        public string AtualizaDescricao { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public int TarefaId { get; set; }
        public Tarefa Tarefa { get; set; }
    }
}
