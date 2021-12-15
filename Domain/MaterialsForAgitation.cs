using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class MaterialsForAgitation : AAID
    {
        public string CallToVoteForACandidate { get; set; }

        public string Slogan { get; set; }

        public string InformationAboutTheCandidateActivities { get; set; }

        public string CandidateProgram{ get; set; }

        public string ProgramInterview { get; set; }

        public string Message { get; set; }

        MaterialsForAgitation(int id, string callToVoteForACandidate, string slogan, string informationAboutTheCandidateActivities, string candidateProgram, string programInterview, string message)
        {
            Id = id;
            CallToVoteForACandidate = callToVoteForACandidate;
            Slogan = slogan;
            InformationAboutTheCandidateActivities = informationAboutTheCandidateActivities;
            CandidateProgram = candidateProgram;
            ProgramInterview = programInterview;
            Message = message;

        }

    }
}
