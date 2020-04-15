using System;
using AOM.CQRS.Api.Entities;
using AOM.CQRS.Api.Queries.Responses;
using AOM.CQRS.Api.Repository.Interfaces;

namespace AOM.CQRS.Api.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public FindCustomerByIdResponse GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
