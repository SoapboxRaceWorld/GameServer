using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantInfo
	{
		[DataMember]
		public int GridIndex {get; set;}
		[DataMember]
		public float Heat {get; set;}
		[DataMember]
		public int Level {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public Victory.Service.LobbyEntrantState State {get; set;}
	}
}
