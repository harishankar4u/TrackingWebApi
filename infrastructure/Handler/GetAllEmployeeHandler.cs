using MediatR;
using TrackingApi.Data.contract;
using TrackingApi.infrastructure.Query;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.infrastructure.Handler
{
    public class GetAllEmployeeHandler:IRequestHandler<GetAllEmployeeQuery,IEnumerable<EmployeeResponse>>
    {
        private readonly IEmployee _employee;
        public GetAllEmployeeHandler(IEmployee employee)
        {
            _employee = employee;
        }
        public async Task<IEnumerable<EmployeeResponse>>Handle(GetAllEmployeeQuery request,CancellationToken cancellationToken)
        {
            var resp =await _employee.GetByAllAsync();
            return resp;
        }
    }
}
