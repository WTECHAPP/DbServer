using System.Collections.Generic;
using System.Threading.Tasks;
using contaCorrente.Domain.Models;

namespace contaCorrente.Domain.Repositories
{
    public interface IContaCorrenteRepository
    {
         int Add(ContaCorrente cc);
         IEnumerable<ContaCorrente> List(ContaCorrente cc);
         ContaCorrente Select(int numContaCorrente);
    }
}