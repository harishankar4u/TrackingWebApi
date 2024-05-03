using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackingApi.infrastructure.Command;
using TrackingApi.infrastructure.Query;
using TrackingApi.infrastructure.Request;
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
        [Route("GetById")]
        public async Task<EmployeeResponse> get(int id)
        {
            var resp=await _mediator.Send(new GetbyidQuery(id));
            return resp;
        }
        [HttpGet]
        [Route("GetAllEmp")]
        public async Task<IEnumerable<EmployeeResponse>> GetAll()
        {
            var resp=await _mediator.Send(new GetAllEmployeeQuery());
            return resp;
        }
        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<bool> create(CreateEmployeeRequest value)
        {
            var resp = await _mediator.Send(new CreateEmployeeCommand(value));
            return resp;
        }
        [HttpPut]
        [Route("Update")]
        public async Task<bool> Update(UpdateEmployeeRequest value)
        {
            var resp=await _mediator.Send(new  UpdateEmployeeCommand(value));
            return resp;
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<bool> Delete(int id)
        {
            var resp=await _mediator.Send(new DeleteEmployeCommand(id));
            return resp;
        }
    }
}
