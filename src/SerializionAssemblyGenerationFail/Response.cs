using System;
using System.Xml.Serialization;

namespace SerializionAssemblyGenerationFail
{
    public class Response
    {
        [XmlElement(ElementName = "MessageId")]
        public Guid RequestId { get; set; }
    }
}