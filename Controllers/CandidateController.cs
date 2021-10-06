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

        [HttpPost("Meettheconditionsforparticipationintheelections")]
        public string Meettheconditionsforparticipationintheelections(string str)
        {
            return str;// Соответствовать условиям для участия в выборах
        }


    }
}
