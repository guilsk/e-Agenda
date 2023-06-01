using e_Agenda.Compartilhado;

namespace e_Agenda.Modulo_Compromissos
{
    public class RepositorioCompromissoArquivo : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return ObterRegistros().Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros().Where(x => x.data > dataInicio).Where(x => x.data < dataFinal).ToList();
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
