namespace e_Agenda.ModuloTarefas
{
    public class RepositorioTarefaEmArquivo : RepositorioArquivoBase<Tarefa>, IRepositorioTarefa
    {
        private const string NOME_ARQUIVO_TAREFAS = "Tarefas.bin";
        Tarefa tarefa = new Tarefa();

        public RepositorioTarefaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_TAREFAS))
                CarregarRegistrosDoArquivo(tarefa);
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return listaRegistros.Where(x => x.percentualConcluido == 100).ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaRegistros.Where(x => x.percentualConcluido < 100).ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaRegistros.OrderByDescending(x => x.prioridade).ToList();
        }

    }
}
