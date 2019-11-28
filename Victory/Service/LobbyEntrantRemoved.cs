using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantRemoved", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantRemoved
	{
		[DataMember]
		public long LobbyId {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
	}
}
