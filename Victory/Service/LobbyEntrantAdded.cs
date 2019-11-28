using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "LobbyEntrantAdded", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class LobbyEntrantAdded
	{
		[DataMember]
		public System.Int64 LobbyId {get; set;}
	}
}
