using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class TermsOfParticipation : IIdentifier
    {
        public int Id { get; set; }
        public bool CriminalRecord { get; set; }

        public string Citizenship { get; set; }

        public string LegalStatus { get; set; }

        public int AdminId { get; set; }

        TermsOfParticipation(int id, bool criminalRecord, string citizenship, string legalStatus, int adminId)
        {
            Id = id;
            CriminalRecord = criminalRecord;
            Citizenship = citizenship;
            LegalStatus = legalStatus;
            AdminId = adminId;
            
        }

    }
}
