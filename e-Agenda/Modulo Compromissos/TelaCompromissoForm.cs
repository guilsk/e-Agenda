using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.Modulo_Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            set
            {
                tf_id.Text = value.id.ToString();
                tf_assunto.Text = value.assunto;
                dtp_data.Text = value.data;
                dtp_inicio.Text = value.inicio;
                dtp_termino.Text = value.termino;
                comboBox_contato.Text = value.contato;
                tf_local.Text = value.local;
            }
            get
            {
                return compromisso;
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string assunto = tf_assunto.Text;

            string data = dtp_data.Text;

            string inicio = dtp_inicio.Text;

            string termino = dtp_termino.Text;

            string contato = comboBox_contato.Text;

            string local = tf_local.Text;

            compromisso = new(assunto, data, inicio, termino, contato, local);

            if (tf_id.Text != "0")
                compromisso.id = Convert.ToInt32(tf_id.Text);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
