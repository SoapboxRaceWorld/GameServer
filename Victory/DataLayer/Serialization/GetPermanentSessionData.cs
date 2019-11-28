using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "GetPermanentSessionData", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class GetPermanentSessionData
	{
		[DataMember]
		public System.Int64 machineID {get; set;}
		[DataMember]
		public System.String version {get; set;}
	}
}
