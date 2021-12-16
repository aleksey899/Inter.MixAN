using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Employment.Controllers
{
    [ApiController]
    [Route("/InformationVoter")]
    public class InformationVoterController : ControllerBase

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
        public bool Create(InformationVoter informationVoter)
        {
            return Storages.InformationVoterStorage.Create(informationVoter);
        }

        [HttpGet("Read")]
        public InformationVoter Read(int Id)
        {
            return Storages.InformationVoterStorage.Read(Id);
        }

        [HttpPut("Update")]
        public InformationVoter Update(InformationVoter informationVoter)
        {
            return Storages.InformationVoterStorage.Update(informationVoter);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.InformationVoterStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.InformationVoterStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.InformationVoterStorage.ReadFromXmlFile();
        }

    }
}
