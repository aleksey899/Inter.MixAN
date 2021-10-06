using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitHub.Controllers
{
    [ApiController]
    [Route("/Administrator")]
    public class AdministratorController : ControllerBase
    {

        [HttpPost("Registrationontheplatform")]
        public string Registrationontheplatform(string str)
        {
            return str;// Регистрация на платформе
        }

        [HttpGet("Nominateacandidate")]
        public string Nominateacandidate(string str)
        {
            return str;// Выдвинуть кандидата

        }


    }
}
