using Reservas.Domain.Model.Asientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Factories {
	public class AsientoFactory : IAsientoFactory {
		public Asiento Create(string asiento, Guid avionId, Guid vueloId) {
			return new Asiento(asiento, avionId, vueloId);
		}
	}
}
