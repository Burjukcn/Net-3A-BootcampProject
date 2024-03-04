﻿using Business.Constants;
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
    public class BootcampBusinessRules : BaseBusinessRules
    {
        private readonly IBootcampRepository _bootcampRepository;

        public BootcampBusinessRules(IBootcampRepository bootcampRepository)
        {
            _bootcampRepository = bootcampRepository;
        }

        public async Task CheckIdIfNotExist(int id)
        {
            var item = await _bootcampRepository.GetAsync(x => x.Id == id);
            if (item == null)
            {
                throw new NotFoundException(BootcampMessages.BootcampIdCheck);
            }
        }
    }
}
