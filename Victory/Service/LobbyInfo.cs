using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyInfo
	{
		[DataMember]
		public Victory.Service.LobbyCountdown Countdown {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.LobbyEntrantInfo> Entrants {get; set;}
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public bool IsInviteEnabled {get; set;}
		[DataMember]
		public long LobbyId {get; set;}
		[DataMember]
		public long LobbyInviteId {get; set;}
	}
}
