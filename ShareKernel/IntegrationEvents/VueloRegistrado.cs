using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharedkernel.IntegrationEvents {
	public class VueloRegistrado {
		public Guid VueloId { get; set; }
		public Guid AvionId { get; set; }
		public int NroAsiento { get; set; }
	}
}
