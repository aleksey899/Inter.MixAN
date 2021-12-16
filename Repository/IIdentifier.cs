using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Inter.MixAN.Domain;

namespace Inter.MixAN.Repository
{
    public interface IIdentifier
    {
        public int Id { get; set; }
    }
}
