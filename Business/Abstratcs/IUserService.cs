using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Results;
using Business.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstratcs
{
    public interface IUserService
    {
        Task<List<GetAllUserResponse>> GetAll();
        Task<GetByIdUserResponse> GetById(int id);

    }
}