namespace e_Agenda.ModuloContato
{
    public class RepositorioMemoriaContato : RepositorioMemoriaBase<Contato>
    {
        public RepositorioMemoriaContato(List<Contato> contatos)
        {
            listaRegistros = contatos;
        }
    }
}
