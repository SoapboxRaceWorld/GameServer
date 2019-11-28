using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UdpRelayInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UdpRelayInfo
	{
		[DataMember]
		public System.String Host {get; set;}
		[DataMember]
		public System.Int32 Port {get; set;}
	}
}
