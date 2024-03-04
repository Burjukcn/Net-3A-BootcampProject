using Business.Requests.Applications;
using Business.Responses.Applications;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstratcs
{
    public interface IApplicationService
    {
        Task<IDataResult<CreatedApplicationResponse>> AddAsync(CreateApplicationRequest request);
        Task<IDataResult<UpdatedApplicationResponse>> UpdateAsync(UpdateApplicationRequest request);
        Task<IResult> DeleteAsync(DeleteApplicationRequest request);
        Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id);
    }
}
