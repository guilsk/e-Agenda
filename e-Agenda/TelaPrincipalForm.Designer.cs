namespace e_Agenda
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MenuItemContato = new ToolStripMenuItem();
            MenuItemCompromisso = new ToolStripMenuItem();
            MenuItemTarefas = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            MenuItemDespesas = new ToolStripMenuItem();
            MenuItemCategorias = new ToolStripMenuItem();
            MenuItemRelatorios = new ToolStripMenuItem();
            barraFerramentas = new ToolStrip();
            bt_inserir = new ToolStripButton();
            bt_editar = new ToolStripButton();
            bt_excluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            bt_filtrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            bt_adicionar_itens = new ToolStripButton();
            bt_concluir_itens = new ToolStripButton();
            lb_tipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            lb_rodape = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            barraFerramentas.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, MenuItemRelatorios });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(832, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemContato, MenuItemCompromisso, MenuItemTarefas, despesasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // MenuItemContato
            // 
            MenuItemContato.Name = "MenuItemContato";
            MenuItemContato.Size = new Size(149, 22);
            MenuItemContato.Text = "Contato";
            MenuItemContato.Click += MenuItemContato_Click;
            // 
            // MenuItemCompromisso
            // 
            MenuItemCompromisso.Name = "MenuItemCompromisso";
            MenuItemCompromisso.Size = new Size(149, 22);
            MenuItemCompromisso.Text = "Compromisso";
            MenuItemCompromisso.Click += MenuItemCompromisso_Click;
            // 
            // MenuItemTarefas
            // 
            MenuItemTarefas.Name = "MenuItemTarefas";
            MenuItemTarefas.Size = new Size(149, 22);
            MenuItemTarefas.Text = "Tarefas";
            MenuItemTarefas.Click += MenuItemTarefas_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemDespesas, MenuItemCategorias });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(149, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // MenuItemDespesas
            // 
            MenuItemDespesas.Name = "MenuItemDespesas";
            MenuItemDespesas.Size = new Size(130, 22);
            MenuItemDespesas.Text = "Despesas";
            // 
            // MenuItemCategorias
            // 
            MenuItemCategorias.Name = "MenuItemCategorias";
            MenuItemCategorias.Size = new Size(130, 22);
            MenuItemCategorias.Text = "Categorias";
            // 
            // MenuItemRelatorios
            // 
            MenuItemRelatorios.Name = "MenuItemRelatorios";
            MenuItemRelatorios.Size = new Size(71, 20);
            MenuItemRelatorios.Text = "Relatórios";
            // 
            // barraFerramentas
            // 
            barraFerramentas.Items.AddRange(new ToolStripItem[] { bt_inserir, bt_editar, bt_excluir, toolStripSeparator1, bt_filtrar, toolStripSeparator2, bt_adicionar_itens, bt_concluir_itens, lb_tipoCadastro });
            barraFerramentas.Location = new Point(0, 24);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(832, 45);
            barraFerramentas.TabIndex = 1;
            barraFerramentas.Text = "toolStrip1";
            // 
            // bt_inserir
            // 
            bt_inserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_inserir.Image = (Image)resources.GetObject("bt_inserir.Image");
            bt_inserir.ImageScaling = ToolStripItemImageScaling.None;
            bt_inserir.ImageTransparentColor = Color.Magenta;
            bt_inserir.Name = "bt_inserir";
            bt_inserir.Padding = new Padding(7);
            bt_inserir.Size = new Size(42, 42);
            bt_inserir.Text = "toolStripButton1";
            bt_inserir.ToolTipText = "Inserir";
            bt_inserir.Click += bt_add_Click;
            // 
            // bt_editar
            // 
            bt_editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_editar.Image = (Image)resources.GetObject("bt_editar.Image");
            bt_editar.ImageScaling = ToolStripItemImageScaling.None;
            bt_editar.ImageTransparentColor = Color.Magenta;
            bt_editar.Name = "bt_editar";
            bt_editar.Padding = new Padding(7);
            bt_editar.Size = new Size(42, 42);
            bt_editar.Text = "toolStripButton2";
            bt_editar.ToolTipText = "Editar";
            bt_editar.Click += bt_edit_Click;
            // 
            // bt_excluir
            // 
            bt_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_excluir.Image = (Image)resources.GetObject("bt_excluir.Image");
            bt_excluir.ImageScaling = ToolStripItemImageScaling.None;
            bt_excluir.ImageTransparentColor = Color.Magenta;
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Padding = new Padding(7);
            bt_excluir.Size = new Size(42, 42);
            bt_excluir.Text = "toolStripButton3";
            bt_excluir.ToolTipText = "Excluir";
            bt_excluir.Click += bt_delete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // bt_filtrar
            // 
            bt_filtrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_filtrar.Image = Properties.Resources.filter_alt_FILL0_wght400_GRAD0_opsz24;
            bt_filtrar.ImageScaling = ToolStripItemImageScaling.None;
            bt_filtrar.ImageTransparentColor = Color.Magenta;
            bt_filtrar.Name = "bt_filtrar";
            bt_filtrar.Size = new Size(28, 42);
            bt_filtrar.Text = "toolStripButton1";
            bt_filtrar.ToolTipText = "Filtrar";
            bt_filtrar.Click += bt_filtrar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // bt_adicionar_itens
            // 
            bt_adicionar_itens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_adicionar_itens.Image = Properties.Resources.add_to_photos_FILL0_wght400_GRAD0_opsz24;
            bt_adicionar_itens.ImageScaling = ToolStripItemImageScaling.None;
            bt_adicionar_itens.ImageTransparentColor = Color.Magenta;
            bt_adicionar_itens.Name = "bt_adicionar_itens";
            bt_adicionar_itens.Size = new Size(28, 42);
            bt_adicionar_itens.Text = "toolStripButton2";
            bt_adicionar_itens.ToolTipText = "Adicionar Itens";
            bt_adicionar_itens.Click += bt_adicionar_Click;
            // 
            // bt_concluir_itens
            // 
            bt_concluir_itens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_concluir_itens.Image = Properties.Resources.check_box_FILL0_wght400_GRAD0_opsz24;
            bt_concluir_itens.ImageScaling = ToolStripItemImageScaling.None;
            bt_concluir_itens.ImageTransparentColor = Color.Magenta;
            bt_concluir_itens.Name = "bt_concluir_itens";
            bt_concluir_itens.Size = new Size(28, 42);
            bt_concluir_itens.Text = "toolStripButton1";
            bt_concluir_itens.ToolTipText = "Concluir Itens";
            bt_concluir_itens.Click += bt_concluir_itens_Click;
            // 
            // lb_tipoCadastro
            // 
            lb_tipoCadastro.Name = "lb_tipoCadastro";
            lb_tipoCadastro.Size = new Size(80, 42);
            lb_tipoCadastro.Text = "Tipo Cadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.AutoSize = true;
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(832, 406);
            panelRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lb_rodape });
            statusStrip1.Location = new Point(0, 453);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(832, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lb_rodape
            // 
            lb_rodape.Name = "lb_rodape";
            lb_rodape.Size = new Size(118, 17);
            lb_rodape.Text = "toolStripStatusLabel1";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 475);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(barraFerramentas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem MenuItemContato;
        private ToolStripMenuItem MenuItemCompromisso;
        private ToolStrip barraFerramentas;
        private ToolStripButton bt_inserir;
        private ToolStripButton bt_editar;
        private ToolStripButton bt_excluir;
        private ToolStripLabel lb_tipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lb_rodape;
        private ToolStripMenuItem MenuItemTarefas;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem MenuItemDespesas;
        private ToolStripMenuItem MenuItemCategorias;
        private ToolStripMenuItem MenuItemRelatorios;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton bt_filtrar;
        private ToolStripButton bt_adicionar_itens;
        private ToolStripButton bt_concluir_itens;
        private ToolStripSeparator toolStripSeparator2;
    }
}