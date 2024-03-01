using Business.Requests.Applicants;
using Business.Responses.Applicants;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstratcs
{

    public interface IApplicantService
    {

        Task<List<GetAllApplicantResponse>> GetAll();
        Task<GetByIdApplicantResponse> GetById(int id);
        Task<CreateApplicantResponse> AddAsync(CreateApplicantRequest request);
        Task<DeleteApplicantResponse> DeleteAsync(DeleteApplicantRequest request);
        Task<UpdateApplicantResponse> UpdateAsync(UpdateApplicantRequest request);
    }


}
