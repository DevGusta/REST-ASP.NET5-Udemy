using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_ASP.NET5_Udemy.Model;
using REST_ASP.NET5_Udemy.Services;
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
        private IPersonService _personService;
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personService.ListaPessoas());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _personService.AcharId(id);
            if (pessoa == null) return NotFound();
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_personService.Criar(pessoa));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Person pessoa)
        {
            if (pessoa == null) return BadRequest();
            return Ok(_personService.Atualizar(pessoa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Deletar(id);
          
            return NoContent();
        }

    }
}
