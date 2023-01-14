using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _userContext;    
        public UserRepository(UserDbContext userContext)
        {
            _userContext = userContext;
        }

        public User AddNewUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(string userName, UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
