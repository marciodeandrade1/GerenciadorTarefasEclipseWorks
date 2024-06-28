namespace GerenciadorTarefasEclipseWorks.Domain.Entities
{
    public class TarefaComentario
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public DateTime CriadoEm {  get; set; }
        public int TarefaId { get; set; }
        public Tarefa Tarefa { get; set; }
    }
}
