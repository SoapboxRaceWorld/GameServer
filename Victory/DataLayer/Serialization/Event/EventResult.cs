using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventResult
	{
		[DataMember]
		public Victory.DataLayer.Serialization.Event.Accolades Accolades {get; set;}
		[DataMember]
		public int Durability {get; set;}
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public long EventSessionId {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.ExitPath ExitPath {get; set;}
		[DataMember]
		public int InviteLifetimeInMilliseconds {get; set;}
		[DataMember]
		public long LobbyInviteId {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
	}
}
