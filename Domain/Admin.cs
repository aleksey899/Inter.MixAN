using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Admin: AAID
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string ListOfCandidates { get; set; }

        public int CandidateInformationID { get; set; }

        public int ElectionsInformationID { get; set; }

        public int TermsParticipationID { get; set; }

        public int UserInformationID { get; set; }

        Admin(int id, string name, string email, int phoneNumber, string listOfCandidates, int candidateInformationID, int electionsInformationID, int termsParticipationID, int userInformationID)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            ListOfCandidates = listOfCandidates;
            CandidateInformationID = candidateInformationID;
            ElectionsInformationID = electionsInformationID;
            TermsParticipationID = termsParticipationID;
            UserInformationID = userInformationID;
        }
    }
}
