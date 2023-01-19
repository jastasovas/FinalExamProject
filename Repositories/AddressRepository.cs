using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly UserDbContext _addressContext;
        public AddressRepository(UserDbContext addressContext)
        {
            _addressContext = addressContext; 
        }

        public Address AddNewAddress(AddressDto address)
        {
            var newAddress = new Address
            {
                City = address.City,
                Street = address.Street,
                HouseNumber = address.HouseNumber,
                FlatNumber = address.FlatNumber,
                HumanId = address.HumanId,
            };
            _addressContext.Addresses.Add(newAddress);
            _addressContext.SaveChanges();
            return newAddress;
        }

        public Address DeleteAddress(int id)
        {
            var addressToDelete = _addressContext.Addresses.Single(x => x.Id == id);
            _addressContext.SaveChanges();
            return addressToDelete;
        }

        public Address GetAddressById(int id)
        {
            return _addressContext.Addresses.Where(a => a.Id == id).Single();
        }

        public List<Address> GetAddresses()
        {
            return _addressContext.Addresses.ToList();
        }

        public Address UpdateAddress(int id, AddressDto address)
        {
            var addressToUpdate = _addressContext.Addresses.Single(x => x.Id == id);
            addressToUpdate.City = address.City;
            addressToUpdate.Street = address.Street;    
            addressToUpdate.HouseNumber = address.HouseNumber;
            addressToUpdate.FlatNumber = address.FlatNumber;
            addressToUpdate.HumanId = address.HumanId;
            _addressContext.SaveChanges();
            return addressToUpdate;
        }
    }
}
