using Business.Requests.Employees;
using Business.Responses.Employees;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEmployeeService
    {

        Task<IDataResult<CreateEmployeeResponse>> AddAsync(CreateEmployeeRequest request);
        Task<IDataResult<UpdateEmployeeResponse>> UpdateAsync(UpdateEmployeeRequest request);
        Task<IResult> DeleteAsync(DeleteEmployeeRequest request);
        Task<IDataResult<List<GetAllEmployeeResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdEmployeeResponse>> GetByIdAsync(int id);
    }
}