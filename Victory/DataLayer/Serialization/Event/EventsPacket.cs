using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventsPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventsPacket
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Event.EventDefinition> Events {get; set;}
	}
}
