using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UdpRelayInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UdpRelayInfo
	{
		[DataMember]
		public string Host {get; set;}
		[DataMember]
		public int Port {get; set;}
	}
}
