using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Employees;
using Business.Responses.Employees;
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
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly EmployeeBusinessRules _rules;
        public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper, EmployeeBusinessRules rules)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _rules = rules;
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<CreateEmployeeResponse>> AddAsync(CreateEmployeeRequest request)
        {
            await _rules.CheckUserNameIfExist(request.UserName);

            Employee employee = _mapper.Map<Employee>(request);
            await _employeeRepository.AddAsync(employee);
            CreateEmployeeResponse response = _mapper.Map<CreateEmployeeResponse>(employee);
            return new SuccessDataResult<CreateEmployeeResponse>(response, EmployeeMessages.EmployeeAdded);
        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IResult> DeleteAsync(DeleteEmployeeRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);

            var item = await _employeeRepository.GetAsync(x => x.Id == request.Id);
            await _employeeRepository.DeleteAsync(item);

            return new SuccessResult(EmployeeMessages.EmployeeDeleted);
        }

        public async Task<IDataResult<List<GetAllEmployeeResponse>>> GetAllAsync()
        {
            var list = await _employeeRepository.GetAllAsync();
            List<GetAllEmployeeResponse> response = _mapper.Map<List<GetAllEmployeeResponse>>(list);
            return new SuccessDataResult<List<GetAllEmployeeResponse>>(response, EmployeeMessages.EmployeeListed);
        }

        public async Task<IDataResult<GetByIdEmployeeResponse>> GetByIdAsync(int id)
        {
            await _rules.CheckIdIfNotExist(id);

            var item = await _employeeRepository.GetAsync(x => x.Id == id);

            GetByIdEmployeeResponse response = _mapper.Map<GetByIdEmployeeResponse>(item);

            return new SuccessDataResult<GetByIdEmployeeResponse>(response, EmployeeMessages.EmployeeFound);


        }
        [LogAspect(typeof(MongoDbLogger))]
        public async Task<IDataResult<UpdateEmployeeResponse>> UpdateAsync(UpdateEmployeeRequest request)
        {
            await _rules.CheckIdIfNotExist(request.Id);
            await _rules.CheckUserNameIfExist(request.UserName);
            var item = await _employeeRepository.GetAsync(p => p.Id == request.Id);

            _mapper.Map(request, item);
            await _employeeRepository.UpdateAsync(item);

            UpdateEmployeeResponse response = _mapper.Map<UpdateEmployeeResponse>(item);
            return new SuccessDataResult<UpdateEmployeeResponse>(response, EmployeeMessages.EmployeeUpdated);
        }

    }

}