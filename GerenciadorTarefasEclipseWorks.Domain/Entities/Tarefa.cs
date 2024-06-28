namespace GerenciadorTarefasEclipseWorks.Domain.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set;}
        public string Prioridade {  get; set; }
        public bool Completa {  get; set; }
        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }

        public List<TarefaComentario> Comentario { get; set; }
        public List<TarefaAtualizaHistorico> AtualizaHistoricos { get; set; }
    }
}
