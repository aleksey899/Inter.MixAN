using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;

namespace Inter.MixAN.Repository
<<<<<<< HEAD
=======
{
    public class AAID
    {
        public int Id { get; set; }
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
>>>>>>> eb1dc37949da9ed76103d6a19820bd3fa6edf43b

    public class Storage<TIdentifier> where TIdentifier : TIdentifier
    {
        private static string path = typeof(TIdentifier).Name + ".xml";
        private List<TIdentifier> _storage = new();
     

        public void ReadFromXMLFile()
        {
            if (File.Exists(path)) return;           
            var xs = new XmlSerializer(typeof(List<St>));
            using var fs = new FileStream(path, FileMode.Open)
            _storage = (List<St>)xs.Deserialize(fs)            
        }

        public void SaveToXMLFile()
        {
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(path, FileMode.Create)
            xs.Serialize(fs,_storage);
        }

        public bool Create(TIdentifier obj)
        {
<<<<<<< HEAD
            if (_storage.Any(t => t.Id == obj.Id)) return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id) => _storage.First(t => t.Id == id);
       
        public TIdentifier Update(St obj)
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
=======
            if (storage.Where(t => t.Id == obj.Id).Count() != 0)
                return false;
            storage.Add(obj);
            return true;
        }

        public St Read(int ID)
        {
            if (storage.Where(t => t.Id == ID).Count() != 0)
                return storage.Where(t => t.Id == ID).First();
            return null;
        }

        public St Update(St obj)
        {
            int index = storage.FindIndex(t => t.Id == obj.Id);
>>>>>>> eb1dc37949da9ed76103d6a19820bd3fa6edf43b
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
<<<<<<< HEAD
            return _storage.RemoveAll(t => t.Id == objID) != 0;
=======
            return storage.RemoveAll(t => t.Id == objID) != 0;
>>>>>>> eb1dc37949da9ed76103d6a19820bd3fa6edf43b
        }
    }
}
