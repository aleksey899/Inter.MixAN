using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;

namespace Inter.MixAN.Repository

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
            if (_storage.Any(t => t.Id == obj.Id)) return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id) => _storage.First(t => t.Id == id);
       
        public TIdentifier Update(St obj)
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objID)
        {
            return _storage.RemoveAll(t => t.Id == objID) != 0;
        }
    }
}
