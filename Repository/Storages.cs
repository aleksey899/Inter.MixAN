using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;


namespace Inter.MixAN.Repository
{
    public class Storages
    {
        public static Storage<Admin> AdminStorage { get; } = new();
        public static Storage<Application> ApplicationStorage { get; } = new();
        public static Storage<Candidate> CandidateStorage { get; } = new();
        public static Storage<InformationCandidate> InformationCandidateStorage { get; } = new();
        public static Storage<InformationVoter> InformationVoterStorage { get; } = new();
        public static Storage<MaterialsForAgitation> MaterialsForAgitationStorage { get; } = new();
        public static Storage<TermsOfParticipation> TermsOfParticipationStorage { get; } = new();
        public static Storage<Voter> VoterStorage { get; } = new();
    }
}