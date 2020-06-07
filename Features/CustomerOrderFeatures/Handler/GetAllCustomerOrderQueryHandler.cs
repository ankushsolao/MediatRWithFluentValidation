using MediatR;
using MediatRValidationPipeline.WebApi.Context;
using MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Queries;
using MediatRValidationPipeline.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Handler
{
    public class GetAllCustomerOrderQueryHandler : IRequestHandler<GetAllCustomerOrderQuery, IEnumerable<CustomerOrder>>
    {
        private readonly IApplicationContext _context;
        public GetAllCustomerOrderQueryHandler(IApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerOrder>> Handle(GetAllCustomerOrderQuery request, CancellationToken cancellationToken)
        {
            var productList = await _context.CustomerOrders.ToListAsync();
            if (productList == null)
            {
                return null;
            }
            return productList.AsReadOnly();
        }
    }
}
