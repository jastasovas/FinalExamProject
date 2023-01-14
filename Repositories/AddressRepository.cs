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
            throw new NotImplementedException();
        }

        public Address DeleteAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public Address UpdateAddress(int id, AddressDto address)
        {
            throw new NotImplementedException();
        }
    }
}
