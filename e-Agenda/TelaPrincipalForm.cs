using e_Agenda.Compartilhado;
using e_Agenda.Modulo_Compromissos;
using e_Agenda.ModuloCompromisso;
using e_Agenda.ModuloContato;
using e_Agenda.ModuloTarefas;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new();
        private RepositorioCompromisso repositorioCompromisso = new();

        public TelaPrincipalForm()
        {
            InitializeComponent();
        }
        private void MenuItemContato_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void MenuItemCompromisso_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void MenuItemTarefas_Click(object sender, EventArgs e)
        {
            lb_tipoCadastro.Text = "Cadastro de Tarefas";

            bt_add.ToolTipText = "Inserir uma novo Tarefa";
            bt_edit.ToolTipText = "Editar uma Tarefa existente";
            bt_delete.ToolTipText = "Excluir uma Tarefa existente";

            ListagemTarefasControl listagemTarefas = new();

            listagemTarefas.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagemTarefas);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            lb_tipoCadastro.Text = controlador.ObterTipoCadastro();

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            bt_add.ToolTipText = controlador.ToolTipInserir;
            bt_edit.ToolTipText = controlador.ToolTipEditar;
            bt_delete.ToolTipText = controlador.ToolTipExcluir;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        
    }
}