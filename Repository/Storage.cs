using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Inter.MixAN.Repository
{
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static string _filepath = nameof(IIdentifier) + ".xml";
        private List<TIdentifier> _storage = new();

        public void ReadFromXmlFile()
        {
            if (File.Exists(_filepath)) return;           
            var xs = new XmlSerializer(typeof(List<IIdentifier>));
            using var fs = new FileStream(_filepath, FileMode.Open);
            _storage = (List<TIdentifier>)xs.Deserialize(fs);           
        }

        public void SaveToXmlFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(_filepath)))
                Directory.CreateDirectory(Path.GetFullPath(_filepath));
            var xs = new XmlSerializer(typeof(List<IIdentifier>));
            using var fs = new FileStream(_filepath, FileMode.Create);
            xs.Serialize(fs, _storage);
            fs.Flush();
        }

        public bool Create(TIdentifier obj)
        {
            if (_storage.Any(t => t.Id == obj.Id))
                return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id)
        {
            return _storage.FirstOrDefault(t => t.Id == id);
        }
        public TIdentifier Update(TIdentifier obj)
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objId)
        {
            return _storage.RemoveAll(t => t.Id == objId) != 0;
        }
    }
}
