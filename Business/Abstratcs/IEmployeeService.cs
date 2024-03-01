using Business.Requests.Employees;
using Business.Responses.Employees;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstratcs
{
    public interface IEmployeeService
    {

        Task<List<GetAllEmployeeResponse>> GetAll();
        Task<GetByIdEmployeeResponse> GetById(int id);
        Task<CreateEmployeeResponse> AddAsync(CreateEmployeeRequest request);
        Task<DeleteEmployeeResponse> DeleteAsync(DeleteEmployeeRequest request);
        Task<UpdateEmployeeResponse> UpdateAsync(UpdateEmployeeRequest request);
    }
}