using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class HumanRepository : IHumanRepository
    {
        private readonly UserDbContext _humanDbContext;
        public HumanRepository(UserDbContext humanDbContext)
        {
            _humanDbContext = humanDbContext; 
        }

        public Human AddNewHuman(HumanDto human)
        {
            var newHuman = new Human
            {
                FirstName = human.FirstName,
                LastName = human.LastName,
                PersonalCode = human.PersonalCode,
                PhoneNumber = human.PhoneNumber,
                Email = human.Email,
                ProfilePicture = human.ProfilePicture,
                UserId = human.UserId,
            };
            _humanDbContext.Humans.Add(newHuman);
            _humanDbContext.SaveChanges();
            return newHuman;
        }

        public Human DeleteHumanById(int id)
        {
            var humanToDelete = _humanDbContext.Humans.Single(h => h.Id == id);
            _humanDbContext.Humans.Remove(humanToDelete);
            _humanDbContext.SaveChanges();
            return humanToDelete;
        }

        public List<Human> GetAllHumans()
        {
            return _humanDbContext.Humans.ToList();
        }

        public Human GetHumanById(int id)
        {
            return _humanDbContext.Humans.Where(x => x.Id == id).Single();
        }

        public Human UpdateHuman(int id, HumanDto human)
        {
            var humanToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            humanToUpdate.FirstName = human.FirstName;
            humanToUpdate.LastName = human.LastName;    
            humanToUpdate.PersonalCode = human.PersonalCode;
            humanToUpdate.PhoneNumber = human.PhoneNumber;
            humanToUpdate.Email = human.Email;
            humanToUpdate.ProfilePicture = human.ProfilePicture;
            _humanDbContext.SaveChanges();
            return humanToUpdate;
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

        public Human UpdatePicture(string profilePicture)
        {
            throw new NotImplementedException();
        }
    }
}
