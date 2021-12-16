using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/TermsParticipation")]
    public class TermsParticipationController : ControllerBase

    {
        [HttpPut]
        public string Create(string str)
        {
            return str;
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }


        [HttpPost("Create")]
        public bool Create(TermsOfParticipation termsOfParticipation)
        {
            return Storages.TermsOfParticipationStorage.Create(termsOfParticipation);
        }

        [HttpGet("Read")]
        public TermsOfParticipation Read(int Id)
        {
            return Storages.TermsOfParticipationStorage.Read(Id);
        }

        [HttpPut("Update")]
        public TermsOfParticipation Update(TermsOfParticipation termsOfParticipation)
        {
            return Storages.TermsOfParticipationStorage.Update(termsOfParticipation);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.TermsOfParticipationStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.TermsOfParticipationStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.TermsOfParticipationStorage.ReadFromXmlFile();
        }

    }
}
