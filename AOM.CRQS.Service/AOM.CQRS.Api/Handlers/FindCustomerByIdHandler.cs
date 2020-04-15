using AOM.CQRS.Api.Queries.Requests;
using AOM.CQRS.Api.Queries.Responses;
using AOM.CQRS.Api.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AOM.CQRS.Api.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;
        public FindCustomerByIdHandler(ICustomerRepository repository)
        => _repository = repository;
        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            // TODO: Lógica de leitura se houver
            
            var result = _repository.GetCustomerById(request.Id);

            return Task.FromResult(result);
        }
    }
}
