using AOM.CQRS.Api.Commands.Requests;
using AOM.CQRS.Api.Commands.Responses;

namespace AOM.CQRS.Api.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}
