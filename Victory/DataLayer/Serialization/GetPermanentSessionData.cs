using System.Runtime.Serialization;

namespace Victory.DataLayer.Serialization
{
    [DataContract(Name = "GetPermanentSessionData",
        Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
    public class GetPermanentSessionData
    {
        [DataMember] public long machineID { get; set; }
        [DataMember] public string version { get; set; }
    }
}