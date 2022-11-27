using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class Candidate : IIdentifier

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int MaterialsForAgitation { get; set; }

        Candidate(int id, string name, string dateOfBirth, int materialsForAgitation)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            MaterialsForAgitation = materialsForAgitation;
        }
    }
}
