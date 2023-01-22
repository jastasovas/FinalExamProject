using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public List<User> GetAll()
        { 
            return _userRepository.GetAll();
        }

        [HttpGet("userName")]
        public User GetByUserName([FromQuery] string userName)
        { 
            return _userRepository.GetByUserName(userName);
        }

        [HttpPost]
        public User AddNewUser([FromBody] UserDto user)
        { 
            return _userRepository.AddNewUser(user);    
        }

        [HttpDelete]
        public User DeleteUser( int id)
        { 
            return _userRepository.DeleteUser(id);
        }

        [HttpPut]
        public User UpdateUser(string userName, UserDto user)
        { 
            return _userRepository.UpdateUser(userName, user);
        }
    }
}
