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
        public string data;
        public string inicio;
        public string termino;
        public string contato;
        public string local;

        public Compromisso(string assunto, string data, string inicio, string termino, string contato, string local)
        {
            this.assunto = assunto;
            this.data = data;
            this.inicio = inicio;
            this.termino = termino;
            this.contato = contato;
            this.local = local;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + assunto + ", " + data + ", Local: " + local;
        }
    }
}
