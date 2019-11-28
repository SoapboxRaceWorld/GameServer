using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantRemoved", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantRemoved
	{
		[DataMember]
		public System.Int64 LobbyId {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
	}
}
