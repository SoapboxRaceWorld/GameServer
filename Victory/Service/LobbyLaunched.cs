using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyLaunched", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyLaunched
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.P2PCryptoTicket> CryptoTickets {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.LobbyEntrantInfo> Entrants {get; set;}
		[DataMember]
		public Victory.Service.SessionInfo EventSession {get; set;}
		[DataMember]
		public System.Boolean IsNewRelayServer {get; set;}
		[DataMember]
		public System.Int64 LobbyId {get; set;}
		[DataMember]
		public System.String UdpRelayHost {get; set;}
		[DataMember]
		public System.Int32 UdpRelayPort {get; set;}
	}
}
