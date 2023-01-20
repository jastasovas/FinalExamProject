using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;
        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        [HttpPost]
        public Address AddNewAddress([FromBody] AddressDto address)
        { 
            return _addressRepository.AddNewAddress(address);
        }

        [HttpDelete]

        public Address DeleteAddress(int id)
        {
            return _addressRepository.DeleteAddress(id);
        }

        [HttpGet("id")]

        public Address GetAddressById([FromQuery] int id)
        { 
            return _addressRepository.GetAddressById(id);   
        }

        [HttpGet]

        public List<Address> GetAddresses()
        {
            return _addressRepository.GetAddresses();
        }

        [HttpPut]

        public Address UpdateAddress(int id, AddressDto address)
        { 
            return _addressRepository.UpdateAddress(id, address);
        }
    }
}
