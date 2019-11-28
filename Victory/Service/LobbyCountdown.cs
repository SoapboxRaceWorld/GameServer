using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyCountdown", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyCountdown
	{
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public bool IsWaiting {get; set;}
		[DataMember]
		public int LobbyCountdownInMilliseconds {get; set;}
		[DataMember]
		public long LobbyId {get; set;}
		[DataMember]
		public int LobbyStuckDurationInMilliseconds {get; set;}
	}
}
