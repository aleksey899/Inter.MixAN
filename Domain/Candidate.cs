using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Candidate : AAID

    {

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int MaterialsForAgitation { get; set; }

        Candidate(int id, string name, string dateOfBirth, int materialsForAgitation)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.MaterialsForAgitation = materialsForAgitation;
        }
    }
}
