using Business.Abstratcs;
using Business.Responses.Users;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<List<GetAllUserResponse>> GetAll()
        {
            List<GetAllUserResponse> users = new List<GetAllUserResponse>();

            foreach (var user in await _userRepository.GetAllAsync())
            {
                GetAllUserResponse response = new GetAllUserResponse();
                response.Id = user.Id;
                response.UserName = user.UserName;
                users.Add(response);
            }
            return users;
        }


        public async Task<GetByIdUserResponse> GetById(int id)
        {
            GetByIdUserResponse response = new GetByIdUserResponse();
            User user = await _userRepository.GetAsync(x => x.Id == id);
            response.Id = user.Id;
            response.UserName = user.UserName;
            return response;
        }


    }
}