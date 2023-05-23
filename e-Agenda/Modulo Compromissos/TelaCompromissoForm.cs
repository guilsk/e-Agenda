using e_Agenda.ModuloContato;
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

        private List<Contato> contatos;

        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.contatos = contatos;

            AdicionaItensComboBox(contatos);
        }

        private void AdicionaItensComboBox(List<Contato> contatos)
        {
            foreach (Contato item in contatos)
            {
                comboBox_contato.Items.Add(item.nome);
            }
        }

        public Compromisso Compromisso
        {
            set
            {
                tf_id.Text = value.id.ToString();
                tf_assunto.Text = value.assunto;
                dtp_data.Text = value.data.ToString();
                dtp_inicio.Text = value.inicio.ToString();
                dtp_termino.Text = value.termino.ToString();
                comboBox_contato.Text = value.contato.ToString();
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

            DateTime data = dtp_data.Value;

            TimeSpan inicio = dtp_inicio.Value.TimeOfDay;

            TimeSpan termino = dtp_termino.Value.TimeOfDay;

            string local;

            if (rb_presencial.Checked)
                local = "Presencial: " + tf_local.Text;
            else
                local = "Remoto: " + tf_local.Text;

            Contato contato;

            if (checkBox_compromisso.Checked)
            {
                string nomeDoContato = comboBox_contato.Text;

                foreach (Contato c in contatos)
                    if (c.nome == nomeDoContato)
                    {
                        contato = c;
                        compromisso = new(assunto, data, inicio, termino, contato, local);
                        break;
                    }
            }
            else
            {
                compromisso = new(assunto, data, inicio, termino, local);
            }

            if (tf_id.Text != "0")
                compromisso.id = Convert.ToInt32(tf_id.Text);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
