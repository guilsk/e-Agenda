namespace e_Agenda.ModuloTarefas
{
    public partial class TelaTarefaForm : Form
    {
        public TelaTarefaForm(bool edicaoDeTarefa)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();

            if (edicaoDeTarefa) dtp_dataCriacao.Enabled = false;
        }

        private void CarregarPrioridades()
        {
            PrioridadeTarefaEnum[] prioridades = Enum.GetValues<PrioridadeTarefaEnum>();

            foreach (PrioridadeTarefaEnum prioridade in prioridades) cmb_prioridade.Items.Add(prioridade);
        }

        public Tarefa ObterTarefa()
        {
            int id = Convert.ToInt32(tf_id.Text);

            string titulo = tf_titulo.Text;

            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmb_prioridade.SelectedItem;

            DateTime dataCriacao = dtp_dataCriacao.Value;

            return new Tarefa(id, titulo, prioridade, dataCriacao);
        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            tf_id.Text = tarefaSelecionada.id.ToString();

            tf_titulo.Text = tarefaSelecionada.titulo;

            cmb_prioridade.SelectedItem = tarefaSelecionada.prioridade;

            dtp_dataCriacao.Value = tarefaSelecionada.dataCriacao;
        }
    }
}
