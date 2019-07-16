using DomainModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace N1CoreProject.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public PessoaController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        //[HttpGet("Pessoa/ObterListaPessoa")]
        [ProducesResponseType(typeof(IEnumerable<Pessoa>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dataAccessProvider.GetListaPessoaAsync());
        }
    }
}
