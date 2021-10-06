using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitHub.Controllers
{
    [ApiController]
    [Route("/Voter")]
    public class VoterController : ControllerBase

    {
        [HttpPost("Registrationontheplatform")]
        public string Registrationontheplatform(string str)
        {
            return str;// Регистрация на платформе
        }

        [HttpGet("Toknowlinkontheplatform")]
        public string Toknowlinkontheplatform(string str)
        {
            return str;//Узнать ссылку на платформу
        }

        [HttpPost("Enteringpassportdata")]
        public string Enteringpassportdata(string str)
        {
            return str;// Ввод паспортных данных
        }

        [HttpPost("Choosingacandidate")]
        public string Choosingacandidate(string str)
        {
            return str;// Выбор кандидата
        }

        [HttpGet("Obtaininginformationaboutacandidate ")]
        public string Obtaininginformationaboutacandidate(string str)
        {
            return str;// Получение сведений о кандидате
        }

        [HttpPost("Leaveavoice")]
        public string Leaveavoice(string str)
        {
            return str;// Оставить голос
        }




    }
}
