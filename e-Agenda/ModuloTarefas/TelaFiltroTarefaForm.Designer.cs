namespace e_Agenda.ModuloTarefas
{
    partial class TelaFiltroTarefaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rb_todos = new RadioButton();
            rb_pendentes = new RadioButton();
            rb_concluidas = new RadioButton();
            bt_cancelar = new Button();
            bt_filtrar = new Button();
            SuspendLayout();
            // 
            // rb_todos
            // 
            rb_todos.AutoSize = true;
            rb_todos.Location = new Point(22, 29);
            rb_todos.Name = "rb_todos";
            rb_todos.Size = new Size(159, 19);
            rb_todos.TabIndex = 0;
            rb_todos.TabStop = true;
            rb_todos.Text = "Visualizar todas as Tarefas";
            rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_pendentes
            // 
            rb_pendentes.AutoSize = true;
            rb_pendentes.Location = new Point(22, 64);
            rb_pendentes.Name = "rb_pendentes";
            rb_pendentes.Size = new Size(234, 19);
            rb_pendentes.TabIndex = 1;
            rb_pendentes.TabStop = true;
            rb_pendentes.Text = "Visualizar somente as Tarefas Pendentes";
            rb_pendentes.UseVisualStyleBackColor = true;
            // 
            // rb_concluidas
            // 
            rb_concluidas.AutoSize = true;
            rb_concluidas.Location = new Point(22, 100);
            rb_concluidas.Name = "rb_concluidas";
            rb_concluidas.Size = new Size(238, 19);
            rb_concluidas.TabIndex = 2;
            rb_concluidas.TabStop = true;
            rb_concluidas.Text = "Visualizar somente as Tarefas Concluídas";
            rb_concluidas.UseVisualStyleBackColor = true;
            rb_concluidas.CheckedChanged += rb_futuros_CheckedChanged;
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(262, 152);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 21;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_filtrar
            // 
            bt_filtrar.DialogResult = DialogResult.OK;
            bt_filtrar.Location = new Point(181, 152);
            bt_filtrar.Name = "bt_filtrar";
            bt_filtrar.Size = new Size(75, 49);
            bt_filtrar.TabIndex = 20;
            bt_filtrar.Text = "Filtrar";
            bt_filtrar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 215);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_filtrar);
            Controls.Add(rb_concluidas);
            Controls.Add(rb_pendentes);
            Controls.Add(rb_todos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroTarefaForm";
            ShowIcon = false;
            Text = "Filtro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        private void rb_futuros_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RadioButton rb_todos;
        private RadioButton rb_pendentes;
        private RadioButton rb_concluidas;
        private Button bt_cancelar;
        private Button bt_filtrar;
    }
}