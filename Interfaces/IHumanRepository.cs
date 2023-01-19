using FinalExam.Dto_s;
using FinalExam.Entities;

namespace FinalExam.Interfaces
{
    public interface IHumanRepository
    {
        List<Human> GetAllHumans();
        Human GetHumanById(int id);
        Human AddNewHuman(HumanDto human);
        Human UpdateFirstName(string firstName);
        Human UpdateLastName(string lastName);
        Human UpdatePersonalCode(int personalCode);
        Human UpdatePhoneNumber(string phoneNumber);
        Human UpdateEmail(string email);
        Human UpdatePicture(string profilePicture);
        Human DeleteHumanById(int id);
    }
}
