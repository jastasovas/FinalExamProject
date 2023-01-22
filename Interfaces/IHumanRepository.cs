using FinalExam.Dto_s;
using FinalExam.Entities;

namespace FinalExam.Interfaces
{
    public interface IHumanRepository
    {
        List<Human> GetAllHumans();
        Human GetHumanById(int id);
        Human AddNewHuman(HumanDto human);
        Human UpdateHuman(int id, HumanDto human);
        Human UpdateFirstName(int id, HumanDto human);
        Human UpdateLastName(int id, HumanDto human);
        Human UpdatePersonalCode(int id, HumanDto human);
        Human UpdatePhoneNumber(int id, HumanDto human);
        Human UpdateEmail(int id, HumanDto human);
        Human UpdatePicture(int id, HumanDto human);
        Human DeleteHumanById(int id);
    }
}
