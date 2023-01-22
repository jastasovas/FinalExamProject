using FinalExam.Dto_s;
using FinalExam.Entities;
using FinalExam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanController : ControllerBase
    {
        private readonly IHumanRepository _humanRepository;
        public HumanController(IHumanRepository humanRepository)
        {
            _humanRepository = humanRepository;
        }

        [HttpGet]
        public List<Human> GetAllHumans()
        {
            return _humanRepository.GetAllHumans();
        }

        [HttpGet("id")]
        public Human GetHumanById([FromQuery] int id)
        {
            return _humanRepository.DeleteHumanById(id);
        }

        [HttpPost]
        public Human AddNewHuman([FromBody] HumanDto human)
        {
            return _humanRepository.AddNewHuman(human);
        }

        [HttpPut]
        public Human UpdateHuman([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdateHuman(id, human);
        }

        [HttpDelete]
        public Human DeleteHumanById(int id)
        {
            return _humanRepository.DeleteHumanById(id);
        }

        [HttpPut("change name")]
        public Human UpdateFirstName([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdateFirstName(id, human);
        }

        [HttpPut("change lastname")]
        public Human UpdateLastName([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdateLastName(id, human);
        }

        [HttpPut("change personalcode")]
        public Human UpdatePersonalCode([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdatePersonalCode(id, human);
        }

        [HttpPut("change phonenumber")]
        public Human UpdatePhoneNumber([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdatePhoneNumber(id, human);
        }

        [HttpPut("change email")]
        public Human UpdateEmail([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdateEmail(id, human);
        }

        [HttpPut("change picture")]
        public Human UpdatePicture([FromQuery] int id, [FromBody] HumanDto human)
        {
            return _humanRepository.UpdatePicture(id, human);
        }
    }
}
