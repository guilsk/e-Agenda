namespace e_Agenda.ModuloTarefas
{
    partial class TelaTarefaForm
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
            label1 = new Label();
            bt_cancelar = new Button();
            bt_salvar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tf_id = new TextBox();
            cmb_prioridade = new ComboBox();
            tf_titulo = new TextBox();
            dtp_dataCriacao = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 15;
            label1.Text = "Formulário de Tarefas";
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(441, 226);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 21;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            bt_salvar.DialogResult = DialogResult.OK;
            bt_salvar.Location = new Point(360, 226);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 49);
            bt_salvar.TabIndex = 20;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 88);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 22;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 128);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 23;
            label3.Text = "Título:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 24;
            label4.Text = "Prioridade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 164);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 25;
            label5.Text = "Data de Criação:";
            // 
            // tf_id
            // 
            tf_id.Location = new Point(82, 85);
            tf_id.Name = "tf_id";
            tf_id.Size = new Size(100, 23);
            tf_id.TabIndex = 26;
            // 
            // cmb_prioridade
            // 
            cmb_prioridade.FormattingEnabled = true;
            cmb_prioridade.Location = new Point(82, 161);
            cmb_prioridade.Name = "cmb_prioridade";
            cmb_prioridade.Size = new Size(180, 23);
            cmb_prioridade.TabIndex = 27;
            // 
            // tf_titulo
            // 
            tf_titulo.Location = new Point(82, 125);
            tf_titulo.Name = "tf_titulo";
            tf_titulo.Size = new Size(434, 23);
            tf_titulo.TabIndex = 28;
            // 
            // dtp_dataCriacao
            // 
            dtp_dataCriacao.Format = DateTimePickerFormat.Short;
            dtp_dataCriacao.Location = new Point(390, 161);
            dtp_dataCriacao.Name = "dtp_dataCriacao";
            dtp_dataCriacao.Size = new Size(126, 23);
            dtp_dataCriacao.TabIndex = 29;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 299);
            Controls.Add(dtp_dataCriacao);
            Controls.Add(tf_titulo);
            Controls.Add(cmb_prioridade);
            Controls.Add(tf_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            ShowIcon = false;
            Text = "Formulário de Tarefas";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_cancelar;
        private Button bt_salvar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tf_id;
        private ComboBox cmb_prioridade;
        private TextBox tf_titulo;
        private DateTimePicker dtp_dataCriacao;
    }
}