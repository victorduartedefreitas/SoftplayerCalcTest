namespace System
{
    public static class DecimalExtensions
    {
        public static decimal CustomTruncate(this decimal valor)
        {
            return Convert.ToDecimal(valor.ToString("0.00"));
        }
    }
}
