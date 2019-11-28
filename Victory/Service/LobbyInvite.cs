using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyInvite", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyInvite
	{
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public int InviteLifetimeInMilliseconds {get; set;}
		[DataMember]
		public long InvitedByPersonaId {get; set;}
		[DataMember]
		public bool IsPrivate {get; set;}
		[DataMember]
		public long LobbyInviteId {get; set;}
	}
}
