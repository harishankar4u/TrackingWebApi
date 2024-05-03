using MediatR;
using TrackingApi.infrastructure.Request;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.infrastructure.Command
{
    public record CreateEmployeeCommand(CreateEmployeeRequest value):IRequest<bool>;
    public record UpdateEmployeeCommand(UpdateEmployeeRequest value):IRequest<bool>;
    public record DeleteEmployeCommand(int id):IRequest<bool>;
}
