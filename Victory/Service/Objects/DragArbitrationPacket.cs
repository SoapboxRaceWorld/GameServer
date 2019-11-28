using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "DragArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class DragArbitrationPacket
	{
		[DataMember]
		public float FractionCompleted {get; set;}
		[DataMember]
		public uint LongestJumpDurationInMilliseconds {get; set;}
		[DataMember]
		public int NumberOfCollisions {get; set;}
		[DataMember]
		public int PerfectStart {get; set;}
		[DataMember]
		public uint SumOfJumpsDurationInMilliseconds {get; set;}
		[DataMember]
		public float TopSpeed {get; set;}
	}
}
