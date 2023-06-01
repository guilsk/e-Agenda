namespace e_Agenda.ModuloDespesas
{
    [Serializable]
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public double valor;
        public DateTime data;
        public FormatoPagamentoDespesaEnum formatoPagamento;

        public List<Categoria> categoriasSelecionadas;

        public Despesa(string descricao, double valor, DateTime data, FormatoPagamentoDespesaEnum formatoPagamento, List<Categoria> categoriasSelecionadas)
        {
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.formatoPagamento = formatoPagamento;
            this.categoriasSelecionadas = categoriasSelecionadas;
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado)
        {
            this.descricao = registroAtualizado.descricao;
            this.data = registroAtualizado.data;
            this.valor = registroAtualizado.valor;
            this.formatoPagamento = registroAtualizado.formatoPagamento;
            this.categoriasSelecionadas = registroAtualizado.categoriasSelecionadas;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
            {
                erros.Add("O campo 'descrição' é obrigatório");
            }

            if (data == DateTime.MinValue)
            {
                erros.Add("O campo 'data' é obrigatório");
            }

            if (valor <= 0)
            {
                erros.Add("O campo 'valor' precisa ser maior que 0");
            }

            if (formatoPagamento == FormatoPagamentoDespesaEnum.Nenhum)
            {
                erros.Add("O campo 'forma de pagamento' é obrigatório");
            }

            return erros.ToArray();
        }
    }


}
