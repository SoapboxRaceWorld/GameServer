using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ArbitrationPacket
	{
		[DataMember]
		public System.UInt32 AlternateEventDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Int64 CarId {get; set;}
		[DataMember]
		public System.UInt32 EventDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 FinishReason {get; set;}
		[DataMember]
		public Victory.Service.Objects.FraudDetection FraudDetectionInfo {get; set;}
		[DataMember]
		public System.UInt32 HacksDetected {get; set;}
		[DataMember]
		public Victory.Service.Objects.ClientPhysicsMetrics PhysicsMetrics {get; set;}
		[DataMember]
		public System.Int32 Rank {get; set;}
		[DataMember]
		public Victory.Service.Objects.SecurityResponse Response {get; set;}
	}
}
