using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Application: AAID

    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public bool CriminalRecord { get; set; }

        public int AdminId { get; set; }

        public int CandidateId { get; set; }

        Application(int id, string name, string dateOfBirth, bool criminalRecord, int adminId, int candidateId)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.CriminalRecord = criminalRecord;
            this.AdminId = adminId;
            this.CandidateId = candidateId;
            
        }

    }
}
