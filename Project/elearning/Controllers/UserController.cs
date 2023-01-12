using elearning.Entities;
using elearning.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace elearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return (users == null) ? NotFound("No users available") : users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            return (user == null) ? NotFound("The user does not exist!") : user;
        }
    }
}
