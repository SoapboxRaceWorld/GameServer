using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "RegionInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class RegionInfo
	{
		[DataMember]
		public int CountdownProposalInMilliseconds {get; set;}
		[DataMember]
		public int DirectConnectTimeoutInMilliseconds {get; set;}
		[DataMember]
		public int DropOutTimeInMilliseconds {get; set;}
		[DataMember]
		public int EventLoadTimeoutInMilliseconds {get; set;}
		[DataMember]
		public int HeartbeatIntervalInMilliseconds {get; set;}
		[DataMember]
		public int UdpRelayBandwidthInBps {get; set;}
		[DataMember]
		public int UdpRelayTimeoutInMilliseconds {get; set;}
	}
}
