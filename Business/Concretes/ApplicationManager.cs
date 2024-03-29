﻿

using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Applications;
using Business.Responses.Applications;
using Business.Rules;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;
         private readonly ApplicantBusinessRules _rules;
        private readonly IBlacklistRepository _blacklistRepository;

        public ApplicationManager(IApplicationRepository applicationRepository, IMapper mapper, ApplicantBusinessRules rules, IBlacklistRepository blacklistRepository)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
            _rules = rules;
            _blacklistRepository = blacklistRepository;
        }

        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<CreatedApplicationResponse>> AddAsync(CreateApplicationRequest request)
        {
            await _rules.CheckIdIfNotExist(request.ApplicantId);

            Application application = _mapper.Map<Application>(request);
            await _applicationRepository.AddAsync(application);
            CreatedApplicationResponse response = _mapper.Map<CreatedApplicationResponse>(application);
            return new SuccessDataResult<CreatedApplicationResponse>(response, ApplicationMessages.ApplicationAdded);
        }

         [LogAspect(typeof(MongoDbLogger))]
        public async Task<IResult> DeleteAsync(DeleteApplicationRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);

            var item = await _applicationRepository.GetAsync(x => x.Id == request.Id);
            await _applicationRepository.DeleteAsync(item);

            return new SuccessResult(ApplicationMessages.ApplicationDeleted);
        }

        public async Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync()
        {
            var list = await _applicationRepository.GetAllAsync();
            List<GetAllApplicationResponse> response = _mapper.Map<List<GetAllApplicationResponse>>(list);
            return new SuccessDataResult<List<GetAllApplicationResponse>>(response, ApplicationMessages.ApplicationListed);
        }

        public async Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id)
        {
            await _rules.CheckIdIfNotExist(id);

            var item = await _applicationRepository.GetAsync(x => x.Id == id);

            GetByIdApplicationResponse response = _mapper.Map<GetByIdApplicationResponse>(item);
            return new SuccessDataResult<GetByIdApplicationResponse>(response, ApplicationMessages.ApplicationFound);


        }

        [LogAspect(typeof(MongoDbLogger))]

        public async Task<IDataResult<UpdatedApplicationResponse>> UpdateAsync(UpdateApplicationRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);

            var item = await _applicationRepository.GetAsync(p => p.Id == request.Id);

            _mapper.Map(request, item);
            await _applicationRepository.UpdateAsync(item);

            UpdatedApplicationResponse response = _mapper.Map<UpdatedApplicationResponse>(item);
            return new SuccessDataResult<UpdatedApplicationResponse>(response, ApplicationMessages.ApplicationUpdated);
        }
    }
}