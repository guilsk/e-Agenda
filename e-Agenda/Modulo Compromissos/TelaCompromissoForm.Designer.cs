﻿namespace e_Agenda.Modulo_Compromissos
{
    partial class TelaCompromissoForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox_compromisso = new CheckBox();
            rb_remoto = new RadioButton();
            rb_presencial = new RadioButton();
            tf_id = new TextBox();
            tf_assunto = new TextBox();
            tf_localPresencial = new TextBox();
            dtp_data = new DateTimePicker();
            dtp_inicio = new DateTimePicker();
            dtp_final = new DateTimePicker();
            comboBox_contato = new ComboBox();
            bt_cancelar = new Button();
            bt_salvar = new Button();
            groupBox1 = new GroupBox();
            tf_localRemoto = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 37);
            label1.TabIndex = 0;
            label1.Text = "Formulário Compromisso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Assunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 146);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 187);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Início:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 187);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Término:";
            // 
            // checkBox_compromisso
            // 
            checkBox_compromisso.AutoSize = true;
            checkBox_compromisso.Location = new Point(73, 222);
            checkBox_compromisso.Name = "checkBox_compromisso";
            checkBox_compromisso.Size = new Size(277, 19);
            checkBox_compromisso.TabIndex = 6;
            checkBox_compromisso.Text = "Deseja marcar um contato neste compromisso?";
            checkBox_compromisso.UseVisualStyleBackColor = true;
            checkBox_compromisso.CheckedChanged += checkBox_compromisso_CheckedChanged;
            // 
            // rb_remoto
            // 
            rb_remoto.AutoSize = true;
            rb_remoto.Location = new Point(11, 28);
            rb_remoto.Name = "rb_remoto";
            rb_remoto.Size = new Size(70, 19);
            rb_remoto.TabIndex = 7;
            rb_remoto.TabStop = true;
            rb_remoto.Text = "Remoto:";
            rb_remoto.UseVisualStyleBackColor = true;
            rb_remoto.CheckedChanged += rb_remoto_CheckedChanged;
            // 
            // rb_presencial
            // 
            rb_presencial.AutoSize = true;
            rb_presencial.Location = new Point(11, 58);
            rb_presencial.Name = "rb_presencial";
            rb_presencial.Size = new Size(81, 19);
            rb_presencial.TabIndex = 8;
            rb_presencial.TabStop = true;
            rb_presencial.Text = "Presencial:";
            rb_presencial.UseVisualStyleBackColor = true;
            rb_presencial.CheckedChanged += rb_presencial_CheckedChanged;
            // 
            // tf_id
            // 
            tf_id.Location = new Point(77, 66);
            tf_id.Name = "tf_id";
            tf_id.Size = new Size(100, 23);
            tf_id.TabIndex = 10;
            // 
            // tf_assunto
            // 
            tf_assunto.Location = new Point(77, 102);
            tf_assunto.Name = "tf_assunto";
            tf_assunto.Size = new Size(484, 23);
            tf_assunto.TabIndex = 11;
            // 
            // tf_localPresencial
            // 
            tf_localPresencial.Location = new Point(101, 58);
            tf_localPresencial.Name = "tf_localPresencial";
            tf_localPresencial.Size = new Size(302, 23);
            tf_localPresencial.TabIndex = 12;
            // 
            // dtp_data
            // 
            dtp_data.CustomFormat = "dd/MM/yyyy";
            dtp_data.Format = DateTimePickerFormat.Custom;
            dtp_data.Location = new Point(73, 140);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(200, 23);
            dtp_data.TabIndex = 14;
            dtp_data.Value = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            // 
            // dtp_inicio
            // 
            dtp_inicio.CustomFormat = "HH:mm";
            dtp_inicio.Format = DateTimePickerFormat.Custom;
            dtp_inicio.ImeMode = ImeMode.NoControl;
            dtp_inicio.Location = new Point(73, 181);
            dtp_inicio.Name = "dtp_inicio";
            dtp_inicio.ShowUpDown = true;
            dtp_inicio.Size = new Size(200, 23);
            dtp_inicio.TabIndex = 15;
            dtp_inicio.Value = new DateTime(2023, 5, 18, 17, 15, 0, 0);
            // 
            // dtp_final
            // 
            dtp_final.CustomFormat = "HH:mm";
            dtp_final.Format = DateTimePickerFormat.Custom;
            dtp_final.Location = new Point(361, 181);
            dtp_final.Name = "dtp_final";
            dtp_final.ShowUpDown = true;
            dtp_final.Size = new Size(200, 23);
            dtp_final.TabIndex = 16;
            dtp_final.Value = new DateTime(2023, 5, 23, 17, 59, 0, 0);
            // 
            // comboBox_contato
            // 
            comboBox_contato.FormattingEnabled = true;
            comboBox_contato.Location = new Point(73, 247);
            comboBox_contato.Name = "comboBox_contato";
            comboBox_contato.Size = new Size(183, 23);
            comboBox_contato.TabIndex = 17;
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(475, 412);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 49);
            bt_cancelar.TabIndex = 19;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_salvar
            // 
            bt_salvar.DialogResult = DialogResult.OK;
            bt_salvar.Location = new Point(394, 412);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 49);
            bt_salvar.TabIndex = 18;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tf_localRemoto);
            groupBox1.Controls.Add(tf_localPresencial);
            groupBox1.Controls.Add(rb_presencial);
            groupBox1.Controls.Add(rb_remoto);
            groupBox1.Location = new Point(66, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 94);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localização";
            // 
            // tf_localRemoto
            // 
            tf_localRemoto.Location = new Point(101, 27);
            tf_localRemoto.Name = "tf_localRemoto";
            tf_localRemoto.Size = new Size(302, 23);
            tf_localRemoto.TabIndex = 13;
            // 
            // TelaCompromissoForm
            // 
            AcceptButton = bt_salvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bt_cancelar;
            ClientSize = new Size(586, 479);
            Controls.Add(groupBox1);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(comboBox_contato);
            Controls.Add(dtp_final);
            Controls.Add(dtp_inicio);
            Controls.Add(dtp_data);
            Controls.Add(tf_assunto);
            Controls.Add(tf_id);
            Controls.Add(checkBox_compromisso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCompromissoForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox_compromisso;
        private RadioButton rb_remoto;
        private RadioButton rb_presencial;
        private TextBox tf_id;
        private TextBox tf_assunto;
        private TextBox tf_localPresencial;
        private DateTimePicker dtp_data;
        private DateTimePicker dtp_inicio;
        private DateTimePicker dtp_final;
        private ComboBox comboBox_contato;
        private Button bt_cancelar;
        private Button bt_salvar;
        private GroupBox groupBox1;
        private TextBox tf_localRemoto;
    }
}