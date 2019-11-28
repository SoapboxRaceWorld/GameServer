using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaPresence", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaPresence
	{
		[DataMember]
		public long personaId {get; set;}
		[DataMember]
		public int presence {get; set;}
		[DataMember]
		public long userId {get; set;}
	}
}
