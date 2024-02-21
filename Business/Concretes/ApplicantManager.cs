using Business.Abstratcs;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;
        public ApplicantManager(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public async Task<List<GetAllApplicantResponse>> GetAll()
        {
            List<GetAllApplicantResponse> applicants = new List<GetAllApplicantResponse>();
            foreach (var applicant in await _applicantRepository.GetAllAsync())
            {
                GetAllApplicantResponse response = new();

                response.Id = applicant.Id;
                response.About = applicant.About;
                applicants.Add(response);
            }
            return applicants;
        }

        public async Task<GetByIdApplicantResponse> GetById(int id)
        {
            GetByIdApplicantResponse response = new();
            Applicant applicant = await _applicantRepository.GetAsync(x => x.Id == id);
            response.Id = applicant.Id;
            response.About = applicant.About;
            return response;
        }

        public async Task<CreateApplicantResponse> AddAsync(CreateApplicantRequest request)
        {
            Applicant applicant = new();

            applicant.UserName = request.UserName;
            applicant.Password = request.Password;
            applicant.Email = request.Email;
            applicant.DateOfBirth = request.DateOfBirth;
            applicant.NationalIdentity = request.NationalIdentity;
            applicant.FirstName = request.FirstName;
            applicant.LastName = request.LastName;
            applicant.About = request.About;

            await _applicantRepository.AddAsync(applicant);

            CreateApplicantResponse response = new();
            response.Id = applicant.Id;
            response.About = applicant.About;
            response.CreatedDate = applicant.CreatedDate;
            return response;
        }

        public async Task<DeleteApplicantResponse> DeleteAsync(DeleteApplicantRequest request)
        {
            Applicant applicant = await _applicantRepository.GetAsync(x => x.Id == request.Id);

            applicant.Id = request.Id;
            await _applicantRepository.DeleteAsync(applicant);

            DeleteApplicantResponse response = new DeleteApplicantResponse();

            response.Id = applicant.Id;
            response.DeletedDate = applicant.DeletedDate;
            return response;
        }

        public async Task<UpdateApplicantResponse> UpdateAsync(UpdateApplicantRequest request)
        {
            Applicant applicant = await _applicantRepository.GetAsync(x => x.Id == request.Id);
            applicant.Id = request.Id;
            applicant.UserName = request.UserName;
            applicant.Password = request.Password;
            applicant.Email = request.Email;
            applicant.DateOfBirth = request.DateOfBirth;
            applicant.NationalIdentity = request.NationalIdentity;
            applicant.FirstName = request.FirstName;
            applicant.LastName = request.LastName;
            applicant.About = request.About;
            await _applicantRepository.UpdateAsync(applicant);

            UpdateApplicantResponse response = new UpdateApplicantResponse();
            response.Id = applicant.Id;
            response.UserName = applicant.UserName;
            response.FirstName = applicant.FirstName;
            response.LastName = applicant.LastName;
            response.DateOfBirth = applicant.DateOfBirth;
            response.NationalIdentity = applicant.NationalIdentity;
            response.Email = applicant.Email;
            response.Password = applicant.Password;
            response.About = applicant.About;
            response.UpdatedDate = applicant.UpdatedDate;
            return response;
        }
    }

}