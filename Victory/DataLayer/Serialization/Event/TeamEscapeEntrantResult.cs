using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "TeamEscapeEntrantResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class TeamEscapeEntrantResult
	{
		[DataMember]
		public System.Single DistanceToFinish {get; set;}
		[DataMember]
		public System.Single FractionCompleted {get; set;}
	}
}
