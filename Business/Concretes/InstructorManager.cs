using Business.Abstratcs;
using Business.Requests.Instructors;
using Business.Responses.Instructors;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService

    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorManager(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        public async Task<List<GetAllInstructorResponse>> GetAll()
        {
            List<GetAllInstructorResponse> instructors = new List<GetAllInstructorResponse>();
            foreach (var instructor in await _instructorRepository.GetAllAsync())
            {
                GetAllInstructorResponse response = new();
                response.Id = instructor.Id;
                response.CompanyName = instructor.CompanyName;
                instructors.Add(response);
            }
            return instructors;
        }

        public async Task<GetByIdInstructorResponse> GetById(int id)
        {
            GetByIdInstructorResponse response = new();
            Instructor instructor = await _instructorRepository.GetAsync(x => x.Id == id);
            response.Id = instructor.Id;
            response.CompanyName = instructor.CompanyName;
            return response;
        }

        public async Task<CreateInstructorResponse> AddAsync(CreateInstructorRequest request)
        {
            Instructor instructor = new();
            instructor.UserName = request.UserName;
            instructor.Password = request.Password;
            instructor.Email = request.Email;
            instructor.DateOfBirth = request.DateOfBirth;
            instructor.FirstName = request.FirstName;
            instructor.LastName = request.LastName;
            instructor.NationalIdentity = request.NationalIdentity;
            instructor.CompanyName = request.CompanyName;
            await _instructorRepository.AddAsync(instructor);

            CreateInstructorResponse response = new();
            response.Id = instructor.Id;
            response.CompanyName = instructor.CompanyName;
            response.CreatedDate = instructor.CreatedDate;
            return response;
        }

        public async Task<DeleteInstructorResponse> DeleteAsync(DeleteInstructorRequest request)
        {
            Instructor instructor = await _instructorRepository.GetAsync(x => x.Id == request.Id);
            instructor.Id = request.Id;
            await _instructorRepository.DeleteAsync(instructor);

            DeleteInstructorResponse response = new();
            response.Id = instructor.Id;
            response.DeletedDate = instructor.DeletedDate;
            return response;
        }

        public async Task<UpdateInstructorResponse> UpdateAsync(UpdateInstructorRequest request)
        {
            Instructor instructor = await _instructorRepository.GetAsync(x => x.Id == request.Id);
            instructor.Id = request.Id;
            instructor.CompanyName = request.CompanyName;
            instructor.UserName = request.UserName;
            instructor.LastName = request.LastName;
            instructor.FirstName = request.FirstName;
            instructor.DateOfBirth = request.DateOfBirth;
            instructor.Email = request.Email;
            instructor.NationalIdentity = request.NationalIdentity;
            instructor.Password = request.Password;
            await _instructorRepository.UpdateAsync(instructor);

            UpdateInstructorResponse response = new();
            response.Id = instructor.Id;
            response.CompanyName = instructor.CompanyName;
            response.UserName = instructor.UserName;
            response.Password = instructor.Password;
            response.NationalIdentity = instructor.NationalIdentity;
            response.LastName = instructor.LastName;
            response.FirstName = instructor.FirstName;
            response.DateOfBirth = instructor.DateOfBirth;
            response.Email = instructor.Email;
            response.UpdatedDate = instructor.UpdatedDate;
            return response;
        }
    }
}