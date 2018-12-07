using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Domain.Services;

namespace SoftplayerCalcTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        ICalculoJurosService _calculoJurosService;

        public JurosController(ICalculoJurosService calculoJurosService)
        {
            if (calculoJurosService == null)
                throw new ArgumentNullException(nameof(calculoJurosService));

            _calculoJurosService = calculoJurosService;
        }

        [HttpGet("calculajuros")]
        public IActionResult Calcular(double valorInicial, int tempoEmMeses)
        {
            var calculo = _calculoJurosService.Calcular(valorInicial, tempoEmMeses);

            if (calculo == null)
                return BadRequest("Não foi possível efetuar o cálculo.");

            return Ok();
        }
    }
}