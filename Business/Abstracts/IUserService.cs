using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Security.Entities;
using Core.Utilities.Results;
using Business.Responses.Users;
using Business.Requests.Users;

namespace Business.Abstracts
{
    public interface IUserService
    {

        Task<IDataResult<CreatedUserResponse>> AddAsync(CreateUserRequest request);
        Task<IDataResult<UpdatedUserResponse>> UpdateAsync(UpdateUserRequest request);
        Task<IResult> DeleteAsync(DeleteUserRequest request);
        Task<IDataResult<List<GetAllUserResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdUserResponse>> GetByIdAsync(int id);
        Task<DataResult<User>> GetById(int id);
        Task<DataResult<User>> GetByMail(string email);
    }
}