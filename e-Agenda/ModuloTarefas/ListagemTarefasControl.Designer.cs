﻿namespace e_Agenda.ModuloTarefas
{
    partial class ListagemTarefasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listTarefas = new ListBox();
            SuspendLayout();
            // 
            // listTarefas
            // 
            listTarefas.Dock = DockStyle.Fill;
            listTarefas.FormattingEnabled = true;
            listTarefas.ItemHeight = 15;
            listTarefas.Location = new Point(0, 0);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(998, 586);
            listTarefas.TabIndex = 0;
            // 
            // ListagemTarefasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefas);
            Name = "ListagemTarefasControl";
            Size = new Size(998, 586);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTarefas;
    }
}
