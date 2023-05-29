namespace e_Agenda.ModuloTarefas
{
    public partial class TelaCadastroItensTarefaForm : Form
    {
        public TelaCadastroItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            tf_id.Text = tarefa.id.ToString();

            tf_titulo.Text = tarefa.titulo;

            list_Itens.Items.AddRange(tarefa.items.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = tf_titulo.Text;

            ItemTarefa itemTarefa = new ItemTarefa(titulo);

            list_Itens.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return list_Itens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}
