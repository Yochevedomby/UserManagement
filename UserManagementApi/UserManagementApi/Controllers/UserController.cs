using Microsoft.AspNetCore.Mvc;
using UserManagementApi.Models;
using UserManagementApi.Repositories;

namespace UserManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            _userRepository.CreateUser(user);
            return Ok("User created successfully.");
        }

        [HttpDelete]
        [Route("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            _userRepository.DeleteUser(userId);
            return Ok("User deleted successfully.");
        }

        [HttpPost]
        [Route("validate")]
        public IActionResult ValidateUser([FromBody] User user)
        {
            var isValid = _userRepository.ValidateUser(user.Name, user.Password);
            if (isValid)
            {
                return Ok("User is valid.");
            }
            else
            {
                return Unauthorized("Invalid username or password.");
            }
        }
    }
}