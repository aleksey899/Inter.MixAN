using System;

namespace GitHub
{
    public class TermsOfParticipation
    {
        public int Id { get; set; }

        public bool CriminalRecord { get; set; }

        public string Citizenship { get; set; }

        public string LegalStatus { get; set; }

        public int AdminId { get; set; }

        TermsOfParticipation(int id, bool criminalRecord, string citizenship, string legalStatus, int adminId)
        {
            this.Id = id;
            this.CriminalRecord = criminalRecord;
            this.Citizenship = citizenship;
            this.LegalStatus = legalStatus;
            this.AdminId = adminId;
            
        }

    }
}
