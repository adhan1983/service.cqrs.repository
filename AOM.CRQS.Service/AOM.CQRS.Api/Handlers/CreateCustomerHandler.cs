using System;
using AOM.CQRS.Api.Entities;
using AOM.CQRS.Api.Commands.Requests;
using AOM.CQRS.Api.Services.Interfaces;
using AOM.CQRS.Api.Commands.Responses;
using AOM.CQRS.Api.Repository.Interfaces;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace AOM.CQRS.Api.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        ICustomerRepository _repository;
        IEmailService _emailService;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest command, CancellationToken cancellationToken)
        {
            // Aplicar Fail Fast Validations
            
            var customer = new Customer(command.Name, command.Email);
            
            _repository.Save(customer);
            
            _emailService.Send(customer.Name, customer.Email);
            
            var result =  new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);

        }
    }
}
