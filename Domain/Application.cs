using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain

{
    public class Application: IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public bool CriminalRecord { get; set; }

        public int AdminId { get; set; }

        public int CandidateId { get; set; }

        Application(int id, string name, string dateOfBirth, bool criminalRecord, int adminId, int candidateId)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            CriminalRecord = criminalRecord;
            AdminId = adminId;
            CandidateId = candidateId;
            
        }

    }
}
