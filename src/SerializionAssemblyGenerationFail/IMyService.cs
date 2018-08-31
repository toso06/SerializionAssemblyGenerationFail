using System;
using System.Xml.Serialization;

namespace SerializionAssemblyGenerationFail
{
    public interface IMyService
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://schemas.itello.se/Inca/IncaWebServices/wsdl", ConfigurationName = "SHB.FORI.IncaProxy.AccountingInterface")]
    public interface AccountingInterface
    {

        // CODEGEN: Generating message contract since the operation getAccountingAccountBalance is neither RPC nor document wrapped.
        //[System.ServiceModel.OperationContractAttribute(Action = "getAccountingAccountBalance", ReplyAction = "*")]
        //[System.ServiceModel.FaultContractAttribute(typeof(SHB.FORI.IncaProxy.ApplicationErrorInfo), Action = "getAccountingAccountBalance", Name = "applicationErrorInfo", Namespace = "http://schemas.itello.se/Inca/IncaWebServices/messages")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        //[System.ServiceModel.ServiceKnownTypeAttribute(typeof(BankConfirmation))]
        Response GetResponse([XmlElement(ElementName = "request", Namespace = "http://mynamespace/1.0.0")] Request request);

    }
}
