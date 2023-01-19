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
            var newUser = new User
            {
                Username = user.Username,
                Password = user.Password,
                Role = user.Role
            };
            _userContext.Users.Add(newUser);
            _userContext.SaveChanges();
            return newUser;
        }

        public User DeleteUser(int id)
        {
            var userToDelete = _userContext.Users.Single(x => x.Id == id);
            _userContext.Users.Remove(userToDelete);
            _userContext.SaveChanges();
            return userToDelete;
        }

        public List<User> GetAll()
        {
            return _userContext.Users.ToList();
        }

        public User GetByUserName(string userName)
        {
            return _userContext.Users.Where(x => x.Username == userName).Single();
        }

        public User UpdateUser(string userName, UserDto user)
        {
            var userToUpdate = _userContext.Users.Single(x => x.Username == userName);
            userToUpdate.Username = userName;
            userToUpdate.Password = user.Password;  
            userToUpdate.Role = user.Role;
            _userContext.SaveChanges();
            return userToUpdate;
        }
    }
}
