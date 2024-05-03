using MediatR;
using TrackingApi.Data.contract;
using TrackingApi.Data.Entity;
using TrackingApi.Data.Manager;
using TrackingApi.infrastructure.Query;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.infrastructure.Handler
{
    public class GetEmployeeHandler:IRequestHandler<GetbyidQuery, EmployeeResponse>
    {
        private readonly ILogger<GetEmployeeHandler> _logger;
        private readonly IEmployee _employee;
        public GetEmployeeHandler(ILogger<GetEmployeeHandler> logger, IEmployee employee)
        {
            _logger = logger;
            _employee = employee;
        }
        public async Task<EmployeeResponse> Handle(GetbyidQuery value, CancellationToken cancellationToken)
        {
            var response = await _employee.GetByIdAsync(value.id);
            return response;
        }
    }
}
