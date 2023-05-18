using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            set
            {
                tf_id.Text = value.id.ToString();
                tf_nome.Text = value.nome;
                tf_telefone.Text = value.telefone;
                tf_email.Text = value.email;
                tf_cargo.Text = value.cargo;
                tf_empresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tf_nome.Text;

            string telefone = tf_telefone.Text;

            string email = tf_email.Text;

            string cargo = tf_cargo.Text;

            string empresa = tf_empresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            if (tf_id.Text != "0")
                contato.id = Convert.ToInt32(tf_id.Text);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
