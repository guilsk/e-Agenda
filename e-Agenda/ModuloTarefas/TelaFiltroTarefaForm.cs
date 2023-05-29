using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.ModuloTarefas
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rb_concluidas.Checked == true)
                return StatusTarefaEnum.Concluidas;

            else if (rb_pendentes.Checked == true)
                return StatusTarefaEnum.Pendentes;

            return StatusTarefaEnum.Todos;
        }
    }
}
