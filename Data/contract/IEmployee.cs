using TrackingApi.infrastructure.Request;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.Data.contract
{
    public interface IEmployee
    {
        Task<EmployeeResponse> GetByIdAsync(int id);
        Task<IEnumerable<EmployeeResponse>> GetByAllAsync();
        Task<bool> CreateEmployee(CreateEmployeeRequest createEmployee);
        Task<bool> UpdateEmployee(UpdateEmployeeRequest updateEmployee);
        Task<bool> DeleteEmployeeAsync(int id);
    }
}
