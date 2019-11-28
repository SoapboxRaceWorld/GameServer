using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantInfo
	{
		[DataMember]
		public System.Int32 GridIndex {get; set;}
		[DataMember]
		public System.Single Heat {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public Victory.Service.LobbyEntrantState State {get; set;}
	}
}
