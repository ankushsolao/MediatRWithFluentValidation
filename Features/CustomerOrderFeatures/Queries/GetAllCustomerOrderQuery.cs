using MediatR;
using MediatRValidationPipeline.WebApi.Models;
using System.Collections.Generic;

namespace MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Queries
{
    public class GetAllCustomerOrderQuery : IRequest<IEnumerable<CustomerOrder>>
    {

    }
}
