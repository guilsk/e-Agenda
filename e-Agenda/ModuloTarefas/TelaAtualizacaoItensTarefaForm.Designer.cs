namespace e_Agenda.ModuloTarefas
{
    partial class TelaAtualizacaoItensTarefaForm
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
            bt_cancelar = new Button();
            bt_salvar = new Button();
            tf_titulo = new TextBox();
            tf_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            list_itensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(421, 444);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 44;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            bt_salvar.DialogResult = DialogResult.OK;
            bt_salvar.Location = new Point(340, 444);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 49);
            bt_salvar.TabIndex = 43;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            // 
            // tf_titulo
            // 
            tf_titulo.Location = new Point(74, 53);
            tf_titulo.Name = "tf_titulo";
            tf_titulo.Size = new Size(423, 23);
            tf_titulo.TabIndex = 42;
            // 
            // tf_id
            // 
            tf_id.Location = new Point(74, 15);
            tf_id.Name = "tf_id";
            tf_id.Size = new Size(100, 23);
            tf_id.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 56);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 40;
            label3.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 18);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 39;
            label2.Text = "Id:";
            // 
            // list_itensTarefa
            // 
            list_itensTarefa.FormattingEnabled = true;
            list_itensTarefa.Location = new Point(28, 107);
            list_itensTarefa.Name = "list_itensTarefa";
            list_itensTarefa.Size = new Size(468, 328);
            list_itensTarefa.TabIndex = 49;
            // 
            // TelaAtualizacaoItemTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 505);
            Controls.Add(list_itensTarefa);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(tf_titulo);
            Controls.Add(tf_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaAtualizacaoItemTarefaForm";
            Text = "TelaAtualizacaoItensTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_cancelar;
        private Button bt_salvar;
        private TextBox tf_titulo;
        private TextBox tf_id;
        private Label label3;
        private Label label2;
        private CheckedListBox list_itensTarefa;
    }
}