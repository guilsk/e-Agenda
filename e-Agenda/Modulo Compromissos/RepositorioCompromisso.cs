namespace e_Agenda.Modulo_Compromissos
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> compromissos)
        {
            listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime hoje)
        {
            return listaRegistros.Where(x => x.data.Date < hoje.Date).ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return listaRegistros.Where(x => x.data > dataInicio).Where(x => x.data < dataFinal).ToList();
        }
    }
}
