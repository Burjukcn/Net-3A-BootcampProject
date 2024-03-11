using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<IDataResult<CreateInstructorResponse>> AddAsync(CreateInstructorRequest request);
        Task<IDataResult<UpdateInstructorResponse>> UpdateAsync(UpdateInstructorRequest request);
        Task<IResult> DeleteAsync(DeleteInstructorRequest request);
        Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdInstructorResponse>> GetByIdAsync(int id);
    }
}