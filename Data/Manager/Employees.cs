using AutoMapper;
using Dapper;
using System.Data;
using TrackingApi.Data.contract;
using TrackingApi.Data.Entity;
using TrackingApi.infrastructure.Request;
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

        public async Task<bool> CreateEmployee(CreateEmployeeRequest createEmployee)
        {
            var query = "";
            var param = new DynamicParameters();
            param.Add("age", createEmployee.age);
            param.Add("name", createEmployee.name);
            param.Add("disp", createEmployee.department);
            return await _dbConnection.QuerySingleAsync<bool>(query, param, commandType: CommandType.StoredProcedure);
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var query = "";
            var param = new DynamicParameters();
            param.Add("id", id);
            return await _dbConnection.QuerySingleAsync<bool>(query, param, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<EmployeeResponse>> GetByAllAsync()
        {
            var query = "";
            var param = new DynamicParameters();
            var resp = await _dbConnection.QueryAsync<EmployeeEnt>(query, param, commandType: CommandType.StoredProcedure);
            return _mapper.Map<IEnumerable<EmployeeResponse>>(resp);
            
        }
        public async Task<bool> UpdateEmployee(UpdateEmployeeRequest updateEmployee)
        {
            var query = "";
            var param = new DynamicParameters();
            param.Add("id", updateEmployee.id);
            param.Add("age", updateEmployee.age);
            param.Add("name", updateEmployee.name);
            param.Add("disp", updateEmployee.department);
            return await _dbConnection.QuerySingleAsync<bool>(query,param, commandType: CommandType.StoredProcedure);
        }
    }
}
