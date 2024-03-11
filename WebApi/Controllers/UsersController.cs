
using Business.Requests.Users;
using Microsoft.AspNetCore.Mvc;
using Business.Abstracts;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateUserRequest request)
        {
            return Ok(await _userService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _userService.GetByIdAsync(id));
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeletedAsync(DeleteUserRequest request)
        {
            return Ok(await _userService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateUserRequest request)
        {
            return Ok(await _userService.UpdateAsync(request));
        }
    }
}