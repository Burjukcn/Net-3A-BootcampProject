using AutoMapper;
using Business.Abstratcs;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Business.Rules;
using Business.Constants;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {

        private readonly IApplicantRepository _applicantRepository;
        private readonly IMapper _mapper;
        private readonly ApplicantBusinessRules _rules;

        public ApplicantManager(IApplicantRepository applicantRepository, IMapper mapper, ApplicantBusinessRules rules)
        {
            _applicantRepository = applicantRepository;
            _mapper = mapper;
            _rules = rules;
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

        public async Task<IDataResult<List<GetAllApplicantResponse>>> GetAllAsync()
        {
            var list = await _applicantRepository.GetAllAsync();
            List<GetAllApplicantResponse> response = _mapper.Map<List<GetAllApplicantResponse>>(list);
            return new SuccessDataResult<List<GetAllApplicantResponse>>(response, ApplicantMessages.ApplicantListed);
        }

        public async Task<IDataResult<CreateApplicantResponse>> AddAsync(CreateApplicantRequest request)
        {
            await _rules.CheckUserNameIfExist(request.UserName, null);

            Applicant applicant = _mapper.Map<Applicant>(request);
            await _applicantRepository.AddAsync(applicant);
            CreateApplicantResponse response = _mapper.Map<CreateApplicantResponse>(applicant);
            return new SuccessDataResult<CreateApplicantResponse>(response, ApplicantMessages.ApplicantAdded);
        }

        public async Task<IResult> DeleteAsync(DeleteApplicantRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);

            var item = await _applicantRepository.GetAsync(p => p.Id == request.Id);
            await _applicantRepository.DeleteAsync(item);
            return new SuccessResult(ApplicantMessages.ApplicantDeleted);
        }

        public async Task<IDataResult<UpdateApplicantResponse>> UpdateAsync(UpdateApplicantRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);
            await _rules.CheckUserNameIfExist(request.UserName, request.Id);

            var item = await _applicantRepository.GetAsync(p => p.Id == request.Id);

            _mapper.Map(request, item);
            await _applicantRepository.UpdateAsync(item);

            UpdateApplicantResponse response = _mapper.Map<UpdateApplicantResponse>(item);
            return new SuccessDataResult<UpdateApplicantResponse>(response, ApplicantMessages.ApplicantUpdated);
        }


        public async Task<IDataResult<GetByIdApplicantResponse>> GetByIdAsync(int id)
        {
            await _rules.CheckIdIfNotExist(id);

            var item = await _applicantRepository.GetAsync(x => x.Id == id);

            GetByIdApplicantResponse response = _mapper.Map<GetByIdApplicantResponse>(item);

            return new SuccessDataResult<GetByIdApplicantResponse>(response, ApplicantMessages.ApplicantFound);

        }

      
    }

}