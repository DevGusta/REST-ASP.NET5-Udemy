using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_ASP.NET5_Udemy.Model;
using REST_ASP.NET5_Udemy.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;
        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personBusiness.ListaPessoas());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _personBusiness.AcharId(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_personBusiness.Criar(pessoa));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Person pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_personBusiness.Atualizar(pessoa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Deletar(id);
          
            return NoContent();
        }

    }
}
