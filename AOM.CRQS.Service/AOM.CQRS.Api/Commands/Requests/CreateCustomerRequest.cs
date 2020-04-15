using AOM.CQRS.Api.Commands.Responses;
using MediatR;

namespace AOM.CQRS.Api.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
