using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
