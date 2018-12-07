namespace System
{
    public static class DecimalExtensions
    {
        public static decimal CustomTruncate(this Decimal valor)
        {
            decimal valorIntegral,
                    fracao,
                    fator,
                    fracaoTruncada,
                    resultado;

            valorIntegral = decimal.Truncate(valor);
            fracao = valor = valorIntegral;
            fator = (decimal)Math.Pow(10, 2);
            fracaoTruncada = Math.Truncate(fracao * fator) / fator;
            resultado = valorIntegral + fracaoTruncada;

            return resultado;
        }
    }
}
