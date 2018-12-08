using SoftplayerCalcTest.Domain.Models;
using SoftplayerCalcTest.Domain.Services;
using System;

namespace SoftplayerCalcTest.Application.Services
{
    public class CalculoPadraoJurosService : ICalculoJurosService
    {
        public ResultadoCalculoJuros Calcular(double valorInicial, int tempoFinanciamentoMeses)
        {
            var juros = 0.01d;
            decimal valorFinal = Convert.ToDecimal(valorInicial * Math.Pow(1 + juros, tempoFinanciamentoMeses)).CustomTruncate();

            return new ResultadoCalculoJuros(Convert.ToDecimal(valorInicial),
                valorFinal,
                juros,
                tempoFinanciamentoMeses);
        }
    }
}
