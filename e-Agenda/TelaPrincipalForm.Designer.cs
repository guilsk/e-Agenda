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
            toolStrip1 = new ToolStrip();
            bt_add = new ToolStripButton();
            bt_edit = new ToolStripButton();
            bt_delete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lb_tipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            MenuItemContato.Size = new Size(180, 22);
            MenuItemContato.Text = "Contato";
            MenuItemContato.Click += MenuItemContato_Click;
            // 
            // MenuItemCompromisso
            // 
            MenuItemCompromisso.Name = "MenuItemCompromisso";
            MenuItemCompromisso.Size = new Size(180, 22);
            MenuItemCompromisso.Text = "Compromisso";
            MenuItemCompromisso.Click += MenuItemCompromisso_Click;
            // 
            // MenuItemTarefas
            // 
            MenuItemTarefas.Name = "MenuItemTarefas";
            MenuItemTarefas.Size = new Size(180, 22);
            MenuItemTarefas.Text = "Tarefas";
            MenuItemTarefas.Click += MenuItemTarefas_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItemDespesas, MenuItemCategorias });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(180, 22);
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { bt_add, bt_edit, bt_delete, toolStripSeparator1, lb_tipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(832, 45);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // bt_add
            // 
            bt_add.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_add.Image = (Image)resources.GetObject("bt_add.Image");
            bt_add.ImageScaling = ToolStripItemImageScaling.None;
            bt_add.ImageTransparentColor = Color.Magenta;
            bt_add.Name = "bt_add";
            bt_add.Padding = new Padding(7);
            bt_add.Size = new Size(42, 42);
            bt_add.Text = "toolStripButton1";
            bt_add.ToolTipText = "Inserir";
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_edit.Image = (Image)resources.GetObject("bt_edit.Image");
            bt_edit.ImageScaling = ToolStripItemImageScaling.None;
            bt_edit.ImageTransparentColor = Color.Magenta;
            bt_edit.Name = "bt_edit";
            bt_edit.Padding = new Padding(7);
            bt_edit.Size = new Size(42, 42);
            bt_edit.Text = "toolStripButton2";
            bt_edit.ToolTipText = "Editar";
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bt_delete.Image = (Image)resources.GetObject("bt_delete.Image");
            bt_delete.ImageScaling = ToolStripItemImageScaling.None;
            bt_delete.ImageTransparentColor = Color.Magenta;
            bt_delete.Name = "bt_delete";
            bt_delete.Padding = new Padding(7);
            bt_delete.Size = new Size(42, 42);
            bt_delete.Text = "toolStripButton3";
            bt_delete.ToolTipText = "Deletar";
            bt_delete.Click += bt_delete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
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
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 453);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(832, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 475);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton bt_add;
        private ToolStripButton bt_edit;
        private ToolStripButton bt_delete;
        private ToolStripLabel lb_tipoCadastro;
        private Panel panelRegistros;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem MenuItemTarefas;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem MenuItemDespesas;
        private ToolStripMenuItem MenuItemCategorias;
        private ToolStripMenuItem MenuItemRelatorios;
        private ToolStripSeparator toolStripSeparator1;
    }
}