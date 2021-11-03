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

        [HttpPost("CandidateRegistration")]
        public string Registrationontheplatform(string str)
        {
            return str;// Регистрация кандидата
        }

        [HttpPost("InformationAboutCandidates")]
        public string Nominateacandidate(string str)
        {
            return str;// Информация о кандидатах

        }
        [HttpPost("VerificationOfApplications")]
        public string Nominateacandidate(string str)
        {
            return str;// Проверка заявок

        }
        
        [HttpPost("TermsOfParticipation")]
        public string Nominateacandidate(string str)
        {
            return str;// Условия участия

        }
        
        [HttpPost("CheckingVotes")]
        public string Nominateacandidate(string str)
        {
            return str;// Проверка голосов

        }


    }
}
