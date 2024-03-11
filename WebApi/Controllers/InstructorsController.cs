using Business.Abstracts;
using Business.Requests.Instructors;
using Business.Responses.Instructors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : BaseController
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CreateInstructorRequest request)
        {
            return Ok(await _instructorService.AddAsync(request));
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _instructorService.GetAllAsync());
        }

        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _instructorService.GetByIdAsync(id));
        }

        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeletedAsync(DeleteInstructorRequest request)
        {
            return Ok(await _instructorService.DeleteAsync(request));
        }

        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync(UpdateInstructorRequest request)
        {
            return Ok(await _instructorService.UpdateAsync(request));
        }
    }
}