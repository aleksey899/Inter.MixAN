using System;

namespace GitHub
{
    public class InformationVoter
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int PassportSeriesAndNumber { get; set; }

        InformationVoter(int id, string name, int passportSeriesAndNumber)
        {
            this.Id = id;
            this.Name = name;
            this.PassportSeriesAndNumber = passportSeriesAndNumber;
            
        }

    }
}
