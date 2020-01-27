using System.Collections.Generic;
using contaCorrente.Domain.Models;

namespace contaCorrente.Domain.Services
{
    public interface IContaCorrenteService
    {
         int Add(ContaCorrente cc);
         IEnumerable<ContaCorrente> List(ContaCorrente cc);
         ContaCorrente Select(int numContaCorrente);
    }
}