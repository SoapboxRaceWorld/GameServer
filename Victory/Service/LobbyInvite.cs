using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyInvite", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyInvite
	{
		[DataMember]
		public System.Int32 EventId {get; set;}
		[DataMember]
		public System.Int32 InviteLifetimeInMilliseconds {get; set;}
		[DataMember]
		public System.Int64 InvitedByPersonaId {get; set;}
		[DataMember]
		public System.Boolean IsPrivate {get; set;}
		[DataMember]
		public System.Int64 LobbyInviteId {get; set;}
	}
}
