namespace e_Agenda.Modulo_Compromissos
{
    public class RepositorioArquivoCompromisso : RepositorioArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        private const string NOME_ARQUIVO_CONTATOS = "Compromisso.bin";
        Compromisso compromisso = new Compromisso();

        public RepositorioArquivoCompromisso()
        {
            if (File.Exists(NOME_ARQUIVO_CONTATOS))
                CarregarRegistrosDoArquivo(compromisso);
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
