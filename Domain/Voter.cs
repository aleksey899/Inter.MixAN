using System;

namespace GitHub
{
    public class Voter
    {
        public int Id { get; set; }

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
