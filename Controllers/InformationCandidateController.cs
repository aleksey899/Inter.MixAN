using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/InformationCandidate")]
    public class InformationCandidateController : ControllerBase

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
        public bool Create(InformationCandidate informationCandidate)
        {
            return Storages.InformationCandidateStorage.Create(informationCandidate);
        }

        [HttpGet("Read")]
        public InformationCandidate Read(int Id)
        {
            return Storages.InformationCandidateStorage.Read(Id);
        }

        [HttpPut("Update")]
        public InformationCandidate Update(InformationCandidate informationCandidate)
        {
            return Storages.InformationCandidateStorage.Update(informationCandidate);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.InformationCandidateStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.InformationCandidateStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.InformationCandidateStorage.ReadFromXmlFile();
        }
    }
}