using e_Agenda.Compartilhado;
using e_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Modulo_Compromissos
{
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public DateTime data;
        public TimeSpan inicio;
        public TimeSpan termino;
        public Contato contato;
        public string local;

        public Compromisso(string assunto, DateTime data, TimeSpan inicio, TimeSpan termino, Contato contato, string local)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.termino = termino;
            this.contato = contato;
            this.local = local;
        }

        public Compromisso(string assunto, DateTime data, TimeSpan inicio, TimeSpan termino, string local)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.termino = termino;
            this.local = local;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + assunto + ", " + (data + inicio) + ", Local: " + local;
        }
    }
}
