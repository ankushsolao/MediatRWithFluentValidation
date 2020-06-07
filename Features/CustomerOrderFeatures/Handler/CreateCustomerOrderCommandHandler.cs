using MediatR;
using MediatRValidationPipeline.WebApi.Context;
using MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Command;
using MediatRValidationPipeline.WebApi.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Handler
{
    public class CreateCustomerOrderCommandHandler : IRequestHandler<CreateCustomerOrderCommand, int>
    {
        private readonly IApplicationContext _context;
        public CreateCustomerOrderCommandHandler(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateCustomerOrderCommand command, CancellationToken cancellationToken)
        {
            var customerOrder = new CustomerOrder();
            customerOrder.CustomerId = command.CustomerId;
            customerOrder.ProductId = command.ProductId;
            customerOrder.OrderDetails = command.OrderDetails;
            customerOrder.TotalAmount = command.TotalAmount;
            _context.CustomerOrders.Add(customerOrder);
            await _context.SaveChanges();
            return customerOrder.Id;
        }
    }
}
