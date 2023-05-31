namespace e_Agenda.ModuloContato
{
    public class RepositorioArquivoContato : RepositorioArquivoBase<Contato>, IRepositorioContato
    {
        private const string NOME_ARQUIVO_CONTATOS = "Contato.bin";
        Contato contato = new Contato();

        public RepositorioArquivoContato()
        {
            if (File.Exists(NOME_ARQUIVO_CONTATOS))
                CarregarRegistrosDoArquivo(contato);
        }
    }
}