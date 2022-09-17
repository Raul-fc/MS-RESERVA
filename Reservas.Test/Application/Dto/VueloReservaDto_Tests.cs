using Reservas.Application.Dto.Reserva;
using System;
using Xunit;

namespace Reservas.Test.Application.Dto {
	public class VueloReservaDto_Tests {
		[Fact]
		public void DetallePedidoDto_CheckPropertiesValid() {
			var idPasajeroTest = "juan perez";
			decimal costoTest = new(450.0);

			var vueloReserva = new VueloReservaDto();

			Assert.NotNull(vueloReserva.Pasajero);
			Assert.Equal(new decimal(0.0), vueloReserva.Costo);

			vueloReserva.Pasajero = idPasajeroTest;
			vueloReserva.Costo = costoTest;


			Assert.Equal(idPasajeroTest, vueloReserva.Pasajero);
			Assert.Equal(costoTest, vueloReserva.Costo);
		}

	}
}
