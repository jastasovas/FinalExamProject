using FinalExam.Dto_s;
using FinalExam.Entities;

namespace FinalExam.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetByUserName(string userName);
        User AddNewUser(UserDto user);
        User UpdateUser(string userName,UserDto user);
        User DeleteUser(int id);
    }
}
