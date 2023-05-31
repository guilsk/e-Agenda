using System.Runtime.Serialization.Formatters.Binary;


namespace e_Agenda.Compartilhado
{
    public class RepositorioArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected int contadorRegistros = 0;
        protected List<TEntidade> listaRegistros = new List<TEntidade>();

        public void CarregarRegistrosDoArquivo(TEntidade registro)
        {
            string caminho = typeof(TEntidade).Name + ".bin";

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            MemoryStream registroStream = new MemoryStream(registrosEmBytes);

            listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        public void AtualizarContador()
        {
            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        public void GravarTarefasEmArquivo(TEntidade registro)
        {
            string caminho = typeof(TEntidade).Name + ".bin";

            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        public void Editar(int id, TEntidade registro)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registro);

            GravarTarefasEmArquivo(registro);
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            listaRegistros.Remove(registroSelecionado);

            GravarTarefasEmArquivo(registroSelecionado);
        }

        public void Inserir(TEntidade novoRegistro)
        {
            contadorRegistros++;
            novoRegistro.id = contadorRegistros;
            listaRegistros.Add(novoRegistro);

            GravarTarefasEmArquivo(novoRegistro);
        }

        public TEntidade SelecionarPorId(int id)
        {
            TEntidade registro = listaRegistros.FirstOrDefault(x => x.id == id);

            return registro;
        }

        public List<TEntidade> SelecionarTodos()
        {
            return listaRegistros;
        }

        
    
    }
}
