namespace e_Agenda.ModuloTarefas
{
    public partial class TelaAtualizacaoItensTarefaForm : Form
    {
        public TelaAtualizacaoItensTarefaForm(Tarefa tarefa)
        {
            this.ConfigurarDialog();

            ConfigurarTela(tarefa);
        }

        private void ConfigurarTela(Tarefa tarefa)
        {
            tf_id.Text = tarefa.id.ToString();

            tf_titulo.Text = tarefa.titulo;

            int i = 0;
            foreach (ItemTarefa item in tarefa.items)
            {
                list_itensTarefa.Items.Add(item);

                if (item.concluido) list_itensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return list_itensTarefa.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensPendentes()
        {
            return list_itensTarefa.Items.Cast<ItemTarefa>().Except(ObterItensMarcados()).ToList();
        }
    }
}
