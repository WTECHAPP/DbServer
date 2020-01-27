using System;

namespace contaCorrente.Domain.Models
{
    public class Lancamento
    {
        public int IdLancamento { get; set; }
        public DateTime DataLacamento { get; set; }
        public int NumContaCorrenteOrigem { get; set; }
        public int NumContaCorrenteDestino { get; set; }
        public Decimal Valor { get; set; }
    }
}