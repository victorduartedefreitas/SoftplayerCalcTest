namespace SoftplayerCalcTest.Domain.Models
{
    public class ResultadoCalculoJuros
    {
        public ResultadoCalculoJuros(decimal valorInicial, decimal valorFinal, double juros, int tempoEmMeses)
        {
            ValorInicial = valorInicial;
            ValorFinal = valorFinal;
            Juros = juros;
            TempoEmMeses = tempoEmMeses;
        }

        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public double Juros { get; set; }
        public int TempoEmMeses { get; set; }
    }
}
