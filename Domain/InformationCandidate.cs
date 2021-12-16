using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class InformationCandidate : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public string PlaceOfResidence { get; set; }

        public string Email { get; set; }

        public string Education { get; set; }

        public string Achievements { get; set; }

        public string Merits { get; set; }

        public string Hobbies { get; set; }

        public int NumberOfVotes { get; set; }

        InformationCandidate(int id, string name, string dateOfBirth, string placeOfResidence, string email, string education, string achievements, string merits, string hobbies, int numberOfVotes)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            PlaceOfResidence = placeOfResidence;
            Email = email;
            Education = education;
            Achievements = achievements;
            Merits = merits;
            Hobbies = hobbies;
            NumberOfVotes = numberOfVotes;
        }

    }
}
