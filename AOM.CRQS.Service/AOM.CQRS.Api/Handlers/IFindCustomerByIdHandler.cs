using AOM.CQRS.Api.Queries.Requests;
using AOM.CQRS.Api.Queries.Responses;

namespace AOM.CQRS.Api.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);

    }
}
