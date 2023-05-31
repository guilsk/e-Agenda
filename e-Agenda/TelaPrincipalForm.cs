using e_Agenda.Modulo_Compromissos;
using e_Agenda.ModuloCompromisso;
using e_Agenda.ModuloContato;
using e_Agenda.ModuloTarefas;

namespace e_Agenda
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;

        private IRepositorioContato repositorioContato = new RepositorioArquivoContato();
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioArquivoCompromisso();

        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo();

        private static TelaPrincipalForm telaPrincipal;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;

            PopularRepositorios();
        }

        private void PopularRepositorios()
        {
            Contato caio = new Contato("Caio Henrique Garcia Valle", "caio@gmail.com", "(99) 99999-9999", "Dev", "CEDUP");

            Contato camile = new Contato("Camile Coelho Arruda", "camile@gmail.com", "(99) 99999-9999", "Dev", "IFSC");

            Contato davi = new Contato("Davi William Silva", "davi@gmail.com", "(99) 99999-9999", "Dev", "UNIPLAC");

            Contato diego = new Contato("Diego Oliveira", "diego@gmail.com", "(99) 99999-9999", "Dev", "UNIPLAC");

            Contato eduardo = new Contato("Eduardo Moreira de Jesus", "eduardo@gmail.com", "(99) 99999-9999", "Dev", "IFSC");

            repositorioContato.Inserir(caio);
            repositorioContato.Inserir(camile);
            repositorioContato.Inserir(davi);
            repositorioContato.Inserir(diego);
            repositorioContato.Inserir(eduardo);

            Compromisso c01 = new Compromisso("Entrevista - Caio Henrique", new DateTime(2023, 5, 21), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), caio, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c02 = new Compromisso("Entrevista - Camile", new DateTime(2023, 5, 22), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), camile, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c03 = new Compromisso("Entrevista - Davi", new DateTime(2023, 5, 23), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), davi, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c04 = new Compromisso("Entrevista - Diego", new DateTime(2023, 5, 24), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), diego, "Midilages", TipoLocalEnum.Presencial);
            Compromisso c05 = new Compromisso("Entrevista - Eduardo", new DateTime(2023, 5, 25), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0), eduardo, "Midilages", TipoLocalEnum.Presencial);

            repositorioCompromisso.Inserir(c01);
            repositorioCompromisso.Inserir(c02);
            repositorioCompromisso.Inserir(c03);
            repositorioCompromisso.Inserir(c04);
            repositorioCompromisso.Inserir(c05);

            Tarefa t1 = new Tarefa(1, "Preparar Apresentação 1", PrioridadeTarefaEnum.Alta, DateTime.Now);

            t1.AdicionarItem(new ItemTarefa("a"));
            t1.AdicionarItem(new ItemTarefa("b"));
            t1.AdicionarItem(new ItemTarefa("c"));

            Tarefa t2 = new Tarefa(1, "Preparar Apresentação 2 ", PrioridadeTarefaEnum.Alta, DateTime.Now);

            t2.AdicionarItem(new ItemTarefa("a"));
            t2.AdicionarItem(new ItemTarefa("b"));
            t2.AdicionarItem(new ItemTarefa("c"));


            Tarefa t3 = new Tarefa(1, "Preparar Apresentação 3 ", PrioridadeTarefaEnum.Baixa, DateTime.Now);

            t3.AdicionarItem(new ItemTarefa("a"));
            t3.AdicionarItem(new ItemTarefa("b"));
            t3.AdicionarItem(new ItemTarefa("c"));

            Tarefa t4 = new Tarefa(1, "Preparar Apresentação 4 ", PrioridadeTarefaEnum.Alta, DateTime.Now);

            t4.AdicionarItem(new ItemTarefa("a"));
            t4.AdicionarItem(new ItemTarefa("b"));
            t4.AdicionarItem(new ItemTarefa("c"));

            Tarefa t5 = new Tarefa(1, "Preparar Apresentação 5", PrioridadeTarefaEnum.Normal, DateTime.Now);

            t5.AdicionarItem(new ItemTarefa("a"));
            t5.AdicionarItem(new ItemTarefa("b"));
            t5.AdicionarItem(new ItemTarefa("c"));

            Tarefa t6 = new Tarefa(1, "Preparar Apresentação 6", PrioridadeTarefaEnum.Baixa, DateTime.Now);

            t6.AdicionarItem(new ItemTarefa("a"));
            t6.AdicionarItem(new ItemTarefa("b"));
            t6.AdicionarItem(new ItemTarefa("c"));

            repositorioTarefa.Inserir(t1);
            repositorioTarefa.Inserir(t2);
            repositorioTarefa.Inserir(t3);
            repositorioTarefa.Inserir(t4);
            repositorioTarefa.Inserir(t5);
            repositorioTarefa.Inserir(t6);
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