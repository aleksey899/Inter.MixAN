using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Voter : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int PassportSeriesAndNumber { get; set; }

        Voter(int id, string name, string dateOfBirth, int passportSeriesAndNumber)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            PassportSeriesAndNumber = passportSeriesAndNumber;

        }

    }
}
