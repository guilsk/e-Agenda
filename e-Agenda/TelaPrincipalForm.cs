using e_Agenda.Modulo_Compromissos;
using e_Agenda.ModuloCompromisso;
using e_Agenda.ModuloContato;
using e_Agenda.ModuloDespesas;
using e_Agenda.ModuloTarefas;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioContato repositorioContato = new RepositorioArquivoContato(contextoDados);
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoArquivo(contextoDados);
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo(contextoDados);

        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;

        }

        public void AtualizarRodape(string mensagem)
        {
            lb_rodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null) telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }


        private void MenuItemContato_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void MenuItemCompromisso_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioContato, repositorioCompromisso);

            ConfigurarTelaPrincipal(controlador);
        }

        private void MenuItemTarefas_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void MenuItemDespesas_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            lb_tipoCadastro.Text = controlador.ObterTipoCadastro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            barraFerramentas.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarEstados(controlador);
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
            bt_inserir.ToolTipText = controlador.ToolTipInserir;
            bt_editar.ToolTipText = controlador.ToolTipEditar;
            bt_excluir.ToolTipText = controlador.ToolTipExcluir;
            bt_filtrar.ToolTipText = controlador.ToolTipFiltrar;
            bt_adicionar_itens.ToolTipText = controlador.ToolTipAdicionarItens;
            bt_concluir_itens.ToolTipText = controlador.ToolTipConcluirItens;
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            bt_inserir.Enabled = controlador.InserirHabilitado;
            bt_editar.Enabled = controlador.EditarHabilitado;
            bt_excluir.Enabled = controlador.ExcluirHabilitado;
            bt_filtrar.Enabled = controlador.FiltrarHabilitado;
            bt_adicionar_itens.Enabled = controlador.AdicionarItensHabilitado;
            bt_concluir_itens.Enabled = controlador.ConcluirItensHabilitado;
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

        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            controlador.Filtrar();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void bt_concluir_itens_Click(object sender, EventArgs e)
        {
            controlador.ConcluirItens();
        }

        
    }
}