using AOM.CQRS.Api.Queries.Responses;
using MediatR;
using System;

namespace AOM.CQRS.Api.Queries.Requests
{
    public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}
