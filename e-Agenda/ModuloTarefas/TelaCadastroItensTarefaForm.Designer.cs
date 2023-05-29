namespace e_Agenda.ModuloTarefas
{
    partial class TelaCadastroItensTarefaForm
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
            list_Itens = new ListBox();
            bt_adicionar = new Button();
            tf_descricao = new TextBox();
            label1 = new Label();
            bt_cancelar = new Button();
            bt_salvar = new Button();
            tf_titulo = new TextBox();
            tf_id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // list_Itens
            // 
            list_Itens.FormattingEnabled = true;
            list_Itens.ItemHeight = 15;
            list_Itens.Location = new Point(12, 151);
            list_Itens.Name = "list_Itens";
            list_Itens.Size = new Size(485, 319);
            list_Itens.TabIndex = 48;
            // 
            // bt_adicionar
            // 
            bt_adicionar.Location = new Point(422, 90);
            bt_adicionar.Name = "bt_adicionar";
            bt_adicionar.Size = new Size(75, 23);
            bt_adicionar.TabIndex = 47;
            bt_adicionar.Text = "Adicionar";
            bt_adicionar.UseVisualStyleBackColor = true;
            // 
            // tf_descricao
            // 
            tf_descricao.Location = new Point(74, 91);
            tf_descricao.Name = "tf_descricao";
            tf_descricao.Size = new Size(342, 23);
            tf_descricao.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 94);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 45;
            label1.Text = "Descrição:";
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(421, 480);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 44;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            bt_salvar.DialogResult = DialogResult.OK;
            bt_salvar.Location = new Point(340, 480);
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
            // TelaCadastroItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 541);
            Controls.Add(list_Itens);
            Controls.Add(bt_adicionar);
            Controls.Add(tf_descricao);
            Controls.Add(label1);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(tf_titulo);
            Controls.Add(tf_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaCadastroItensTarefaForm";
            Text = "TelaCadastroItensTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox list_Itens;
        private Button bt_adicionar;
        private TextBox tf_descricao;
        private Label label1;
        private Button bt_cancelar;
        private Button bt_salvar;
        private TextBox tf_titulo;
        private TextBox tf_id;
        private Label label3;
        private Label label2;
    }
}