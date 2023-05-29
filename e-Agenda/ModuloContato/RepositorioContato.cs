namespace e_Agenda.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> contatos)
        {
            listaRegistros = contatos;
        }
    }
}
