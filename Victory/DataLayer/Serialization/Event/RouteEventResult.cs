using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "RouteEventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class RouteEventResult
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.RouteEntrantResult> Entrants {get; set;}
	}
}
