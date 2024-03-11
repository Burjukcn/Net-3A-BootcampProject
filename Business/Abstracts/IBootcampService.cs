using Business.Requests.Bootcamps;
using Business.Responses.Bootcamps;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBootcampService
    {
         Task<IDataResult<CreatedBootcampResponse>> AddAsync(CreateBootcampRequest request);
         Task<IDataResult<UpdatedBootcampResponse>> UpdateAsync(UpdateBootcampRequest request);
         Task<IResult> DeleteAsync(DeleteBootcampRequest request);
         Task<IDataResult<List<GetAllBootcampResponse>>> GetAllAsync();
         Task<IDataResult<GetByIdBootcampResponse>> GetByIdAsync(int id);
    }
}