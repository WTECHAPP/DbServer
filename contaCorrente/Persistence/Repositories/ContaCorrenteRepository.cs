using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using contaCorrente.Domain.Models;
using contaCorrente.Domain.Repositories;
using contaCorrente.Persistence.Contexts;
using Microsoft.Extensions.Configuration;

namespace contaCorrente.Persistence.Repositories
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private readonly IConfiguration _configuration;
        public ContaCorrenteRepository(IConfiguration configuration)
        { 
            _configuration = configuration;
        }

        public int Add(ContaCorrente cc){
            int idContaCorrente = 0;
            try {
                using (var context = new AppDbContext()){
                    context.ContaCorrente.Add(cc);
                    idContaCorrente = context.SaveChanges();
                }
                return idContaCorrente;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return idContaCorrente;
            }
        }

        public IEnumerable<ContaCorrente> List(ContaCorrente cc){
            return null;
        }
        
        public ContaCorrente Select(int numContaCorrente){
            ContaCorrente cc = new ContaCorrente();

            return cc;
        }
    }
}