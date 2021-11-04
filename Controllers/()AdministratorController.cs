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
        public string CandidateRegistration(string str)
        {
            return str;// Регистрация кандидата
        }

        [HttpPost("InformationAboutCandidates")]
        public string InformationAboutCandidates(string str)
        {
            return str;// Внести информация о кандидатах

        }
        [HttpGet("VerificationOfApplications")]
        public string VerificationOfApplications(string str)
        {
            return str;// Проверка заявок

        }
        
        [HttpPost("TermsOfParticipation")]
        public string TermsOfParticipation(string str)
        {
            return str;// Условия участия

        }
        
        [HttpGet("CheckingVotes")]
        public string CheckingVotes(string str)
        {
            return str;// Проверка голосов

        }


    }
}
