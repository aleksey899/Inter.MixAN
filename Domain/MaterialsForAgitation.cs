using System;

namespace GitHub
{
    public class MaterialsForAgitation
    {
        public string Id { get; set; }

        public string CallToVoteForACandidate { get; set; }

        public string Slogan { get; set; }

        public string InformationAboutTheCandidateActivities { get; set; }

        public string CandidateProgram{ get; set; }

        public string ProgramInterview { get; set; }

        public string Message { get; set; }

        MaterialsForAgitation(int id, string callToVoteForACandidate, string slogan, string informationAboutTheCandidateActivities, string candidateProgram, string programInterview, string message)
        {
            this.Id = id;
            this.CallToVoteForACandidate = callToVoteForACandidate;
            this.Slogan = slogan;
            this.InformationAboutTheCandidateActivities = informationAboutTheCandidateActivities;
            this.CandidateProgram = candidateProgram;
            this.ProgramInterview = programInterview;
            this.Message = message;

        }

    }
}
