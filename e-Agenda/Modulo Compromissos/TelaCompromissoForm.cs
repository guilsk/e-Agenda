using e_Agenda.Compartilhado;
using e_Agenda.ModuloContato;
using System.Xml.Linq;

namespace e_Agenda.Modulo_Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarContatos(contatos);
        }

        private void CarregarContatos(List<Contato> contatos)
        {
            foreach (Contato item in contatos)
            {
                comboBox_contato.Items.Add(item);
            }
        }

        public Compromisso ObterCompromisso()
        {
            int id = Convert.ToInt32(tf_id.Text);
            string assunto = tf_assunto.Text;

            DateTime data = dtp_data.Value;

            TimeSpan horarioInicio = dtp_inicio.Value.TimeOfDay;
            TimeSpan horarioFinal = dtp_final.Value.TimeOfDay;

            TipoLocalEnum tipo = rb_remoto.Checked ? TipoLocalEnum.Online : TipoLocalEnum.Presencial;

            Contato contato = (Contato)comboBox_contato.SelectedItem;

            string local;
            if (rb_remoto.Checked) local = tf_localRemoto.Text;
            else local = tf_localPresencial.Text;

            Compromisso compromisso = new Compromisso(id, assunto, data, horarioInicio, horarioFinal, contato, local, tipo);

            return compromisso;
        }

        public void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            tf_id.Text = compromissoSelecionado.id.ToString();
            tf_assunto.Text = compromissoSelecionado.assunto;
            dtp_data.Value = compromissoSelecionado.data;
            dtp_inicio.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioInicio);
            dtp_final.Value = DateTime.Now.Date.Add(compromissoSelecionado.horarioFinal);

            if (compromissoSelecionado.contato != null)
            {
                checkBox_compromisso.Checked = true;
                comboBox_contato.SelectedItem = compromissoSelecionado.contato;
            }

            if (compromissoSelecionado.tipoLocal == TipoLocalEnum.Presencial)
            {
                rb_presencial.Checked = true;
                tf_localPresencial.Text = compromissoSelecionado.localPresencial;
            }
            else
            {
                rb_remoto.Checked = true;
                tf_localRemoto.Text = compromissoSelecionado.localOnline;
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rb_presencial_CheckedChanged(object sender, EventArgs e)
        {
            tf_localPresencial.Enabled = true;
            tf_localRemoto.Enabled = false;
            tf_localRemoto.Text = "";
        }

        private void rb_remoto_CheckedChanged(object sender, EventArgs e)
        {
            tf_localRemoto.Enabled = true;
            tf_localPresencial.Enabled = false;
            tf_localPresencial.Text = "";
        }

        private void checkBox_compromisso_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_contato.Enabled = !comboBox_contato.Enabled;
            comboBox_contato.SelectedIndex = -1;
        }
    }
}
