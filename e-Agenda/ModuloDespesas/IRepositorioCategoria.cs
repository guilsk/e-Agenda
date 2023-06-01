
namespace e_Agenda.ModuloDespesas
{
    public interface IRepositorioCategoria
    {
        void Editar(int id, Categoria categoriaAtualizada);
        void Excluir(Categoria categoria);
        void Inserir(Categoria novaCategoria);
        Categoria SelecionarPorId(int id);
        List<Categoria> SelecionarTodos();
    }
}
