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
    }
}
