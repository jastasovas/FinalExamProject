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

        public Human DeleteHumanById(int id)
        {
            var humanToDelete = _humanDbContext.Humans.Single(h => h.Id == id);
            _humanDbContext.Humans.Remove(humanToDelete);
            _humanDbContext.SaveChanges();
            return humanToDelete;
        }

        public Human UpdateFirstName(int id, HumanDto human)
        {
            var nameToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            nameToUpdate.FirstName = human.FirstName;
            _humanDbContext.SaveChanges();
            return nameToUpdate;
        }

        public Human UpdateLastName(int id, HumanDto human)
        {
            var lastNameToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            lastNameToUpdate.LastName = human.LastName;
            _humanDbContext.SaveChanges();
            return lastNameToUpdate;
        }

        public Human UpdatePersonalCode(int id, HumanDto human)
        {
            var codeToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            codeToUpdate.PersonalCode = human.PersonalCode;
            _humanDbContext.SaveChanges();
            return codeToUpdate;
        }

        public Human UpdatePhoneNumber(int id, HumanDto human)
        {
            var phoneToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            phoneToUpdate.PhoneNumber = human.PhoneNumber;
            _humanDbContext.SaveChanges();
            return phoneToUpdate;
        }

        public Human UpdateEmail(int id, HumanDto human)
        {
            var mailToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            mailToUpdate.Email = human.Email;
            _humanDbContext.SaveChanges();
            return mailToUpdate;
        }

        public Human UpdatePicture(int id, HumanDto human)
        {
            var pictureToUpdate = _humanDbContext.Humans.Single(x => x.Id == id);
            pictureToUpdate.ProfilePicture = human.ProfilePicture;
            _humanDbContext.SaveChanges();
            return pictureToUpdate;
        }

        
    }
}
