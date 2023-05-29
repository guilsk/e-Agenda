namespace e_Agenda.ModuloContato
{
    partial class TelaContatoForm
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
            lb_id = new Label();
            lb_nome = new Label();
            lb_telefone = new Label();
            lb_cargo = new Label();
            lb_email = new Label();
            lb_empresa = new Label();
            tf_telefone = new MaskedTextBox();
            tf_id = new TextBox();
            tf_nome = new TextBox();
            tf_cargo = new TextBox();
            tf_email = new TextBox();
            tf_empresa = new TextBox();
            bt_salvar = new Button();
            bt_cancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(42, 65);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(20, 15);
            lb_id.TabIndex = 0;
            lb_id.Text = "Id:";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Location = new Point(20, 94);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(43, 15);
            lb_nome.TabIndex = 1;
            lb_nome.Text = "Nome:";
            // 
            // lb_telefone
            // 
            lb_telefone.AutoSize = true;
            lb_telefone.Location = new Point(9, 123);
            lb_telefone.Name = "lb_telefone";
            lb_telefone.Size = new Size(54, 15);
            lb_telefone.TabIndex = 2;
            lb_telefone.Text = "Telefone:";
            // 
            // lb_cargo
            // 
            lb_cargo.AutoSize = true;
            lb_cargo.Location = new Point(20, 152);
            lb_cargo.Name = "lb_cargo";
            lb_cargo.Size = new Size(42, 15);
            lb_cargo.TabIndex = 3;
            lb_cargo.Text = "Cargo:";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(327, 123);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(44, 15);
            lb_email.TabIndex = 4;
            lb_email.Text = "E-mail:";
            // 
            // lb_empresa
            // 
            lb_empresa.AutoSize = true;
            lb_empresa.Location = new Point(316, 152);
            lb_empresa.Name = "lb_empresa";
            lb_empresa.Size = new Size(55, 15);
            lb_empresa.TabIndex = 5;
            lb_empresa.Text = "Empresa:";
            // 
            // tf_telefone
            // 
            tf_telefone.Location = new Point(69, 120);
            tf_telefone.Mask = "(99) 0,0000-0000";
            tf_telefone.Name = "tf_telefone";
            tf_telefone.Size = new Size(208, 23);
            tf_telefone.TabIndex = 6;
            // 
            // tf_id
            // 
            tf_id.Location = new Point(69, 62);
            tf_id.Name = "tf_id";
            tf_id.Size = new Size(89, 23);
            tf_id.TabIndex = 7;
            // 
            // tf_nome
            // 
            tf_nome.Location = new Point(69, 91);
            tf_nome.Name = "tf_nome";
            tf_nome.Size = new Size(546, 23);
            tf_nome.TabIndex = 8;
            // 
            // tf_cargo
            // 
            tf_cargo.Location = new Point(69, 149);
            tf_cargo.Name = "tf_cargo";
            tf_cargo.Size = new Size(208, 23);
            tf_cargo.TabIndex = 9;
            // 
            // tf_email
            // 
            tf_email.Location = new Point(377, 120);
            tf_email.Name = "tf_email";
            tf_email.Size = new Size(238, 23);
            tf_email.TabIndex = 10;
            // 
            // tf_empresa
            // 
            tf_empresa.Location = new Point(377, 149);
            tf_empresa.Name = "tf_empresa";
            tf_empresa.Size = new Size(238, 23);
            tf_empresa.TabIndex = 11;
            // 
            // bt_salvar
            // 
            bt_salvar.DialogResult = DialogResult.OK;
            bt_salvar.Location = new Point(459, 211);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(75, 51);
            bt_salvar.TabIndex = 12;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += bt_salvar_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.DialogResult = DialogResult.Cancel;
            bt_cancelar.Location = new Point(540, 211);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(75, 51);
            bt_cancelar.TabIndex = 13;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 37);
            label1.TabIndex = 14;
            label1.Text = "Formulário de Contatos";
            // 
            // TelaContatoForm
            // 
            AcceptButton = bt_salvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bt_cancelar;
            ClientSize = new Size(628, 276);
            Controls.Add(label1);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(tf_empresa);
            Controls.Add(tf_email);
            Controls.Add(tf_cargo);
            Controls.Add(tf_nome);
            Controls.Add(tf_id);
            Controls.Add(tf_telefone);
            Controls.Add(lb_empresa);
            Controls.Add(lb_email);
            Controls.Add(lb_cargo);
            Controls.Add(lb_telefone);
            Controls.Add(lb_nome);
            Controls.Add(lb_id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaContato";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_id;
        private Label lb_nome;
        private Label lb_telefone;
        private Label lb_cargo;
        private Label lb_email;
        private Label lb_empresa;
        private MaskedTextBox tf_telefone;
        private TextBox tf_id;
        private TextBox tf_nome;
        private TextBox tf_cargo;
        private TextBox tf_email;
        private TextBox tf_empresa;
        private Button bt_salvar;
        private Button bt_cancelar;
        private Label label1;
    }
}