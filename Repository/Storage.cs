using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;

namespace Inter.MixAN.Repository
{
   
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static string Filepath = typeof(IIdentifier).Name + ".xml";
        private List<IIdentifier> _storage = new();

        public Storage() { }

        public void ReadFromXMLFile()
        {
            if (File.Exists(Filepath)) return;           
            var xs = new XmlSerializer(typeof(List<IIdentifier>));
            using var fs = new FileStream(Filepath, FileMode.Open);
            _storage = (List<IIdentifier>)xs.Deserialize(fs);           
        }

        public void SaveToXMLFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(Filepath)))
                Directory.CreateDirectory(Path.GetFullPath(Filepath));
            var xs = new XmlSerializer(typeof(List<IIdentifier>));
            using var fs = new FileStream(Filepath, FileMode.Create);
            xs.Serialize(fs, _storage);
            fs.Flush();
        }

        public bool Create(IIdentifier obj)
        {

            if (_storage.Any(t => t.Id == obj.Id))
                return false;
            _storage.Add(obj);
            return true;
        }

        public IIdentifier Read(int id)
        {
            return _storage.FirstOrDefault(t => t.Id == id);
        }
        public IIdentifier Update(IIdentifier obj)
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
