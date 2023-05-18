using e_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloTarefas
{
    public partial class ListagemTarefasControl : UserControl
    {
        List<Tarefa> tarefas = new();

        public ListagemTarefasControl()
        {
            InitializeComponent();
            tarefas.Add(new Tarefa(1, "Lavar o Cao", "alta"));
            tarefas.Add(new Tarefa(2, "Lavar o Carro", "baixa"));
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa item in tarefas)
            {
                listTarefas.Items.Add(item);
            }
        }

        public Tarefa ObterContatoSelecionado()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }
    }
}
