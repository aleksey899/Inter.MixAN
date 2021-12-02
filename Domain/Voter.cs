using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Voter : AAID
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int PassportSeriesAndNumber { get; set; }

        Voter(int id, string name, string dateOfBirth, int passportSeriesAndNumber)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.PassportSeriesAndNumber = passportSeriesAndNumber;

        }

    }
}
