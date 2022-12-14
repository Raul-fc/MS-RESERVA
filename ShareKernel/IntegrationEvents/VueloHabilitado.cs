using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharedkernel.IntegrationEvents {
	public record VueloHabilitado : IntegrationEvent {
		public DateTime horaSalida { get; set; }
		public DateTime horaLLegada { get; set; }
		public string estado { get; set; }
		public decimal precio { get; set; }
		public DateTime fecha { get; set; }
		public Guid codRuta { get; set; }
		public Guid codDestino { get; set; }
		public Guid codOrigen { get; set; }
		public Guid codAeronave { get; set; }
		public int activo { get; set; }
		public int stockAsientos { get; set; }

		public Guid vueloId { get; set; }
	}
}
