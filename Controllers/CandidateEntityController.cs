using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Candidate")]
    public class CandidateEntityController : ControllerBase

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
        public bool Create(Candidate сandidate)
        {
            return Storages.CandidateStorage.Create(сandidate);
        }

        [HttpGet("Read")]
        public Candidate Read(int Id)
        {
            return Storages.CandidateStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Candidate Update(Candidate сandidate)
        {
            return Storages.CandidateStorage.Update(сandidate);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.CandidateStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.CandidateStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.CandidateStorage.ReadFromXmlFile();
        }

    }
}
