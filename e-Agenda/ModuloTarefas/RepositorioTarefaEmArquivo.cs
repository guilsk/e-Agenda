using e_Agenda.Compartilhado;

namespace e_Agenda.ModuloTarefas
{
    public class RepositorioTarefaEmArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return ObterRegistros().Where(x => x.percentualConcluido == 100).ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido < 100).ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros().OrderByDescending(x => x.prioridade).ToList();
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }
    }
}
