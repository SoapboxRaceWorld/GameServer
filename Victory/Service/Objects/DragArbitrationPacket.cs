using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "DragArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class DragArbitrationPacket
	{
		[DataMember]
		public System.Single FractionCompleted {get; set;}
		[DataMember]
		public System.UInt32 LongestJumpDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 NumberOfCollisions {get; set;}
		[DataMember]
		public System.Int32 PerfectStart {get; set;}
		[DataMember]
		public System.UInt32 SumOfJumpsDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Single TopSpeed {get; set;}
	}
}
