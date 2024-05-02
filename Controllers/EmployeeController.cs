using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackingApi.Data.Entity;
using TrackingApi.infrastructure.Query;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IMediator mediator, ILogger<EmployeeController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<EmployeeResponse> get(int id)
        {
            var resp=await _mediator.Send(new GetbyidQuery(id));
            return resp;
        }
    }
}
