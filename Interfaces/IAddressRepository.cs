using FinalExam.Dto_s;
using FinalExam.Entities;

namespace FinalExam.Interfaces
{
    public interface IAddressRepository
    {
        List<Address>GetAddresses();
        Address GetAddressById(int id);
        Address AddNewAddress(AddressDto address);
        Address UpdateAddress(int id, AddressDto address);
        Address DeleteAddress(int id);
    }
}
