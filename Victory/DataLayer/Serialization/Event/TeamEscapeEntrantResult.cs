using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "TeamEscapeEntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class TeamEscapeEntrantResult
	{
		[DataMember]
		public float DistanceToFinish {get; set;}
		[DataMember]
		public float FractionCompleted {get; set;}
	}
}
