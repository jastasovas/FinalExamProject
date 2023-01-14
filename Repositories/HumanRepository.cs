using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class HumanRepository : IHumanRepository
    {
        private readonly UserDbContext _userDbContext;
        public HumanRepository(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext; 
        }

        public Human AddNewHuman(HumanDto human)
        {
            throw new NotImplementedException();
        }

        public Human DeleteHumanById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Human> GetAllHumans()
        {
            throw new NotImplementedException();
        }

        public Human GetHumanById(int id)
        {
            throw new NotImplementedException();
        }

        public Human UpdateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Human UpdateFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public Human UpdateLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public Human UpdatePersonalCode(int personalCode)
        {
            throw new NotImplementedException();
        }

        public Human UpdatePhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Human UpdatePicture(byte[] profilePicture)
        {
            throw new NotImplementedException();
        }
    }
}
