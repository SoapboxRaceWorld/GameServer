using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantUpdated", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantUpdated
	{
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public Victory.Service.LobbyEntrantState State {get; set;}
	}
}
