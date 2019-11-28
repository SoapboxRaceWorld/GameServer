using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "TeamEscapeEventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class TeamEscapeEventResult
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.TeamEscapeEntrantResult> Entrants {get; set;}
	}
}
