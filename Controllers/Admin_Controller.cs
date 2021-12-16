using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Admin")]
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
