using Business.Constants;
using Core.CrossCuttingConcerns;
using Core.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ApplicationStateBusinessRules : BaseBusinessRules
    {
        private readonly IApplicationStateRepository _applicationStateRepository;

        public ApplicationStateBusinessRules(IApplicationStateRepository applicationStateRepository)
        {
            _applicationStateRepository = applicationStateRepository;
        }

        public async Task CheckIfApplicationStateNotExists(int id)
        {
            var isExists = await _applicationStateRepository.GetAsync(a => a.Id == id);
            if (isExists is null)
                throw new BusinessException(ApplicationStateMessages.ApplicationStateIdCheck);
        }

        public async Task CheckApplicationStateNameIfExist(string name)
        {
            var isExists = await _applicationStateRepository.GetAsync(a => a.Name == name);
            if (isExists is not null)
                throw new BusinessException(ApplicationStateMessages.ApplicationStateNameCheck);
        }

        public async Task CheckIdIfNotExist(int id)
        {
            var item = await _applicationStateRepository.GetAsync(x => x.Id == id);
            if (item == null)
            {
                throw new NotFoundException(ApplicationStateMessages.ApplicationStateIdCheck);
            }
        }

    }


}

