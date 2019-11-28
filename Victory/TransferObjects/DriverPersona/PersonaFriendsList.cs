using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaFriendsList", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaFriendsList
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.DriverPersona.FriendPersona> friendPersona {get; set;}
	}
}
