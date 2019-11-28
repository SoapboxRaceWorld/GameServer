using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyCountdown", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyCountdown
	{
		[DataMember]
		public System.Int32 EventId {get; set;}
		[DataMember]
		public System.Boolean IsWaiting {get; set;}
		[DataMember]
		public System.Int32 LobbyCountdownInMilliseconds {get; set;}
		[DataMember]
		public System.Int64 LobbyId {get; set;}
		[DataMember]
		public System.Int32 LobbyStuckDurationInMilliseconds {get; set;}
	}
}
