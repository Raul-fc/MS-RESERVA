/*
using MassTransit;
using MediatR;
using ShareKernel.IntegrationEvents;
using System;
using System.Threading.Tasks;
*/
namespace Reservas.Application.UseCases.Consumers {
	public class CheckinConfirmadoConsumer {
		/*
		 : IConsumer<CheckinConfirmado>
		private readonly IMediator _mediator;
		public const string ExchangeName = "checking-confirmado-exchange";
		public const string QueueName = "checking-confirmado-checking";

		public CheckinConfirmadoConsumer(IMediator mediator) {
			_mediator = mediator;
		}

		public async Task Consume(ConsumeContext<CheckinConfirmado> context) {
			CheckinConfirmado @event = context.Message;
			CrearProductoCommand command = new CrearProductoCommand(@event.ArticuloId, 0, @event.PrecioVenta, @event.Nombre);
			await _mediator.Send(command);
		}
		*/
	}
}
