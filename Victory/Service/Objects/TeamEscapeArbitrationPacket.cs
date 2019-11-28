using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "TeamEscapeArbitrationPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class TeamEscapeArbitrationPacket
	{
		[DataMember]
		public System.Int32 BustedCount {get; set;}
		[DataMember]
		public System.Int32 CopsDeployed {get; set;}
		[DataMember]
		public System.Int32 CopsDisabled {get; set;}
		[DataMember]
		public System.Int32 CopsRammed {get; set;}
		[DataMember]
		public System.Int32 CostToState {get; set;}
		[DataMember]
		public System.Single DistanceToFinish {get; set;}
		[DataMember]
		public System.Single FractionCompleted {get; set;}
		[DataMember]
		public System.Int32 Infractions {get; set;}
		[DataMember]
		public System.UInt32 LongestJumpDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Int32 NumberOfCollisions {get; set;}
		[DataMember]
		public System.Int32 PerfectStart {get; set;}
		[DataMember]
		public System.Int32 RoadBlocksDodged {get; set;}
		[DataMember]
		public System.Int32 SpikeStripsDodged {get; set;}
		[DataMember]
		public System.UInt32 SumOfJumpsDurationInMilliseconds {get; set;}
		[DataMember]
		public System.Single TopSpeed {get; set;}
	}
}
