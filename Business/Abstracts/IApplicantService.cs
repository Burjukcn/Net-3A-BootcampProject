using Business.Requests.Applicants;
using Business.Responses.Applicants;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{

    public interface IApplicantService
    {

        Task<IDataResult<CreateApplicantResponse>> AddAsync(CreateApplicantRequest request);
        Task<IDataResult<UpdateApplicantResponse>> UpdateAsync(UpdateApplicantRequest request);
        Task<IResult> DeleteAsync(DeleteApplicantRequest request);
        Task<IDataResult<List<GetAllApplicantResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdApplicantResponse>> GetByIdAsync(int id);
    }


}
