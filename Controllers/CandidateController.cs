using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace GitHub.Controllers
{
    [ApiController]
    [Route("/Candidate")]
    public class CandidateController : ControllerBase

    {
        [HttpPost("Agitation")]
        public string Agitation(string str)
        {
            return str;// Агитация
        }

        [HttpPost("MeetTheConditions")]
        public string MeetTheConditions(string str)
        {
            return str;// Соответствовать условиям для участия в выборах
        }
        
        [HttpPost("ApplicationForRegistration")]
        public string ApplicationForRegistration(string str)
        {
            return str;// Оставить заявку на регистрацию
        }


    }
}
