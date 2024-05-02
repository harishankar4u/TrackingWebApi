using MediatR;
using TrackingApi.Data.Entity;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.infrastructure.Query
{
    public record GetbyidQuery(int id):IRequest<EmployeeResponse>;
}
