using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Agitation")]
    public class MaterialsForAgitation : ControllerBase

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
        public bool Create(MaterialsForAgitation materialsForAgitation)
        {
            return Storages.MaterialsForAgitation.Create(materialsForAgitation);
        }

        [HttpGet("Read")]
        public MaterialsForAgitation Read(int Id)
        {
            return Storages.MaterialsForAgitationStorage.Read(Id);
        }

        [HttpPut("Update")]
        public MaterialsForAgitation Update(MaterialsForAgitation materialsForAgitation)
        {
            return Storages.MaterialsForAgitationStorage.Update(materialsForAgitation);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.MaterialsForAgitationStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.MaterialsForAgitationStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.MaterialsForAgitationStorage.ReadFromXmlFile();
        }


    }
}
