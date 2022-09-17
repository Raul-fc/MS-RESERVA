using System.Threading.Tasks;

namespace Reservas.Application.Service.Interface {
	public interface IAsientoService {
		Task<bool> ExiteAsientosDisponible();
	}
}
