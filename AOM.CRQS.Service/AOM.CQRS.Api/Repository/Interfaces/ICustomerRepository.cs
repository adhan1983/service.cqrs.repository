using AOM.CQRS.Api.Entities;
using AOM.CQRS.Api.Queries.Responses;
using System;

namespace AOM.CQRS.Api.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        FindCustomerByIdResponse GetCustomerById(Guid id);
    }
}
