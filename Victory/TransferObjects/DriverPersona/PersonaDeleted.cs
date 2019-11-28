using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaDeleted", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaDeleted
	{
		[DataMember]
		public System.Int64 personaId {get; set;}
	}
}
