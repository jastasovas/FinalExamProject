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

        [HttpPost]

        public Human AddNewHuman([FromQuery] HumanDto human)
        {
            return _humanRepository.AddNewHuman(human);
        }

        [HttpDelete]
        public Human DeleteHumanById(int id)
        {
            return _humanRepository.DeleteHumanById(id);
        }

        [HttpGet("id")]
        public Human GetHumanById([FromQuery] int id)
        {
            return _humanRepository.DeleteHumanById(id);
        }
    }
}
