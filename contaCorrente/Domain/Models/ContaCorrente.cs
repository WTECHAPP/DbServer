namespace contaCorrente.Domain.Models
{
    public class ContaCorrente
    {
        public int IdContaCorrente { get; set; }
        public long CpfCliente { get; set; }
        public string NomeCliente { get; set; }
        public int Agencia { get; set; }
        public int NumContaCorrente { get; set; }
    }
}