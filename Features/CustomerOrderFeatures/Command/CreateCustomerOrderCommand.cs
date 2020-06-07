using MediatR;

namespace MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Command
{
    public class CreateCustomerOrderCommand : IRequest<int>
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string OrderDetails { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
