using MediatRValidationPipeline.WebApi.Features.CustomerOrderFeatures.Command;
using FluentValidation; 

namespace MediatRValidationPipeline.WebApi.Validation
{
    public class CreateCustomerOrderCommandValidator: AbstractValidator<CreateCustomerOrderCommand>
    {
        public CreateCustomerOrderCommandValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty().WithMessage("Customer Id must not be or zero.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("Product Id must not be or zero."); ;
        }
    }
}
