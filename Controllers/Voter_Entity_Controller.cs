using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Voter")]
    public class Voter : ControllerBase

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
        public bool Create(Voter voter)
        {
            return Storages.VoterStorage.Create(voter);
        }

        [HttpGet("Read")]
        public Voter Read(int Id)
        {
            return Storages.VoterStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Voter Update(Voter voter)
        {
            return Storages.VoterStorage.Update(voter);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.VoterStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.VoterStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.VoterStorage.ReadFromXmlFile();
        }

    }
}
