namespace e_Agenda.Modulo_Compromissos
{
    partial class TelaFiltroCompromissoForm
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
            rb_passados = new RadioButton();
            rb_futuros = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            dtp_dataInicial = new DateTimePicker();
            dtp_dataFinal = new DateTimePicker();
            bt_cancelar = new Button();
            bt_filtrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rb_todos
            // 
            rb_todos.AutoSize = true;
            rb_todos.Location = new Point(22, 29);
            rb_todos.Name = "rb_todos";
            rb_todos.Size = new Size(205, 19);
            rb_todos.TabIndex = 0;
            rb_todos.TabStop = true;
            rb_todos.Text = "Visualizar todos os Compromissos";
            rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_passados
            // 
            rb_passados.AutoSize = true;
            rb_passados.Location = new Point(22, 64);
            rb_passados.Name = "rb_passados";
            rb_passados.Size = new Size(272, 19);
            rb_passados.TabIndex = 1;
            rb_passados.TabStop = true;
            rb_passados.Text = "Visualizar somente os Compromissos Passados";
            rb_passados.UseVisualStyleBackColor = true;
            // 
            // rb_futuros
            // 
            rb_futuros.AutoSize = true;
            rb_futuros.Location = new Point(22, 100);
            rb_futuros.Name = "rb_futuros";
            rb_futuros.Size = new Size(264, 19);
            rb_futuros.TabIndex = 2;
            rb_futuros.TabStop = true;
            rb_futuros.Text = "Visualizar somente os Compromissos Futuros";
            rb_futuros.UseVisualStyleBackColor = true;
            rb_futuros.CheckedChanged += rb_futuros_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtp_dataFinal);
            groupBox1.Controls.Add(dtp_dataInicial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 76);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro para os Compromissos Futuros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 36);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Final:";
            // 
            // dtp_dataInicial
            // 
            dtp_dataInicial.Format = DateTimePickerFormat.Short;
            dtp_dataInicial.Location = new Point(80, 32);
            dtp_dataInicial.Name = "dtp_dataInicial";
            dtp_dataInicial.Size = new Size(101, 23);
            dtp_dataInicial.TabIndex = 2;
            // 
            // dtp_dataFinal
            // 
            dtp_dataFinal.Format = DateTimePickerFormat.Short;
            dtp_dataFinal.Location = new Point(263, 32);
            dtp_dataFinal.Name = "dtp_dataFinal";
            dtp_dataFinal.Size = new Size(101, 23);
            dtp_dataFinal.TabIndex = 3;
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(339, 230);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 21;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_filtrar
            // 
            bt_filtrar.DialogResult = DialogResult.OK;
            bt_filtrar.Location = new Point(258, 230);
            bt_filtrar.Name = "bt_filtrar";
            bt_filtrar.Size = new Size(75, 49);
            bt_filtrar.TabIndex = 20;
            bt_filtrar.Text = "Filtrar";
            bt_filtrar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 292);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_filtrar);
            Controls.Add(groupBox1);
            Controls.Add(rb_futuros);
            Controls.Add(rb_passados);
            Controls.Add(rb_todos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            Text = "Filtro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rb_todos;
        private RadioButton rb_passados;
        private RadioButton rb_futuros;
        private GroupBox groupBox1;
        private DateTimePicker dtp_dataFinal;
        private DateTimePicker dtp_dataInicial;
        private Label label2;
        private Label label1;
        private Button bt_cancelar;
        private Button bt_filtrar;
    }
}