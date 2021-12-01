using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;

namespace Inter.MixAN.Repository
{
    public class AAID
    {
        public int ID { get; set; }
    }

    public class Storages
    {
        public static Storage<Admin> AdminStorage { get; } = new Storage<Admin>();
        public static Storage<Application> ApplicationStorage { get; } = new Storage<Application>();
        public static Storage<Candidate> CandidateStorage { get; } = new Storage<Candidate>();
        public static Storage<InformationCandidate> InformationCandidateStorage { get; } = new Storage<InformationCandidate>();
        public static Storage<InformationVoter> InformationVoterStorage { get; } = new Storage<InformationVoter>();
        public static Storage<MaterialsForAgitation> MaterialsForAgitationStorage { get; } = new Storage<MaterialsForAgitation>();
        public static Storage<TermsOfParticipation> TermsOfParticipationStorage { get; } = new Storage<TermsOfParticipation>();
        public static Storage<Voter> VoterStorage { get; } = new Storage<Voter>();
    }

    public class Storage<St> where St : AAID
    {
        private static string path = typeof(St).Name + ".xml";
        private List<St> storage = new List<St>();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (File.Exists(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<St>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    storage = (List<St>)xs.Deserialize(fs);
            }
        }

        public void SaveToXMLFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<St>));
            using (FileStream fs = new FileStream(path, FileMode.Create))
                xs.Serialize(fs, storage);
        }

        public bool Create(St obj)
        {
            if (storage.Where(t => t.ID == obj.ID).Count() != 0)
                return false;
            storage.Add(obj);
            return true;
        }

        public St Read(int ID)
        {
            if (storage.Where(t => t.ID == ID).Count() != 0)
                return storage.Where(t => t.ID == ID).First();
            return null;
        }

        public St Update(St obj)
        {
            int index = storage.FindIndex(t => t.ID == obj.ID);
            if (index == -1)
                Create(obj);
            else
                storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
            return storage.RemoveAll(t => t.ID == objID) != 0;
        }
    }
}
