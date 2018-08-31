using System;
using System.Xml.Serialization;

namespace SerializionAssemblyGenerationFail
{    
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://mynamespace/1.0.0", ConfigurationName = "SHB.FORI.IncaProxy.AccountingInterface")]
    public interface AccountingInterface
    {

        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Response GetResponse([XmlElement(ElementName = "request", Namespace = "http://mynamespace/1.0.0")] Request request);

    }
}
