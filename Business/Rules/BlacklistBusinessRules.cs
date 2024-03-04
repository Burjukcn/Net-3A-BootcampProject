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
    public class BlacklistBusinessRules : BaseBusinessRules
    {
        private readonly IBlacklistRepository _blacklistRepository;

        public BlacklistBusinessRules(IBlacklistRepository blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        public async Task CheckIdIfNotExist(int id)
        {
            var item = await _blacklistRepository.GetAsync(x => x.Id == id);
            if (item == null)
            {
                throw new NotFoundException(BlacklistMessages.BlacklistIdCheck);
            }
        }
    }
}
