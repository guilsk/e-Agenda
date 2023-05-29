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
    public partial class TelaFiltroCompromissoForm : Form
    {
        public TelaFiltroCompromissoForm()
        {
            InitializeComponent();
        }

        public StatusCompromissoEnum ObterStatus()
        {
            if (rb_futuros.Checked)
            {
                return StatusCompromissoEnum.Futuros;
            }
            else if (rb_passados.Checked)
            {
                return StatusCompromissoEnum.Passados;
            }
            else
            {
                return StatusCompromissoEnum.Todos;
            }
        }

        public DateTime ObterDataInicio()
        {
            return dtp_dataInicial.Value;
        }

        public DateTime ObterDataFinal()
        {
            return dtp_dataFinal.Value;
        }

        private void rb_futuros_CheckedChanged(object sender, EventArgs e)
        {
            dtp_dataInicial.Enabled = !dtp_dataInicial.Enabled;
            dtp_dataFinal.Enabled = !dtp_dataFinal.Enabled;
        }
    }
}
