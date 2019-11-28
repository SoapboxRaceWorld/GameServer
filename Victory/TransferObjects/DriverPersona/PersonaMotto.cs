using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "PersonaMotto", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class PersonaMotto
	{
		[DataMember]
		public System.String message {get; set;}
		[DataMember]
		public System.Int64 personaId {get; set;}
	}
}
