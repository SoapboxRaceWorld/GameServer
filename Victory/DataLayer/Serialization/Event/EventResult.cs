using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventResult", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventResult
	{
		[DataMember]
		public Victory.DataLayer.Serialization.Event.Accolades Accolades {get; set;}
		[DataMember]
		public System.Int32 Durability {get; set;}
		[DataMember]
		public System.Int32 EventId {get; set;}
		[DataMember]
		public System.Int64 EventSessionId {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Event.ExitPath ExitPath {get; set;}
		[DataMember]
		public System.Int32 InviteLifetimeInMilliseconds {get; set;}
		[DataMember]
		public System.Int64 LobbyInviteId {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
	}
}
