using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_ASP.NET5_Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Soma(string primeiroNumero, string segundoNumero)
        {
            if(EhNumero(primeiroNumero) && EhNumero(segundoNumero)) 
            {
                var soma = ConverteDecimal(primeiroNumero) + ConverteDecimal(segundoNumero);
                return Ok(soma.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("sub/{primeiroNumero}/{segundoNumero}")]

        public IActionResult Sub(string primeiroNumero, string segundoNumero) 
        {
            if (EhNumero(primeiroNumero) && EhNumero(segundoNumero))
            {
                var sub = ConverteDecimal(primeiroNumero) - ConverteDecimal(segundoNumero);
                return Ok(sub.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("mul/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Mul(string primeiroNumero, string segundoNumero) 
        {
            if (EhNumero(primeiroNumero) && EhNumero(segundoNumero))
            {
                var mul = ConverteDecimal(primeiroNumero) * ConverteDecimal(segundoNumero);
                return Ok(mul.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("div/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Div(string primeiroNumero, string segundoNumero) 
        {
            if (EhNumero(primeiroNumero) && EhNumero(segundoNumero))
            {
                var div = ConverteDecimal(primeiroNumero) / ConverteDecimal(segundoNumero);
                return Ok(div.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("media/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Media(string primeiroNumero, string segundoNumero) 
        {
            if (EhNumero(primeiroNumero) && EhNumero(segundoNumero))
            {
                var media = (ConverteDecimal(primeiroNumero) + ConverteDecimal(segundoNumero))/2;
                return Ok(media.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("raiz/{numero}")]
        public IActionResult Raiz(string numero) 
        {
            if (EhNumero(numero))
            {
                var raiz = Math.Sqrt((double)ConverteDecimal(numero));
                return Ok(raiz.ToString());
            }

            return BadRequest("Entrada Invalida");
        }


        private bool EhNumero(string strNumber)
        {
            double numero;
            bool ehNumero = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numero) ;
            return ehNumero;

        }

        private decimal ConverteDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;

        }
    }
}
