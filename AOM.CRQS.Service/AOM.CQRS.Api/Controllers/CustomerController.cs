using AOM.CQRS.Api.Handlers;
using Microsoft.AspNetCore.Mvc;
using AOM.CQRS.Api.Commands.Requests;
using AOM.CQRS.Api.Queries.Requests;
using MediatR;

namespace AOM.CQRS.Api.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public IActionResult GetById([FromServices]IMediator mediator,[FromQuery]FindCustomerByIdRequest command)
        {
            var result = mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create([FromServices]IMediator mediator,[FromBody]CreateCustomerRequest command)
        {
            var response = mediator.Send(command);
            return Ok(response);
        }
    }
}