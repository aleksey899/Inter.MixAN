using System;

namespace GitHub
{
    public class Admin
    {
        public int Id { get; set; }

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
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.ListOfCandidates = listOfCandidates;
            this.CandidateInformationID = candidateInformationID;
            this.ElectionsInformationID = electionsInformationID;
            this.TermsParticipationID = termsParticipationID;
            this.UserInformationID = userInformationID;
        }
    }
}
