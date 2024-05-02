using TrackingApi.Data.Entity;
using TrackingApi.Data.Manager;
using TrackingApi.infrastructure.Query;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.Data.contract
{
    public interface IEmployee
    {
         Task<EmployeeResponse> GetByIdAsync(int id);
    }
}
