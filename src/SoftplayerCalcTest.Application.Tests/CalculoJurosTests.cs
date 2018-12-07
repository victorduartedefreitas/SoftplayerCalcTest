using Microsoft.Extensions.DependencyInjection;
using SoftplayerCalcTest.Domain.Services;
using System;
using Xunit;

namespace SoftplayerCalcTest.Application.Tests
{
    public class CalculoJurosTests
    {
        #region Variáveis Locais

        private IServiceProvider serviceProvider;

        #endregion

        #region Construtores

        public CalculoJurosTests()
        {
            var services = new ServiceCollection();

            services.AddSoftplayerServices();
            serviceProvider = services.BuildServiceProvider();
        }

        #endregion

        [Theory]
        [InlineData(100, 5)]
        public void Calcular(double valorInicial, int tempoEmMeses)
        {
            var calculoService = serviceProvider.GetService<ICalculoJurosService>();

            var calculo = calculoService.Calcular(valorInicial, tempoEmMeses);

            Assert.NotNull(calculo);
            if (valorInicial == 100 && tempoEmMeses == 5)
                Assert.True(calculo.ValorFinal == 105.10m);
        }
    }
}
