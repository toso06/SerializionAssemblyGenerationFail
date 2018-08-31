using System;
using System.Xml.Serialization;

namespace SerializionAssemblyGenerationFail
{
    public class Request
    {
        [XmlElement(ElementName = "MessageId")]
        public Guid RequestId { get; set; }
    }
}