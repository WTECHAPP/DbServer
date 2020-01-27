using System.Collections.Generic;
using contaCorrente.Domain.Models;
using contaCorrente.Domain.Repositories;
using contaCorrente.Domain.Services;

namespace contaCorrente.Services
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public ContaCorrenteService(IContaCorrenteRepository contaCorrenteRepository)
        {
            this._contaCorrenteRepository = contaCorrenteRepository;
        }

        public int Add(ContaCorrente cc){
            return _contaCorrenteRepository.Add(cc);
        }
         public IEnumerable<ContaCorrente> List(ContaCorrente cc){
             return _contaCorrenteRepository.List(cc);
         }
        public ContaCorrente Select(int numContaCorrente){
            return _contaCorrenteRepository.Select(numContaCorrente);
        }
    }
}