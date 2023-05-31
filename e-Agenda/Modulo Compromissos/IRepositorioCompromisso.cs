namespace e_Agenda.Modulo_Compromissos
{
    public interface IRepositorioCompromisso
    {
        void Inserir(Compromisso novoCompromisso);
        void Editar(int id, Compromisso compromisso);
        void Excluir(Compromisso compromissoSelecionado);
        List<Compromisso> SelecionarCompromissosPassados(DateTime hoje);
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
        Compromisso SelecionarPorId(int id);
        List<Compromisso> SelecionarTodos();
    }
}
