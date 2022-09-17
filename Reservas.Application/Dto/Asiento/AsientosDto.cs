using System;
using System.Collections.Generic;

namespace Reservas.Application.Dto.Asiento {
	public class AsientosDto {
		public Guid Id { get; set; }
		public Guid VueloId { get; set; }
		public string NroAsiento { get; set; }
		/*
		public ICollection<AsientoDto> Asientos { get; set; }
		public AsientosDto() {
			Asientos = new List<AsientoDto>();
		}
		*/
	}
}
