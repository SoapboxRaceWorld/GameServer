using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "TeamEscapeArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class TeamEscapeArbitrationPacket
	{
		[DataMember]
		public int BustedCount {get; set;}
		[DataMember]
		public int CopsDeployed {get; set;}
		[DataMember]
		public int CopsDisabled {get; set;}
		[DataMember]
		public int CopsRammed {get; set;}
		[DataMember]
		public int CostToState {get; set;}
		[DataMember]
		public float DistanceToFinish {get; set;}
		[DataMember]
		public float FractionCompleted {get; set;}
		[DataMember]
		public int Infractions {get; set;}
		[DataMember]
		public uint LongestJumpDurationInMilliseconds {get; set;}
		[DataMember]
		public int NumberOfCollisions {get; set;}
		[DataMember]
		public int PerfectStart {get; set;}
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
