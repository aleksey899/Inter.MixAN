using Microsoft.AspNetCore.Mvc;
using Inter.MixAN.Domain;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Controllers
{
    [ApiController]
    [Route("/Admin")]
    public class AdministratorEntityController : ControllerBase
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
        public bool Create(Admin admin)
        {
            return Storages.AdminStorage.Create(admin);
        }

        [HttpGet("Read")]
        public Admin Read(int Id)
        {
            return Storages.AdminStorage.Read(Id);
        }

        [HttpPut("Update")]
        public Admin Update(Admin admin)
        {
            return Storages.AdminStorage.Update(admin);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storages.AdminStorage.Delete(Id);
        }

        [HttpPost("SaveToFile")]
        public void SaveToFile()
        {
            Storages.AdminStorage.SaveToXmlFile();
        }

        [HttpGet("ReadFromFile")]
        public void ReadFromFile()
        {
            Storages.AdminStorage.ReadFromXmlFile();
        }


    }
}
