using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Employees;
using Business.Requests.Instructors;
using Business.Responses.Employees;
using Business.Responses.Instructors;
using Business.Rules;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
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
        private readonly IMapper _mapper;
        private readonly InstructorBusinessRules _rules;

        public InstructorManager(IInstructorRepository instructorRepository, IMapper mapper, InstructorBusinessRules rules)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
            _rules = rules;
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<CreateInstructorResponse>> AddAsync(CreateInstructorRequest request)
        {
            await _rules.CheckUserNameIfExist(request.UserName, null);

            Instructor instructor = _mapper.Map<Instructor>(request);
            await _instructorRepository.AddAsync(instructor);
            CreateInstructorResponse response = _mapper.Map<CreateInstructorResponse>(instructor);
            return new SuccessDataResult<CreateInstructorResponse>(response, InstructorMessages.InstructorAdded);
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IResult> DeleteAsync(DeleteInstructorRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);

            var item = await _instructorRepository.GetAsync(x => x.Id == request.Id);
            await _instructorRepository.DeleteAsync(item);

            return new SuccessResult(InstructorMessages.InstructorDeleted);
        }

        public async Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync()
        {
            var list = await _instructorRepository.GetAllAsync();
            List<GetAllInstructorResponse> response = _mapper.Map<List<GetAllInstructorResponse>>(list);
            return new SuccessDataResult<List<GetAllInstructorResponse>>(response, InstructorMessages.InstructorListed);
        }

        public async Task<IDataResult<GetByIdInstructorResponse>> GetByIdAsync(int id)
        {
            await _rules.CheckIdIfNotExist(id);

            var item = await _instructorRepository.GetAsync(x => x.Id == id);

            GetByIdInstructorResponse response = _mapper.Map<GetByIdInstructorResponse>(item);


            return new SuccessDataResult<GetByIdInstructorResponse>(response, InstructorMessages.InstructorFound);


        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<UpdateInstructorResponse>> UpdateAsync(UpdateInstructorRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);
            await _rules.CheckUserNameIfExist(request.UserName, request.Id);

            var item = await _instructorRepository.GetAsync(p => p.Id == request.Id);

            _mapper.Map(request, item);
            await _instructorRepository.UpdateAsync(item);

            UpdateInstructorResponse response = _mapper.Map<UpdateInstructorResponse>(item);
            return new SuccessDataResult<UpdateInstructorResponse>(response, InstructorMessages.InstructorUpdated);
        }


    }

}