using e_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Modulo_Compromissos
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new();
        private static int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.inicio = compromisso.inicio;
            compromissoSelecionado.termino = compromisso.termino;
            if(compromisso.contato != null)
                compromissoSelecionado.contato = compromisso.contato;
            compromissoSelecionado.local = compromisso.local;
        }

        private Compromisso SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);
        }
    }
}
