namespace e_Agenda.ModuloDespesas
{
    public class RepositorioCategoriaEmMemoria : RepositorioMemoriaBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmMemoria(List<Categoria> categorias)
        {
            this.listaRegistros = categorias;
        }
    }
}
