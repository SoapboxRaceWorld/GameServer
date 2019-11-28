using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaPresence", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaPresence
	{
		[DataMember]
		public System.Int64 personaId {get; set;}
		[DataMember]
		public System.Int32 presence {get; set;}
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
