using Business.Requests.ApplicationStates;
using Business.Responses.ApplicationStates;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationStateService
    {
        Task<IDataResult<CreatedApplicationStateResponse>> AddAsync(CreateApplicationStateRequest request);
        Task<IDataResult<UpdatedApplicationStateResponse>> UpdateAsync(UpdateApplicationStateRequest request);
        Task<IResult> DeleteAsync(DeleteApplicationStateRequest request);
        Task<IDataResult<List<GetAllApplicationStateResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdApplicationStateResponse>> GetByIdAsync(int id);
    }
}