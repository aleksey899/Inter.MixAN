using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Voter")]
    public class VoterController : ControllerBase

    {
       
        [HttpPost("RegistrationOnThePlatform")]
        public string RegistrationOnThePlatform(string str)
        {
            return str;// Регистрация на платформе
        }

       [HttpPost("MeetTheConditions")]
        public string MeetTheConditions(string str)
        {
            return str;// Соответствовать условиям для участия
        }
       
       
        [HttpPost("EnteringPassportData")]
        public string EnteringPassportData(string str)
        {
            return str;// Ввод паспортных данных
        }

        [HttpPost("CandidateSelection")]
        public string CandidateSelection(string str)
        {
            return str;// Выбор кандидата
        }

        [HttpGet("InformationAboutTheCandidate")]
        public string InformationAboutTheCandidate(string str)
        {
            return str;// Получение сведений о кандидате
        }
        
         [HttpGet("ViewingCampaignMaterials")]
        public string ViewingCampaignMaterials(string str)
        {
            return str;// Просмотр агитационных материалов
        }

        [HttpPost("LeaveVoice")]
        public string Leaveavoice(string str)
        {
            return str;// Оставить голос
        }
    }

    

}
