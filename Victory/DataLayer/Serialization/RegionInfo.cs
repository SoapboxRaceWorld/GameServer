using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "RegionInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class RegionInfo
	{
		[DataMember]
		public System.Int32 CountdownProposalInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 DirectConnectTimeoutInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 DropOutTimeInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 EventLoadTimeoutInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 HeartbeatIntervalInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 UdpRelayBandwidthInBps {get; set;}
		[DataMember]
		public System.Int32 UdpRelayTimeoutInMilliseconds {get; set;}
	}
}
