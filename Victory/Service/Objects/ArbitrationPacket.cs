using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ArbitrationPacket
	{
		[DataMember]
		public uint AlternateEventDurationInMilliseconds {get; set;}
		[DataMember]
		public long CarId {get; set;}
		[DataMember]
		public uint EventDurationInMilliseconds {get; set;}
		[DataMember]
		public int FinishReason {get; set;}
		[DataMember]
		public Victory.Service.Objects.FraudDetection FraudDetectionInfo {get; set;}
		[DataMember]
		public uint HacksDetected {get; set;}
		[DataMember]
		public Victory.Service.Objects.ClientPhysicsMetrics PhysicsMetrics {get; set;}
		[DataMember]
		public int Rank {get; set;}
		[DataMember]
		public Victory.Service.Objects.SecurityResponse Response {get; set;}
	}
}
