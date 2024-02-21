using Business.Requests.Instructors;
using Business.Responses.Instructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstratcs
{
    public interface IInstructorService
    {
        Task<List<GetAllInstructorResponse>> GetAll();
        Task<GetByIdInstructorResponse> GetById(int id);
        Task<CreateInstructorResponse> AddAsync(CreateInstructorRequest request);
        Task<DeleteInstructorResponse> DeleteAsync(DeleteInstructorRequest request);
        Task<UpdateInstructorResponse> UpdateAsync(UpdateInstructorRequest request);
    }
}