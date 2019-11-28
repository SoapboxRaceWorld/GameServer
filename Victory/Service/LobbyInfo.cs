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
		public System.Int32 EventId {get; set;}
		[DataMember]
		public System.Boolean IsInviteEnabled {get; set;}
		[DataMember]
		public System.Int64 LobbyId {get; set;}
		[DataMember]
		public System.Int64 LobbyInviteId {get; set;}
	}
}
