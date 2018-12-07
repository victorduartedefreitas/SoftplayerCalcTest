using SoftplayerCalcTest.Domain.Models;

namespace SoftplayerCalcTest.Domain.Services
{
    public interface ICalculoJurosService
    {
        ResultadoCalculoJuros Calcular(double valorInicial, int tempoFinanciamentoMeses);
    }
}
