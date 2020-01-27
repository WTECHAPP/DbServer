using System.Collections.Generic;
using contaCorrente.Domain.Models;
using contaCorrente.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace contaCorrente.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteService _contaCorrenteService;

        public ContaCorrenteController(IContaCorrenteService contaCorrenteService)
        {
            _contaCorrenteService = contaCorrenteService;
        }

        [HttpPost, Route("add")]
        public int Add([FromBody] ContaCorrente cc)
        {
            return _contaCorrenteService.Add(cc);
        }

        [HttpPost, Route("list")]
        public IEnumerable<ContaCorrente> List([FromBody] ContaCorrente cc)
        {
            return _contaCorrenteService.List(cc);
        }

        [HttpGet, Route("select/ccNumber")]
        public ContaCorrente Select(int numContaCorrente)
        {
            return _contaCorrenteService.Select(numContaCorrente);
        }
    }
}