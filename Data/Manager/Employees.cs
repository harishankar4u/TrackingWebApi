using AutoMapper;
using Dapper;
using System.Data;
using TrackingApi.Data.contract;
using TrackingApi.Data.Entity;
using TrackingApi.infrastructure.Response;

namespace TrackingApi.Data.Manager
{
    public class Employees : IEmployee
    {
        private readonly IDbConnection _dbConnection;
        private readonly IMapper _mapper;
        public Employees(IDbConnection dbConnection, IMapper mapper)
        {
            _dbConnection = dbConnection;
            _mapper = mapper;
        }
        public async Task<EmployeeResponse> GetByIdAsync(int id)
        {
            var query = "sp_GetEmployeById";
            var param = new DynamicParameters();
            param.Add("Id", id);
            var resp= await _dbConnection.QuerySingleAsync<EmployeeEnt>(query, param, commandType: CommandType.StoredProcedure);
            return _mapper.Map<EmployeeResponse>(resp);
        }
    }
}
