using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "PursuitArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class PursuitArbitrationPacket
	{
		[DataMember]
		public int CopsDeployed {get; set;}
		[DataMember]
		public int CopsDisabled {get; set;}
		[DataMember]
		public int CopsRammed {get; set;}
		[DataMember]
		public int CostToState {get; set;}
		[DataMember]
		public float Heat {get; set;}
		[DataMember]
		public int Infractions {get; set;}
		[DataMember]
		public uint LongestJumpDurationInMilliseconds {get; set;}
		[DataMember]
		public int RoadBlocksDodged {get; set;}
		[DataMember]
		public int SpikeStripsDodged {get; set;}
		[DataMember]
		public uint SumOfJumpsDurationInMilliseconds {get; set;}
		[DataMember]
		public float TopSpeed {get; set;}
	}
}
